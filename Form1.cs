using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO;

namespace Monte_Carlo
{
    public partial class Form1 : Form
    {
        string inside = "Внутри", outside = "Снаружи";
        public List<Double> insidePoints_1, insidePoints_2, outsidePoints_1, outsidePoints_2 = new List<Double>();
        string elapsedTime;
        double pi_ = 0.0;
        double original_pi = 3.14159;
        Stopwatch stopwatch = new Stopwatch();
        public static int inCirclePoints;

        //Settings
        public static int threadCount = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartYap(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n))
            {
                MessageBox.Show("Нужно ввести целочисленное число!", "Ошибка");
            }
            else
            {
                try
                {
                    int totalPoints = int.Parse(textBox1.Text);
                    string defaultTime = "";

                    stopwatch.Restart();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    if (Convert.ToInt64(textBox1.Text) <= 100)
                        ChartYap(4);
                    else if (Convert.ToInt64(textBox1.Text) <= 1000)
                        ChartYap(3);
                    else if (Convert.ToInt64(textBox1.Text) <= 10000)
                        ChartYap(2);
                    else
                        ChartYap(1);

                    //Первый метод
                    stopwatch.Start();
                    MonteCarloMethod(totalPoints);
                    stopwatch.Stop();
                    Draw();
                    output(Convert.ToInt64(textBox1.Text));
                    TimeSpan ts = stopwatch.Elapsed;
                    elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
                    timer_1.Text = "Последовательное\nвыполнение: " + elapsedTime + " сек.";
                    defaultTime = "Default exec. time: " + elapsedTime + "\n";
                    log_file(defaultTime);
                    logBox.Text += defaultTime;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Нужно ввести количество точек ({Convert.ToString(ex)})", "Ошибка");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n))
            {
                MessageBox.Show("Нужно ввести целочисленное число!", "Ошибка");
            }
            else
            {
                try
                {
                    int totalPoints = int.Parse(textBox1.Text);
                    string threading_time = "";

                    stopwatch.Restart();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    if (Convert.ToInt64(textBox1.Text) <= 100)
                        ChartYap(4);
                    else if (Convert.ToInt64(textBox1.Text) <= 1000)
                        ChartYap(3);
                    else if (Convert.ToInt64(textBox1.Text) <= 10000)
                        ChartYap(2);
                    else
                        ChartYap(1);

                    //Второй метод
                    stopwatch.Start();
                    Thread t = new Thread(() => MonteCarloMethod(totalPoints));
                    t.Start();
                    stopwatch.Stop();
                    Thread.Sleep(500);
                    Draw();
                    output(Convert.ToInt64(textBox1.Text));
                    TimeSpan ts = stopwatch.Elapsed;
                    elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
                    timer_2.Text = "Threads: " + elapsedTime + " сек.";
                    threading_time = "Threads exec. time: " + elapsedTime + "\n";
                    log_file(threading_time);
                    logBox.Text += threading_time;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Нужно ввести количество точек ({Convert.ToString(ex)})", "Ошибка");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n))
            {
                MessageBox.Show("Нужно ввести целочисленное число!", "Ошибка");
            }
            else
            {
                try
                {
                    int totalPoints = int.Parse(textBox1.Text);
                    string tasks_time = "";

                    stopwatch.Restart();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    if (Convert.ToInt64(textBox1.Text) <= 100)
                        ChartYap(4);
                    else if (Convert.ToInt64(textBox1.Text) <= 1000)
                        ChartYap(3);
                    else if (Convert.ToInt64(textBox1.Text) <= 10000)
                        ChartYap(2);
                    else
                        ChartYap(1);

                    //Третий метод
                    stopwatch.Start();
                    Task t = new Task(() => MonteCarloMethod(totalPoints));
                    t.Start();
                    t.Wait();
                    stopwatch.Stop();
                    Draw();
                    output(Convert.ToInt64(textBox1.Text));
                    TimeSpan ts = stopwatch.Elapsed;
                    string elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
                    timer_3.Text = "Tasks: " + elapsedTime + " сек.";
                    tasks_time = "Tasks exec. time: " + elapsedTime + "\n";
                    log_file(tasks_time);
                    logBox.Text += tasks_time;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Нужно ввести количество точек ({Convert.ToString(ex)})", "Ошибка");
                }
            }

        }

        private void ChartYap(int boyut)
        {
            chart1.Series.Clear();
            chart1.Series.Add(inside);
            chart1.Series.Add(outside);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1;

            chart1.Series[inside].ChartType = SeriesChartType.FastPoint;
            chart1.Series[inside].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[inside].MarkerSize = boyut;
            chart1.Series[inside].MarkerColor = Color.Red;

            chart1.Series[outside].ChartType = SeriesChartType.FastPoint;
            chart1.Series[outside].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[outside].MarkerSize = boyut;
            chart1.Series[outside].MarkerColor = Color.Black;
        }

        public void output(long points)
        {
            pi_ = 4 * chart1.Series[inside].Points.Count / (double)points;
            double fault_pi = Math.Round(Math.Abs(original_pi - pi_), 4);
            pi.Text = "Расчетное значение π: " + pi_.ToString();
            fault.Text = "Погрешность: " + fault_pi;
            insidePoints.Text = "Точек в круге: " + Convert.ToString(inCirclePoints);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназачена для рассчета числа ПИ методом Монте-Карло\n\n" +
                "После нажатия кнопки рассчет, происходит подсчет числа ПИ, на графике появляются точки, в поля заполняются значения\n\n" +
                "В директории с исполняемым файлом находится файл отчета о времени выполнении разными методами распараллеливания\n\n" +
                "Над программой работали:\n" +
                "Никита Абдулин - программист\n" +
                "Андрей Воротнев - документация\n" +
                "Шаимов Данил, Неволин Максим - презентация", "Информация");
        }

        public void Draw()
        {
            for (int i = 0; i < insidePoints_1.Count; i++)
            {
                chart1.Series[inside].Points.Add(new DataPoint(insidePoints_1[i], insidePoints_2[i]));
            }
            for (int i = 0; i < outsidePoints_1.Count; i++)
            {
                chart1.Series[outside].Points.Add(new DataPoint(outsidePoints_1[i], outsidePoints_2[i]));
            }
        }

        public void MonteCarloMethod(int pointNumber)
        {
            Random r = new Random();
            inCirclePoints = 0;
            if (outsidePoints_1 != null)
            {
                insidePoints_1.Clear();
                insidePoints_2.Clear();
                outsidePoints_1.Clear();
                outsidePoints_2.Clear();
            }

            insidePoints_1 = new List<Double>();
            insidePoints_2 = new List<Double>();
            outsidePoints_1 = new List<Double>();
            outsidePoints_2 = new List<Double>();
            for (int i = 1; i <= pointNumber; i++)
            {
                double point1 = r.Next(0, 100001) / 100000.0;
                double point2 = r.Next(0, 100001) / 100000.0;

                if ((point1 - 0.5) * (point1 - 0.5) + (point2 - 0.5) * (point2 - 0.5) <= 0.25)
                {
                    insidePoints_1.Add(point1);
                    insidePoints_2.Add(point2);
                    inCirclePoints++;
                }
                else
                {
                    outsidePoints_1.Add(point1);
                    outsidePoints_2.Add(point2);
                }
            }

        }

        private void clear_list_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void log_file(string line)
        {
            var fstream = new FileStream("log.txt", FileMode.Append);
            try
            {
                string formatted = line;
                byte[] buffer = Encoding.Default.GetBytes(formatted);
                fstream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fstream.Close();
            }
        }

    }

}
