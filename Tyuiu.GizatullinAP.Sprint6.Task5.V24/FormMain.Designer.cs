namespace Tyuiu.GizatullinAP.Sprint6.Task5.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_GAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonOpen_GAP = new Button();
            buttonHelp_GAP = new Button();
            groupBoxTask_GAP = new GroupBox();
            textBoxTask_GAP = new TextBox();
            buttonDone_GAP = new Button();
            panel2 = new Panel();
            groupBoxOutPut_GAP = new GroupBox();
            dataGridView_GAP = new DataGridView();
            panel3 = new Panel();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)chart_GAP).BeginInit();
            panel1.SuspendLayout();
            groupBoxTask_GAP.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GAP).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chart_GAP
            // 
            chartArea4.Name = "ChartArea1";
            chart_GAP.ChartAreas.Add(chartArea4);
            chart_GAP.Location = new Point(9, 11);
            chart_GAP.Name = "chart_GAP";
            chart_GAP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            chart_GAP.Series.Add(series4);
            chart_GAP.Size = new Size(612, 295);
            chart_GAP.TabIndex = 0;
            chart_GAP.Text = "chart1";
            chart_GAP.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonOpen_GAP);
            panel1.Controls.Add(buttonHelp_GAP);
            panel1.Controls.Add(groupBoxTask_GAP);
            panel1.Controls.Add(buttonDone_GAP);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 100);
            panel1.TabIndex = 1;
            // 
            // buttonOpen_GAP
            // 
            buttonOpen_GAP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_GAP.BackColor = SystemColors.HotTrack;
            buttonOpen_GAP.Location = new Point(655, 12);
            buttonOpen_GAP.Name = "buttonOpen_GAP";
            buttonOpen_GAP.Size = new Size(81, 82);
            buttonOpen_GAP.TabIndex = 11;
            buttonOpen_GAP.Text = "Открыть файл";
            buttonOpen_GAP.UseVisualStyleBackColor = false;
            buttonOpen_GAP.Click += buttonOpen_Click;
            // 
            // buttonHelp_GAP
            // 
            buttonHelp_GAP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAP.BackColor = SystemColors.MenuHighlight;
            buttonHelp_GAP.Location = new Point(742, 12);
            buttonHelp_GAP.Name = "buttonHelp_GAP";
            buttonHelp_GAP.Size = new Size(66, 82);
            buttonHelp_GAP.TabIndex = 10;
            buttonHelp_GAP.Text = "Справка";
            buttonHelp_GAP.UseVisualStyleBackColor = false;
            buttonHelp_GAP.Click += buttonHelp_Click;
            // 
            // groupBoxTask_GAP
            // 
            groupBoxTask_GAP.Controls.Add(textBoxTask_GAP);
            groupBoxTask_GAP.Location = new Point(3, 3);
            groupBoxTask_GAP.Name = "groupBoxTask_GAP";
            groupBoxTask_GAP.Padding = new Padding(5);
            groupBoxTask_GAP.Size = new Size(539, 91);
            groupBoxTask_GAP.TabIndex = 0;
            groupBoxTask_GAP.TabStop = false;
            groupBoxTask_GAP.Text = "Условие:";
            // 
            // textBoxTask_GAP
            // 
            textBoxTask_GAP.BackColor = Color.White;
            textBoxTask_GAP.BorderStyle = BorderStyle.None;
            textBoxTask_GAP.Dock = DockStyle.Fill;
            textBoxTask_GAP.Location = new Point(5, 21);
            textBoxTask_GAP.Multiline = true;
            textBoxTask_GAP.Name = "textBoxTask_GAP";
            textBoxTask_GAP.ReadOnly = true;
            textBoxTask_GAP.Size = new Size(529, 65);
            textBoxTask_GAP.TabIndex = 0;
            textBoxTask_GAP.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView все элементы, равные 0. Построить диаграмму по этим значениям.\r\n\r\n\r\n";
            // 
            // buttonDone_GAP
            // 
            buttonDone_GAP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_GAP.BackColor = Color.Green;
            buttonDone_GAP.Location = new Point(548, 12);
            buttonDone_GAP.Name = "buttonDone_GAP";
            buttonDone_GAP.Size = new Size(101, 82);
            buttonDone_GAP.TabIndex = 9;
            buttonDone_GAP.Text = "Выполнить";
            buttonDone_GAP.UseVisualStyleBackColor = false;
            buttonDone_GAP.Click += buttonDone_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(groupBoxOutPut_GAP);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 311);
            panel2.TabIndex = 2;
            // 
            // groupBoxOutPut_GAP
            // 
            groupBoxOutPut_GAP.BackColor = Color.White;
            groupBoxOutPut_GAP.Controls.Add(dataGridView_GAP);
            groupBoxOutPut_GAP.Dock = DockStyle.Fill;
            groupBoxOutPut_GAP.Location = new Point(0, 0);
            groupBoxOutPut_GAP.Name = "groupBoxOutPut_GAP";
            groupBoxOutPut_GAP.Padding = new Padding(5);
            groupBoxOutPut_GAP.Size = new Size(200, 311);
            groupBoxOutPut_GAP.TabIndex = 0;
            groupBoxOutPut_GAP.TabStop = false;
            groupBoxOutPut_GAP.Text = "Вывод данных:";
            // 
            // dataGridView_GAP
            // 
            
            dataGridView_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_GAP.ColumnHeadersVisible = false;
            dataGridView_GAP.Dock = DockStyle.Fill;
            dataGridView_GAP.Location = new Point(5, 21);
            dataGridView_GAP.Name = "dataGridView_GAP";
            dataGridView_GAP.ReadOnly = true;
            dataGridView_GAP.RowHeadersVisible = false;
            dataGridView_GAP.Size = new Size(190, 285);
            dataGridView_GAP.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_GAP);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 311);
            panel3.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 311);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(840, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 24 | Гизатуллин А. П. ";
            ((System.ComponentModel.ISupportInitialize)chart_GAP).EndInit();
            panel1.ResumeLayout(false);
            groupBoxTask_GAP.ResumeLayout(false);
            groupBoxTask_GAP.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_GAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_GAP).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_GAP;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_GAP;
        private GroupBox groupBoxOutPut_GAP;
        private TextBox textBoxTask_GAP;
        private Button buttonHelp_GAP;
        private Button buttonDone_GAP;
        private Button buttonOpen_GAP;
        private DataGridView dataGridView_GAP;

    }
}