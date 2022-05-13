
namespace Monte_Carlo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_list = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.insidePoints = new System.Windows.Forms.Label();
            this.fault = new System.Windows.Forms.Label();
            this.pi = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.originalPi = new System.Windows.Forms.Label();
            this.timer_2 = new System.Windows.Forms.Label();
            this.timer_1 = new System.Windows.Forms.Label();
            this.timer_3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_list);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // clear_list
            // 
            this.clear_list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_list.Location = new System.Drawing.Point(6, 213);
            this.clear_list.Name = "clear_list";
            this.clear_list.Size = new System.Drawing.Size(188, 26);
            this.clear_list.TabIndex = 7;
            this.clear_list.Text = "Очистить поле";
            this.clear_list.UseVisualStyleBackColor = true;
            this.clear_list.Click += new System.EventHandler(this.clear_list_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(5, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Подсчет методом Tasks";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(5, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Подсчет методом Thread";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подсчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество точек:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.logBox);
            this.groupBox2.Controls.Add(this.insidePoints);
            this.groupBox2.Controls.Add(this.fault);
            this.groupBox2.Controls.Add(this.pi);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // insidePoints
            // 
            this.insidePoints.AutoSize = true;
            this.insidePoints.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insidePoints.Location = new System.Drawing.Point(6, 83);
            this.insidePoints.Name = "insidePoints";
            this.insidePoints.Size = new System.Drawing.Size(152, 22);
            this.insidePoints.TabIndex = 6;
            this.insidePoints.Text = "Точек в круге: ";
            // 
            // fault
            // 
            this.fault.AutoSize = true;
            this.fault.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fault.Location = new System.Drawing.Point(6, 51);
            this.fault.Name = "fault";
            this.fault.Size = new System.Drawing.Size(149, 22);
            this.fault.TabIndex = 5;
            this.fault.Text = "Погрешность: ";
            // 
            // pi
            // 
            this.pi.AutoSize = true;
            this.pi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pi.Location = new System.Drawing.Point(6, 20);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(234, 22);
            this.pi.TabIndex = 3;
            this.pi.Text = "Расчетное значение π: ";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(232, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(540, 415);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Число π:";
            // 
            // originalPi
            // 
            this.originalPi.AutoSize = true;
            this.originalPi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalPi.Location = new System.Drawing.Point(131, 12);
            this.originalPi.Name = "originalPi";
            this.originalPi.Size = new System.Drawing.Size(81, 22);
            this.originalPi.TabIndex = 8;
            this.originalPi.Text = "3,14159";
            // 
            // timer_2
            // 
            this.timer_2.AutoSize = true;
            this.timer_2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_2.Location = new System.Drawing.Point(9, 66);
            this.timer_2.Name = "timer_2";
            this.timer_2.Size = new System.Drawing.Size(100, 22);
            this.timer_2.TabIndex = 7;
            this.timer_2.Text = "Threads: ";
            // 
            // timer_1
            // 
            this.timer_1.AutoSize = true;
            this.timer_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_1.Location = new System.Drawing.Point(10, 21);
            this.timer_1.Name = "timer_1";
            this.timer_1.Size = new System.Drawing.Size(156, 36);
            this.timer_1.TabIndex = 8;
            this.timer_1.Text = "Последовательное \r\nвыполнение: ";
            // 
            // timer_3
            // 
            this.timer_3.AutoSize = true;
            this.timer_3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_3.Location = new System.Drawing.Point(9, 99);
            this.timer_3.Name = "timer_3";
            this.timer_3.Size = new System.Drawing.Size(78, 22);
            this.timer_3.TabIndex = 9;
            this.timer_3.Text = "Tasks: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timer_3);
            this.groupBox3.Controls.Add(this.timer_1);
            this.groupBox3.Controls.Add(this.timer_2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 133);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время выполнения";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(526, 32);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(223, 73);
            this.logBox.TabIndex = 7;
            this.logBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчет:";
            // 
            // button4
            // 
            this.button4.Image = global::Monte_Carlo.Properties.Resources.information_icon__1_;
            this.button4.Location = new System.Drawing.Point(12, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.originalPi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monte-Carlo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label insidePoints;
        private System.Windows.Forms.Label pi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label fault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label originalPi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label timer_2;
        private System.Windows.Forms.Label timer_1;
        private System.Windows.Forms.Label timer_3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clear_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button button4;
    }
}

