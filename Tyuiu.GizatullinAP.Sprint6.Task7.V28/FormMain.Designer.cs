namespace Tyuiu.GizatullinAP.Sprint6.Task7.V28
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_GAP = new Panel();
            groupBoxCondition_GAP = new GroupBox();
            label1_GAP = new Label();
            labelCondition_GAP = new Label();
            panelTask_GAP = new Panel();
            buttonInfo_GAP = new Button();
            buttonSaveFile_GAP = new Button();
            buttonDone_GAP = new Button();
            buttonOpenFile_GAP = new Button();
            panelOutPut_GAP = new Panel();
            groupBoxOutPut_GAP = new GroupBox();
            dataGridViewOut_GAP = new DataGridView();
            panelInPut_GAP = new Panel();
            groupBoxInPut_GAP = new GroupBox();
            dataGridViewIn_GAP = new DataGridView();
            openFileDialog_GAP = new OpenFileDialog();
            saveFileDialogMatrix_GAP = new SaveFileDialog();
            toolTipButton_GAP = new ToolTip(components);
            label2_GAP = new Label();
            panelButtons_GAP.SuspendLayout();
            groupBoxCondition_GAP.SuspendLayout();
            panelTask_GAP.SuspendLayout();
            panelOutPut_GAP.SuspendLayout();
            groupBoxOutPut_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GAP).BeginInit();
            panelInPut_GAP.SuspendLayout();
            groupBoxInPut_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_GAP).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_GAP
            // 
            panelButtons_GAP.Controls.Add(groupBoxCondition_GAP);
            panelButtons_GAP.Controls.Add(panelTask_GAP);
            panelButtons_GAP.Dock = DockStyle.Top;
            panelButtons_GAP.Location = new Point(0, 0);
            panelButtons_GAP.Name = "panelButtons_GAP";
            panelButtons_GAP.Size = new Size(1172, 236);
            panelButtons_GAP.TabIndex = 0;
            // 
            // groupBoxCondition_GAP
            // 
            groupBoxCondition_GAP.Controls.Add(label2_GAP);
            groupBoxCondition_GAP.Controls.Add(label1_GAP);
            groupBoxCondition_GAP.Controls.Add(labelCondition_GAP);
            groupBoxCondition_GAP.Dock = DockStyle.Top;
            groupBoxCondition_GAP.Location = new Point(0, 129);
            groupBoxCondition_GAP.Name = "groupBoxCondition_GAP";
            groupBoxCondition_GAP.Size = new Size(1172, 99);
            groupBoxCondition_GAP.TabIndex = 1;
            groupBoxCondition_GAP.TabStop = false;
            groupBoxCondition_GAP.Text = "Условие: ";
            groupBoxCondition_GAP.Enter += groupBoxCondition_GAP_Enter;
            // 
            // label1
            // 
            label1_GAP.AutoSize = true;
            label1_GAP.Location = new Point(0, 18);
            label1_GAP.Name = "label1";
            label1_GAP.Size = new Size(0, 15);
            label1_GAP.TabIndex = 1;
            label1_GAP.Click += label1_GAP_Click;
            // 
            // labelCondition_GAP
            // 
            labelCondition_GAP.AutoSize = true;
            labelCondition_GAP.Dock = DockStyle.Fill;
            labelCondition_GAP.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_GAP.Location = new Point(3, 19);
            labelCondition_GAP.Name = "labelCondition_GAP";
            labelCondition_GAP.Size = new Size(0, 19);
            labelCondition_GAP.TabIndex = 0;
            // 
            // panelTask_GAP
            // 
            panelTask_GAP.Controls.Add(buttonInfo_GAP);
            panelTask_GAP.Controls.Add(buttonSaveFile_GAP);
            panelTask_GAP.Controls.Add(buttonDone_GAP);
            panelTask_GAP.Controls.Add(buttonOpenFile_GAP);
            panelTask_GAP.Dock = DockStyle.Top;
            panelTask_GAP.Location = new Point(0, 0);
            panelTask_GAP.Name = "panelTask_GAP";
            panelTask_GAP.Size = new Size(1172, 129);
            panelTask_GAP.TabIndex = 0;
            // 
            // buttonInfo_GAP
            // 
            buttonInfo_GAP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_GAP.Location = new Point(1063, 31);
            buttonInfo_GAP.Name = "buttonInfo_GAP";
            buttonInfo_GAP.Size = new Size(101, 78);
            buttonInfo_GAP.TabIndex = 3;
            buttonInfo_GAP.Text = "Справка";
            buttonInfo_GAP.UseVisualStyleBackColor = true;
            buttonInfo_GAP.Click += buttonInfo_GAP_Click;
            // 
            // buttonSaveFile_GAP
            // 
            buttonSaveFile_GAP.Enabled = false;
            buttonSaveFile_GAP.Location = new Point(253, 31);
            buttonSaveFile_GAP.Name = "buttonSaveFile_GAP";
            buttonSaveFile_GAP.Size = new Size(108, 78);
            buttonSaveFile_GAP.TabIndex = 2;
            buttonSaveFile_GAP.Text = "Сохранить";
            toolTipButton_GAP.SetToolTip(buttonSaveFile_GAP, " Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.\r\n\r\n\r\n");
            buttonSaveFile_GAP.UseVisualStyleBackColor = true;
            buttonSaveFile_GAP.Click += buttonSaveFile_GAP_Click;
            // 
            // buttonDone_GAP
            // 
            buttonDone_GAP.Anchor = AnchorStyles.Left;
            buttonDone_GAP.Enabled = false;
            buttonDone_GAP.Location = new Point(136, 31);
            buttonDone_GAP.Name = "buttonDone_GAP";
            buttonDone_GAP.Size = new Size(97, 78);
            buttonDone_GAP.TabIndex = 1;
            buttonDone_GAP.Text = "Выполнить";
            toolTipButton_GAP.SetToolTip(buttonDone_GAP, "Изменить в седьмой строке числа не равные 13 на 0. Результат вывести в объект dataGridViewOut.");
            buttonDone_GAP.UseVisualStyleBackColor = true;
            buttonDone_GAP.Click += buttonDone_GAP_Click;
            // 
            // buttonOpenFile_GAP
            // 
            buttonOpenFile_GAP.Location = new Point(25, 31);
            buttonOpenFile_GAP.Name = "buttonOpenFile_GAP";
            buttonOpenFile_GAP.Size = new Size(94, 78);
            buttonOpenFile_GAP.TabIndex = 0;
            buttonOpenFile_GAP.Text = "Загрузить";
            toolTipButton_GAP.SetToolTip(buttonOpenFile_GAP, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_GAP.UseVisualStyleBackColor = true;
            buttonOpenFile_GAP.Click += buttonOpenFile_GAP_Click;
            // 
            // panelOutPut_GAP
            // 
            panelOutPut_GAP.Controls.Add(groupBoxOutPut_GAP);
            panelOutPut_GAP.Dock = DockStyle.Fill;
            panelOutPut_GAP.Location = new Point(592, 236);
            panelOutPut_GAP.Name = "panelOutPut_GAP";
            panelOutPut_GAP.Size = new Size(580, 503);
            panelOutPut_GAP.TabIndex = 2;
            panelOutPut_GAP.Paint += panelOutPut_GAP_Paint;
            // 
            // groupBoxOutPut_GAP
            // 
            groupBoxOutPut_GAP.Controls.Add(dataGridViewOut_GAP);
            groupBoxOutPut_GAP.Dock = DockStyle.Fill;
            groupBoxOutPut_GAP.Location = new Point(0, 0);
            groupBoxOutPut_GAP.Name = "groupBoxOutPut_GAP";
            groupBoxOutPut_GAP.Size = new Size(580, 503);
            groupBoxOutPut_GAP.TabIndex = 0;
            groupBoxOutPut_GAP.TabStop = false;
            groupBoxOutPut_GAP.Text = "Вывод:";
            // 
            // dataGridViewOut_GAP
            // 
            dataGridViewOut_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_GAP.Dock = DockStyle.Fill;
            dataGridViewOut_GAP.Location = new Point(3, 19);
            dataGridViewOut_GAP.Name = "dataGridViewOut_GAP";
            dataGridViewOut_GAP.RowHeadersVisible = false;
            dataGridViewOut_GAP.RowHeadersWidth = 51;
            dataGridViewOut_GAP.RowTemplate.Height = 24;
            dataGridViewOut_GAP.Size = new Size(574, 481);
            dataGridViewOut_GAP.TabIndex = 0;
            // 
            // panelInPut_GAP
            // 
            panelInPut_GAP.Controls.Add(groupBoxInPut_GAP);
            panelInPut_GAP.Dock = DockStyle.Left;
            panelInPut_GAP.Location = new Point(0, 236);
            panelInPut_GAP.Name = "panelInPut_GAP";
            panelInPut_GAP.Size = new Size(592, 503);
            panelInPut_GAP.TabIndex = 3;
            // 
            // groupBoxInPut_GAP
            // 
            groupBoxInPut_GAP.Controls.Add(dataGridViewIn_GAP);
            groupBoxInPut_GAP.Dock = DockStyle.Fill;
            groupBoxInPut_GAP.Location = new Point(0, 0);
            groupBoxInPut_GAP.Name = "groupBoxInPut_GAP";
            groupBoxInPut_GAP.Size = new Size(592, 503);
            groupBoxInPut_GAP.TabIndex = 0;
            groupBoxInPut_GAP.TabStop = false;
            groupBoxInPut_GAP.Text = "Ввод:";
            // 
            // dataGridViewIn_GAP
            // 
            dataGridViewIn_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_GAP.Dock = DockStyle.Fill;
            dataGridViewIn_GAP.Location = new Point(3, 19);
            dataGridViewIn_GAP.Name = "dataGridViewIn_GAP";
            dataGridViewIn_GAP.RowHeadersVisible = false;
            dataGridViewIn_GAP.RowHeadersWidth = 51;
            dataGridViewIn_GAP.RowTemplate.Height = 24;
            dataGridViewIn_GAP.Size = new Size(586, 481);
            dataGridViewIn_GAP.TabIndex = 0;
            // 
            // openFileDialog_GAP
            // 
            openFileDialog_GAP.FileName = "openFileDialog1";
            openFileDialog_GAP.FileOk += openFileDialog_GAP_FileOk;
            // 
            // toolTipButton_GAP
            // 
            toolTipButton_GAP.IsBalloon = true;
            // 
            // label2
            // 
            label2_GAP.AutoSize = true;
            label2_GAP.Location = new Point(10, 21);
            label2_GAP.Name = "label2";
            label2_GAP.Size = new Size(933, 30);
            label2_GAP.TabIndex = 2;
            label2_GAP.Text = resources.GetString("label2.Text");
            label2_GAP.Click += this.label2_GAP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 739);
            Controls.Add(panelOutPut_GAP);
            Controls.Add(panelInPut_GAP);
            Controls.Add(panelButtons_GAP);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Гизатуллин А. П.";
            panelButtons_GAP.ResumeLayout(false);
            groupBoxCondition_GAP.ResumeLayout(false);
            groupBoxCondition_GAP.PerformLayout();
            panelTask_GAP.ResumeLayout(false);
            panelOutPut_GAP.ResumeLayout(false);
            groupBoxOutPut_GAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GAP).EndInit();
            panelInPut_GAP.ResumeLayout(false);
            groupBoxInPut_GAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_GAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_GAP;
        private System.Windows.Forms.GroupBox groupBoxCondition_GAP;
        private System.Windows.Forms.Label labelCondition_GAP;
        private System.Windows.Forms.Panel panelTask_GAP;
        private System.Windows.Forms.Panel panelOutPut_GAP;
        private System.Windows.Forms.Panel panelInPut_GAP;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GAP;
        private System.Windows.Forms.DataGridView dataGridViewOut_GAP;
        private System.Windows.Forms.GroupBox groupBoxInPut_GAP;
        private System.Windows.Forms.DataGridView dataGridViewIn_GAP;
        private System.Windows.Forms.Button buttonDone_GAP;
        private System.Windows.Forms.Button buttonOpenFile_GAP;
        private System.Windows.Forms.Button buttonInfo_GAP;
        private System.Windows.Forms.Button buttonSaveFile_GAP;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GAP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GAP;
        private System.Windows.Forms.ToolTip toolTipButton_GAP;
        private Label label1_GAP;
        private Label label2_GAP;
    }
}