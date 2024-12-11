namespace Tyuiu.GizatullinAP.Sprint6.Task2.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_GAP = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTask_GAP = new Label();
            groupBoxInPutVarStep = new GroupBox();
            labelStopStep_GAP = new Label();
            labelStartEnd_GAP = new Label();
            textBoxInPutStartStep_GAP = new TextBox();
            textBoxInPutStopStep_GAP = new TextBox();
            buttonDoHelp_GAP = new Button();
            buttonDoResult_GAP = new Button();
            dataGridViewFunction_GAP = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Function = new DataGridViewTextBoxColumn();
            groupBoxOutPutResult_GAP = new GroupBox();
            chartFunction_GAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInPutVarStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GAP).BeginInit();
            groupBoxOutPutResult_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GAP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_GAP
            // 
            groupBoxTask_GAP.Controls.Add(pictureBox1);
            groupBoxTask_GAP.Controls.Add(labelTask_GAP);
            groupBoxTask_GAP.Location = new Point(12, 12);
            groupBoxTask_GAP.Name = "groupBoxTask_GAP";
            groupBoxTask_GAP.Size = new Size(464, 277);
            groupBoxTask_GAP.TabIndex = 1;
            groupBoxTask_GAP.TabStop = false;
            groupBoxTask_GAP.Text = " Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 38);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask_GAP
            // 
            labelTask_GAP.AutoSize = true;
            labelTask_GAP.Location = new Point(6, 19);
            labelTask_GAP.Name = "labelTask_GAP";
            labelTask_GAP.Size = new Size(382, 150);
            labelTask_GAP.TabIndex = 0;
            labelTask_GAP.Text = resources.GetString("labelTask_GAP.Text");
            // 
            // groupBoxInPutVarStep
            // 
            groupBoxInPutVarStep.Controls.Add(labelStopStep_GAP);
            groupBoxInPutVarStep.Controls.Add(labelStartEnd_GAP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStartStep_GAP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStopStep_GAP);
            groupBoxInPutVarStep.Location = new Point(12, 295);
            groupBoxInPutVarStep.Name = "groupBoxInPutVarStep";
            groupBoxInPutVarStep.Size = new Size(243, 64);
            groupBoxInPutVarStep.TabIndex = 2;
            groupBoxInPutVarStep.TabStop = false;
            groupBoxInPutVarStep.Text = "Ввод данных";
            // 
            // labelStopStep_GAP
            // 
            labelStopStep_GAP.AutoSize = true;
            labelStopStep_GAP.Location = new Point(143, 19);
            labelStopStep_GAP.Name = "labelStopStep_GAP";
            labelStopStep_GAP.Size = new Size(75, 15);
            labelStopStep_GAP.TabIndex = 4;
            labelStopStep_GAP.Text = "Конец шага:";
            // 
            // labelStartEnd_GAP
            // 
            labelStartEnd_GAP.AutoSize = true;
            labelStartEnd_GAP.Location = new Point(24, 19);
            labelStartEnd_GAP.Name = "labelStartEnd_GAP";
            labelStartEnd_GAP.Size = new Size(72, 15);
            labelStartEnd_GAP.TabIndex = 3;
            labelStartEnd_GAP.Text = "Старт шага:";
            // 
            // textBoxInPutStartStep_GAP
            // 
            textBoxInPutStartStep_GAP.Location = new Point(6, 35);
            textBoxInPutStartStep_GAP.Name = "textBoxInPutStartStep_GAP";
            textBoxInPutStartStep_GAP.Size = new Size(110, 23);
            textBoxInPutStartStep_GAP.TabIndex = 2;
            textBoxInPutStartStep_GAP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // textBoxInPutStopStep_GAP
            // 
            textBoxInPutStopStep_GAP.Location = new Point(127, 35);
            textBoxInPutStopStep_GAP.Name = "textBoxInPutStopStep_GAP";
            textBoxInPutStopStep_GAP.Size = new Size(110, 23);
            textBoxInPutStopStep_GAP.TabIndex = 1;
            textBoxInPutStopStep_GAP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // buttonDoHelp_GAP
            // 
            buttonDoHelp_GAP.BackColor = Color.DodgerBlue;
            buttonDoHelp_GAP.Location = new Point(261, 302);
            buttonDoHelp_GAP.Name = "buttonDoHelp_GAP";
            buttonDoHelp_GAP.Size = new Size(95, 57);
            buttonDoHelp_GAP.TabIndex = 3;
            buttonDoHelp_GAP.Text = "Справка";
            buttonDoHelp_GAP.UseVisualStyleBackColor = false;
            buttonDoHelp_GAP.Click += buttonHelp_Click;
            // 
            // buttonDoResult_GAP
            // 
            buttonDoResult_GAP.BackColor = Color.Green;
            buttonDoResult_GAP.Location = new Point(358, 302);
            buttonDoResult_GAP.Name = "buttonDoResult_GAP";
            buttonDoResult_GAP.Size = new Size(118, 57);
            buttonDoResult_GAP.TabIndex = 4;
            buttonDoResult_GAP.Text = "Выполнить";
            buttonDoResult_GAP.UseVisualStyleBackColor = false;
            buttonDoResult_GAP.Click += buttonDone_Click;
            buttonDoResult_GAP.MouseDown += buttonDone_MouseDown;
            buttonDoResult_GAP.MouseEnter += buttonDone_MouseEnter;
            buttonDoResult_GAP.MouseLeave += buttonDone_MouseLeave;
            // 
            // dataGridViewFunction_GAP
            // 
            dataGridViewFunction_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_GAP.Columns.AddRange(new DataGridViewColumn[] { X, Function });
            dataGridViewFunction_GAP.Location = new Point(21, 37);
            dataGridViewFunction_GAP.Name = "dataGridViewFunction_GAP";
            dataGridViewFunction_GAP.RowHeadersVisible = false;
            dataGridViewFunction_GAP.Size = new Size(121, 240);
            dataGridViewFunction_GAP.TabIndex = 5;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Function
            // 
            Function.HeaderText = "F(X)";
            Function.Name = "Function";
            Function.Width = 50;
            // 
            // groupBoxOutPutResult_GAP
            // 
            groupBoxOutPutResult_GAP.Controls.Add(chartFunction_GAP);
            groupBoxOutPutResult_GAP.Controls.Add(dataGridViewFunction_GAP);
            groupBoxOutPutResult_GAP.Location = new Point(482, 12);
            groupBoxOutPutResult_GAP.Name = "groupBoxOutPutResult_GAP";
            groupBoxOutPutResult_GAP.Size = new Size(698, 347);
            groupBoxOutPutResult_GAP.TabIndex = 6;
            groupBoxOutPutResult_GAP.TabStop = false;
            groupBoxOutPutResult_GAP.Text = "Вывод данных";
            // 
            // chartFunction_GAP
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_GAP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_GAP.Legends.Add(legend1);
            chartFunction_GAP.Location = new Point(216, 22);
            chartFunction_GAP.Name = "chartFunction_GAP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_GAP.Series.Add(series1);
            chartFunction_GAP.Size = new Size(461, 300);
            chartFunction_GAP.TabIndex = 6;
            chartFunction_GAP.Text = "График функции";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 366);
            Controls.Add(buttonDoResult_GAP);
            Controls.Add(buttonDoHelp_GAP);
            Controls.Add(groupBoxInPutVarStep);
            Controls.Add(groupBoxTask_GAP);
            Controls.Add(groupBoxOutPutResult_GAP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Гизатуллин А. П.";
            groupBoxTask_GAP.ResumeLayout(false);
            groupBoxTask_GAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInPutVarStep.ResumeLayout(false);
            groupBoxInPutVarStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GAP).EndInit();
            groupBoxOutPutResult_GAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_GAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_GAP;
        private Label labelTask_GAP;
        private PictureBox pictureBox1;
        private GroupBox groupBoxInPutVarStep;
        private Label labelStopStep_GAP;
        private Label labelStartEnd_GAP;
        private TextBox textBoxInPutStartStep_GAP;
        private TextBox textBoxInPutStopStep_GAP;
        private Button buttonDoHelp_GAP;
        private Button buttonDoResult_GAP;
        private DataGridView dataGridViewFunction_GAP;
        private GroupBox groupBoxOutPutResult_GAP;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Function;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAP;
    }
}

