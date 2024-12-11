namespace Tyuiu.GizatullinAP.Sprint6.Task3.V6
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
            groupBoxMain_GAP = new GroupBox();
            textBoxCondition_GAP = new TextBox();
            groupBoxInput_GAP = new GroupBox();
            dataGridViewMatrix_GAP = new DataGridView();
            groupBoxOutput_GAP = new GroupBox();
            dataGridViewResult_GAP = new DataGridView();
            labelResult_GAP = new Label();
            buttonDone_GAP = new Button();
            buttonHelp_GAP = new Button();
            groupBoxMain_GAP.SuspendLayout();
            groupBoxInput_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GAP).BeginInit();
            groupBoxOutput_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GAP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_GAP
            // 
            groupBoxMain_GAP.AccessibleName = "Условие";
            groupBoxMain_GAP.Controls.Add(textBoxCondition_GAP);
            groupBoxMain_GAP.Location = new Point(12, 12);
            groupBoxMain_GAP.Name = "groupBoxMain_GAP";
            groupBoxMain_GAP.Size = new Size(336, 346);
            groupBoxMain_GAP.TabIndex = 0;
            groupBoxMain_GAP.TabStop = false;
            groupBoxMain_GAP.Text = "Условие";
            // 
            // textBoxCondition_GAP
            // 
            textBoxCondition_GAP.BackColor = SystemColors.Menu;
            textBoxCondition_GAP.BorderStyle = BorderStyle.None;
            textBoxCondition_GAP.Location = new Point(6, 22);
            textBoxCondition_GAP.Multiline = true;
            textBoxCondition_GAP.Name = "textBoxCondition_GAP";
            textBoxCondition_GAP.ReadOnly = true;
            textBoxCondition_GAP.Size = new Size(320, 68);
            textBoxCondition_GAP.TabIndex = 1;
            textBoxCondition_GAP.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.\r\n\r\nРезультат вывести в DataGridView.\r\n";
            // 
            // groupBoxInput_GAP
            // 
            groupBoxInput_GAP.Controls.Add(dataGridViewMatrix_GAP);
            groupBoxInput_GAP.Location = new Point(354, 12);
            groupBoxInput_GAP.Name = "groupBoxInput_GAP";
            groupBoxInput_GAP.Size = new Size(257, 346);
            groupBoxInput_GAP.TabIndex = 1;
            groupBoxInput_GAP.TabStop = false;
            groupBoxInput_GAP.Text = "Ввод данных";
            // 
            // dataGridViewMatrix_GAP
            // 
            dataGridViewMatrix_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_GAP.ColumnHeadersVisible = false;
            dataGridViewMatrix_GAP.Location = new Point(22, 44);
            dataGridViewMatrix_GAP.Name = "dataGridViewMatrix_GAP";
            dataGridViewMatrix_GAP.RowHeadersVisible = false;
            dataGridViewMatrix_GAP.Size = new Size(219, 284);
            dataGridViewMatrix_GAP.TabIndex = 3;
            // 
            // groupBoxOutput_GAP
            // 
            groupBoxOutput_GAP.Controls.Add(dataGridViewResult_GAP);
            groupBoxOutput_GAP.Controls.Add(labelResult_GAP);
            groupBoxOutput_GAP.Location = new Point(620, 12);
            groupBoxOutput_GAP.Name = "groupBoxOutput_GAP";
            groupBoxOutput_GAP.Size = new Size(241, 346);
            groupBoxOutput_GAP.TabIndex = 2;
            groupBoxOutput_GAP.TabStop = false;
            groupBoxOutput_GAP.Text = "Вывод данных";
            // 
            // dataGridViewResult_GAP
            // 
            dataGridViewResult_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_GAP.ColumnHeadersVisible = false;
            dataGridViewResult_GAP.Location = new Point(16, 44);
            dataGridViewResult_GAP.Name = "dataGridViewResult_GAP";
            dataGridViewResult_GAP.RowHeadersVisible = false;
            dataGridViewResult_GAP.Size = new Size(219, 284);
            dataGridViewResult_GAP.TabIndex = 2;
            // 
            // labelResult_GAP
            // 
            labelResult_GAP.AutoSize = true;
            labelResult_GAP.Location = new Point(16, 26);
            labelResult_GAP.Name = "labelResult_GAP";
            labelResult_GAP.Size = new Size(63, 15);
            labelResult_GAP.TabIndex = 1;
            labelResult_GAP.Text = "Результат:";
            // 
            // buttonDone_GAP
            // 
            buttonDone_GAP.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_GAP.Location = new Point(709, 364);
            buttonDone_GAP.Name = "buttonDone_GAP";
            buttonDone_GAP.Size = new Size(152, 35);
            buttonDone_GAP.TabIndex = 3;
            buttonDone_GAP.Text = "Выполнить";
            buttonDone_GAP.UseVisualStyleBackColor = false;
            buttonDone_GAP.Click += buttonDone_GAP_Click;
            // 
            // buttonHelp_GAP
            // 
            buttonHelp_GAP.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp_GAP.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAP.Location = new Point(663, 364);
            buttonHelp_GAP.Name = "buttonHelp_GAP";
            buttonHelp_GAP.Size = new Size(36, 35);
            buttonHelp_GAP.TabIndex = 4;
            buttonHelp_GAP.Text = "?";
            buttonHelp_GAP.UseVisualStyleBackColor = false;
            buttonHelp_GAP.Click += buttonHelp_GAP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 411);
            Controls.Add(buttonHelp_GAP);
            Controls.Add(buttonDone_GAP);
            Controls.Add(groupBoxOutput_GAP);
            Controls.Add(groupBoxInput_GAP);
            Controls.Add(groupBoxMain_GAP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Гизатуллин А. П.";
            Load += FormMain_Load;
            groupBoxMain_GAP.ResumeLayout(false);
            groupBoxMain_GAP.PerformLayout();
            groupBoxInput_GAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GAP).EndInit();
            groupBoxOutput_GAP.ResumeLayout(false);
            groupBoxOutput_GAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_GAP;
        private GroupBox groupBoxInput_GAP;
        private GroupBox groupBoxOutput_GAP;
        private Label labelResult_GAP;
        private Button buttonDone_GAP;
        private Button buttonHelp_GAP;
        private TextBox textBoxCondition_GAP;
        private DataGridView dataGridViewResult_GAP;
        private DataGridView dataGridViewMatrix_GAP;

    }
}