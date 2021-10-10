using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;

namespace Gold
{
    public partial class Lab2Form : Form
    {
        Dictionary<char, List<double>> minPoints = new Dictionary<char, List<double>>();

        public Lab2Form()
        {
            InitializeComponent();
        }

        async private void LaunchButton_click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(lowerBorderBox.Text, out double lowerBorder);
                double.TryParse(higherBorderBox.Text, out double higherBorder);
                double.TryParse(accurancyBox.Text, out double accurancy);
                Expression formulae = Infix.ParseOrThrow(formulaeBox.Text);

                int decimals = DecimalsCalc(accurancy);

                await Task.Run(() => ChartDraw(lowerBorder, higherBorder, accurancy, formulae));

                GoldenRatio(lowerBorder, higherBorder, accurancy, formulae);
                MinPoints();

                if (accurancy < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                foreach (Control control in this.Controls)
                {
                    if ((control is TextBox) && control.Text.Length == 0)
                    {
                        MessageBox.Show("Нельзя оставлять поля пустыми.");
                    }
                }
                if (double.Parse(lowerBorderBox.Text) >= double.Parse(higherBorderBox.Text))
                {
                    MessageBox.Show("Значение нижней границы больше значения верхней.");
                }
                if (double.Parse(accurancyBox.Text) < 0)
                {
                    MessageBox.Show("Значение точности меньше нуля.");
                }
                if (double.Parse(higherBorderBox.Text) - double.Parse(lowerBorderBox.Text) < double.Parse(accurancyBox.Text))
                {
                    MessageBox.Show("Значение точности больше длины отрезка.");
                }
                else
                {
                    MessageBox.Show("Некорректно задана вычисляемая функция");
                }
            }
        }

        private void ChartDraw(double start, double end, double accurancy, Expression func)
        {
            int decimals = DecimalsCalc(accurancy);
            double step = ((end - start) / 1000 > accurancy) ? (end - start) / 1000 : accurancy;
            while (start < end)
            {
                Action action = () => formulaeChart.Series[1].Points.AddXY(start, FuncValue(start, func));
                Invoke(action);
                start += step;
            }
        }

        private double FuncValue(double point, Expression func)
        {
            Dictionary<string, FloatingPoint> symbol = new Dictionary<string, FloatingPoint>()
            {
                { "x", point }
            };
            return Evaluate.Evaluate(symbol, func).RealValue;
        }

        private void GoldenRatio(double start, double end, double accurancy, Expression func)
        {
            minPoints.Clear();
            List<double> minX = new List<double>();
            List<double> minY = new List<double>();

            double Fi = (1 + Math.Sqrt(5)) / 2;
            int decimals = DecimalsCalc(accurancy);

            while (end - start >= accurancy)
            {
                minX.Add(Math.Round((end - start) / 2, decimals));
                minY.Add(Math.Round(FuncValue((end - start) / 2, func), decimals));
                
                double x1 = end - (end - start) / Fi;
                double x2 = start + (end - start) / Fi;
                if (FuncValue(x1, func) >= FuncValue(x2, func))
                {
                    start = x1;
                }
                else
                {
                    end = x2;
                }
            }
            minPoints.Add('x', minX);
            minPoints.Add('y', minY);
        }

        private void MinPoints(int pointNumber = -1)
        {
            pointNumber = (pointNumber == -1) ? minPoints.Keys.Count - 1 : pointNumber;
            double minX = minPoints['x'][pointNumber];
            double minY = minPoints['y'][pointNumber];
            minPointBox.Text = "(" + minX.ToString() + ":" + minY.ToString() + ")";
            formulaeChart.Series[0].Points.Clear();
            formulaeChart.Series[0].Points.AddXY(minX, minY);
            if (pointNumber == minPoints['x'].Count - 1)
            {
                nextMin.Enabled = false;
            }
            if (pointNumber == 0)
            {
                lastMin.Enabled = false;
            }
        }

        private void ClearButton_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Params_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (char.IsDigit(e.KeyChar) || (e.KeyChar.Equals(',') && !textBox.Text.Contains(",")) || (e.KeyChar is (char)Keys.Back) || (textBox.Text.Length.Equals(0) && e.KeyChar.Equals('-')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private int DecimalsCalc(double accurancy)
        {
            int decimals = 0;
            if (accurancy < 1)
            {
                while (accurancy < 1)
                {
                    decimals += 1;
                    accurancy *= 10;
                }
            }
            return decimals;
        }

        private void pointChange_Click(object sender, EventArgs e)
        {
            double xValue = formulaeChart.Series[0].Points[0].XValue;
            int index = minPoints['x'].IndexOf(xValue);
            if (sender == lastMin)
            {
                index -= 1;
            }
            else
            {
                index += 1;
            }
            MinPoints(index);
        }
    }
}
