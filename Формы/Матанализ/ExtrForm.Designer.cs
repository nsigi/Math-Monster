﻿namespace Professional_GUI
{
    partial class ExtrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtrForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FunctionTextBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.DiffTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Button();
            this.Opening_parenthesis = new System.Windows.Forms.Button();
            this.Closing_parenthesis = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Exponentiation = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Lg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.reader = new AxAcroPDFLib.AxAcroPDF();
            this.ChartExtremum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExtremum)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionTextBox
            // 
            this.FunctionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FunctionTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionTextBox.Location = new System.Drawing.Point(486, 140);
            this.FunctionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.Size = new System.Drawing.Size(293, 33);
            this.FunctionTextBox.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Calculate.Location = new System.Drawing.Point(709, 307);
            this.Calculate.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(70, 35);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calc";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // DiffTextBox
            // 
            this.DiffTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiffTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiffTextBox.Location = new System.Drawing.Point(484, 269);
            this.DiffTextBox.Name = "DiffTextBox";
            this.DiffTextBox.ReadOnly = true;
            this.DiffTextBox.Size = new System.Drawing.Size(295, 33);
            this.DiffTextBox.TabIndex = 4;
            this.DiffTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите функцию";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результат";
            this.label2.Visible = false;
            // 
            // X
            // 
            this.X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.X.Location = new System.Drawing.Point(490, 307);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(35, 35);
            this.X.TabIndex = 7;
            this.X.Text = "x";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Opening_parenthesis
            // 
            this.Opening_parenthesis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Opening_parenthesis.Location = new System.Drawing.Point(530, 307);
            this.Opening_parenthesis.Name = "Opening_parenthesis";
            this.Opening_parenthesis.Size = new System.Drawing.Size(35, 35);
            this.Opening_parenthesis.TabIndex = 8;
            this.Opening_parenthesis.Text = "(";
            this.Opening_parenthesis.UseVisualStyleBackColor = true;
            this.Opening_parenthesis.Click += new System.EventHandler(this.Opening_parenthesis_Click);
            // 
            // Closing_parenthesis
            // 
            this.Closing_parenthesis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Closing_parenthesis.Location = new System.Drawing.Point(570, 307);
            this.Closing_parenthesis.Name = "Closing_parenthesis";
            this.Closing_parenthesis.Size = new System.Drawing.Size(35, 35);
            this.Closing_parenthesis.TabIndex = 9;
            this.Closing_parenthesis.Text = ")";
            this.Closing_parenthesis.UseVisualStyleBackColor = true;
            this.Closing_parenthesis.Click += new System.EventHandler(this.Closing_parenthesis_Click);
            // 
            // Seven
            // 
            this.Seven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Seven.Location = new System.Drawing.Point(490, 348);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(35, 35);
            this.Seven.TabIndex = 10;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eight.Location = new System.Drawing.Point(530, 348);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(35, 35);
            this.Eight.TabIndex = 11;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nine.Location = new System.Drawing.Point(570, 348);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(35, 35);
            this.Nine.TabIndex = 12;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Four
            // 
            this.Four.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Four.Location = new System.Drawing.Point(490, 389);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(35, 35);
            this.Four.TabIndex = 13;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Five.Location = new System.Drawing.Point(530, 389);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(35, 35);
            this.Five.TabIndex = 14;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Six.Location = new System.Drawing.Point(570, 389);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(35, 35);
            this.Six.TabIndex = 15;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.One.Location = new System.Drawing.Point(490, 430);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(35, 35);
            this.One.TabIndex = 16;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Two.Location = new System.Drawing.Point(530, 430);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(35, 35);
            this.Two.TabIndex = 17;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Three.Location = new System.Drawing.Point(570, 430);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(35, 35);
            this.Three.TabIndex = 18;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Div
            // 
            this.Div.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Div.Location = new System.Drawing.Point(611, 348);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(35, 35);
            this.Div.TabIndex = 19;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Mul
            // 
            this.Mul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Mul.Location = new System.Drawing.Point(611, 389);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(35, 35);
            this.Mul.TabIndex = 20;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Minus
            // 
            this.Minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Minus.Location = new System.Drawing.Point(611, 430);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(35, 35);
            this.Minus.TabIndex = 21;
            this.Minus.Text = "—";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plus.Location = new System.Drawing.Point(611, 471);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(35, 35);
            this.Plus.TabIndex = 22;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Exponentiation
            // 
            this.Exponentiation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exponentiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Exponentiation.Location = new System.Drawing.Point(652, 389);
            this.Exponentiation.Name = "Exponentiation";
            this.Exponentiation.Size = new System.Drawing.Size(51, 35);
            this.Exponentiation.TabIndex = 23;
            this.Exponentiation.Text = "^";
            this.Exponentiation.UseVisualStyleBackColor = true;
            this.Exponentiation.Click += new System.EventHandler(this.Exponentiation_Click);
            // 
            // Sinus
            // 
            this.Sinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sinus.Location = new System.Drawing.Point(709, 348);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(70, 35);
            this.Sinus.TabIndex = 24;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.Sinus_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cosinus.Location = new System.Drawing.Point(709, 389);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(70, 35);
            this.Cosinus.TabIndex = 25;
            this.Cosinus.Text = "cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.Cosinus_Click);
            // 
            // Tg
            // 
            this.Tg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tg.Location = new System.Drawing.Point(709, 430);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(70, 35);
            this.Tg.TabIndex = 26;
            this.Tg.Text = "tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.Tg_Click);
            // 
            // Ctg
            // 
            this.Ctg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctg.Location = new System.Drawing.Point(709, 471);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(70, 35);
            this.Ctg.TabIndex = 27;
            this.Ctg.Text = "ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.Ctg_Click);
            // 
            // Ln
            // 
            this.Ln.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ln.Location = new System.Drawing.Point(652, 430);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(51, 35);
            this.Ln.TabIndex = 36;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.Ln_Click);
            // 
            // Lg
            // 
            this.Lg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lg.Location = new System.Drawing.Point(652, 471);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(51, 35);
            this.Lg.TabIndex = 37;
            this.Lg.Text = "lg";
            this.Lg.UseVisualStyleBackColor = true;
            this.Lg.Click += new System.EventHandler(this.Lg_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(652, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "☚";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.Location = new System.Drawing.Point(652, 307);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(51, 35);
            this.Delete.TabIndex = 39;
            this.Delete.Text = "CE";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Zero
            // 
            this.Zero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Zero.Location = new System.Drawing.Point(490, 471);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(35, 35);
            this.Zero.TabIndex = 40;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Point
            // 
            this.Point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Point.Location = new System.Drawing.Point(530, 471);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(35, 35);
            this.Point.TabIndex = 41;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Введите [a;b]:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(617, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 28);
            this.textBox1.TabIndex = 44;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(663, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 28);
            this.textBox2.TabIndex = 45;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(571, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 46;
            this.button2.Text = "π";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reader
            // 
            this.reader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reader.Enabled = true;
            this.reader.Location = new System.Drawing.Point(0, 0);
            this.reader.Name = "reader";
            this.reader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reader.OcxState")));
            this.reader.Size = new System.Drawing.Size(857, 601);
            this.reader.TabIndex = 47;
            // 
            // ChartExtremum
            // 
            this.ChartExtremum.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.ChartExtremum.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartExtremum.Legends.Add(legend2);
            this.ChartExtremum.Location = new System.Drawing.Point(70, 111);
            this.ChartExtremum.Margin = new System.Windows.Forms.Padding(2);
            this.ChartExtremum.Name = "ChartExtremum";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "y(x)";
            series2.Name = "Series1";
            this.ChartExtremum.Series.Add(series2);
            this.ChartExtremum.Size = new System.Drawing.Size(377, 395);
            this.ChartExtremum.TabIndex = 49;
            this.ChartExtremum.Text = "chart1";
            // 
            // ExtrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 601);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.ChartExtremum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Exponentiation);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Closing_parenthesis);
            this.Controls.Add(this.Opening_parenthesis);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiffTextBox);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.FunctionTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExtrForm";
            this.Text = "Экстремум функции";
            ((System.ComponentModel.ISupportInitialize)(this.reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExtremum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox DiffTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Opening_parenthesis;
        private System.Windows.Forms.Button Closing_parenthesis;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Exponentiation;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Lg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private AxAcroPDFLib.AxAcroPDF reader;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartExtremum;
    }
}

