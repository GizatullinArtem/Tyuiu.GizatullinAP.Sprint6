namespace Tyuiu.GizatullinAP.Sprint6.Task6.V29
{
    partial class Form1
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
            panelUP_GAP = new Panel();
            buttonHelp_GAP = new Button();
            buttonLoad_GAP = new Button();
            buttonStart_GAP = new Button();
            groupBoxTask_GAP = new GroupBox();
            textBoxTask_GAP = new TextBox();
            panelFill_GAP = new Panel();
            groupBoxOutput_GAP = new GroupBox();
            textBoxOutput_GAP = new TextBox();
            panelLeft_GAP = new Panel();
            groupBoxInput_GAP = new GroupBox();
            textBoxInput_GAP = new TextBox();
            splitter1 = new Splitter();
            openFileDialog_GAP = new OpenFileDialog();
            toolTipHelp_GAP = new ToolTip(components);
            panelUP_GAP.SuspendLayout();
            groupBoxTask_GAP.SuspendLayout();
            panelFill_GAP.SuspendLayout();
            groupBoxOutput_GAP.SuspendLayout();
            panelLeft_GAP.SuspendLayout();
            groupBoxInput_GAP.SuspendLayout();
            SuspendLayout();
            // 
            // panelUP_GAP
            // 
            panelUP_GAP.Controls.Add(buttonHelp_GAP);
            panelUP_GAP.Controls.Add(buttonLoad_GAP);
            panelUP_GAP.Controls.Add(buttonStart_GAP);
            panelUP_GAP.Controls.Add(groupBoxTask_GAP);
            panelUP_GAP.Dock = DockStyle.Top;
            panelUP_GAP.Location = new Point(0, 0);
            panelUP_GAP.Name = "panelUP_GAP";
            panelUP_GAP.Size = new Size(784, 162);
            panelUP_GAP.TabIndex = 0;
            // 
            // buttonHelp_GAP
            // 
            buttonHelp_GAP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAP.Location = new Point(692, 12);
            buttonHelp_GAP.Name = "buttonHelp_GAP";
            buttonHelp_GAP.Size = new Size(80, 80);
            buttonHelp_GAP.TabIndex = 2;
            buttonHelp_GAP.Text = "Справка";
            toolTipHelp_GAP.SetToolTip(buttonHelp_GAP, "Информация об авторе приложения");
            buttonHelp_GAP.UseVisualStyleBackColor = true;
            buttonHelp_GAP.Click += buttonHelp_GAP_Click;
            // 
            // buttonLoad_GAP
            // 
            buttonLoad_GAP.Location = new Point(12, 12);
            buttonLoad_GAP.Name = "buttonLoad_GAP";
            buttonLoad_GAP.Size = new Size(80, 80);
            buttonLoad_GAP.TabIndex = 2;
            buttonLoad_GAP.Text = "Загрузить";
            toolTipHelp_GAP.SetToolTip(buttonLoad_GAP, "Загрузка файла");
            buttonLoad_GAP.UseVisualStyleBackColor = true;
            buttonLoad_GAP.Click += buttonLoad_GAP_Click;
            // 
            // buttonStart_GAP
            // 
            buttonStart_GAP.Enabled = false;
            buttonStart_GAP.Location = new Point(98, 12);
            buttonStart_GAP.Name = "buttonStart_GAP";
            buttonStart_GAP.Size = new Size(80, 80);
            buttonStart_GAP.TabIndex = 2;
            buttonStart_GAP.Text = "Выполнить";
            toolTipHelp_GAP.SetToolTip(buttonStart_GAP, "Запуск обработки файла");
            buttonStart_GAP.UseVisualStyleBackColor = true;
            buttonStart_GAP.Click += buttonStart_GAP_Click;
            // 
            // groupBoxTask_GAP
            // 
            groupBoxTask_GAP.Controls.Add(textBoxTask_GAP);
            groupBoxTask_GAP.Dock = DockStyle.Bottom;
            groupBoxTask_GAP.Location = new Point(0, 98);
            groupBoxTask_GAP.Name = "groupBoxTask_GAP";
            groupBoxTask_GAP.Size = new Size(784, 64);
            groupBoxTask_GAP.TabIndex = 0;
            groupBoxTask_GAP.TabStop = false;
            groupBoxTask_GAP.Text = "Условие";
            // 
            // textBoxTask_GAP
            // 
            textBoxTask_GAP.BackColor = SystemColors.Control;
            textBoxTask_GAP.BorderStyle = BorderStyle.None;
            textBoxTask_GAP.Dock = DockStyle.Fill;
            textBoxTask_GAP.Location = new Point(3, 19);
            textBoxTask_GAP.Multiline = true;
            textBoxTask_GAP.Name = "textBoxTask_GAP";
            textBoxTask_GAP.ReadOnly = true;
            textBoxTask_GAP.Size = new Size(778, 42);
            textBoxTask_GAP.TabIndex = 0;
            // 
            // panelFill_GAP
            // 
            panelFill_GAP.Controls.Add(groupBoxOutput_GAP);
            panelFill_GAP.Dock = DockStyle.Fill;
            panelFill_GAP.Location = new Point(394, 162);
            panelFill_GAP.Name = "panelFill_GAP";
            panelFill_GAP.Size = new Size(390, 349);
            panelFill_GAP.TabIndex = 1;
            // 
            // groupBoxOutput_GAP
            // 
            groupBoxOutput_GAP.Controls.Add(textBoxOutput_GAP);
            groupBoxOutput_GAP.Dock = DockStyle.Fill;
            groupBoxOutput_GAP.Location = new Point(0, 0);
            groupBoxOutput_GAP.Name = "groupBoxOutput_GAP";
            groupBoxOutput_GAP.Size = new Size(390, 349);
            groupBoxOutput_GAP.TabIndex = 0;
            groupBoxOutput_GAP.TabStop = false;
            groupBoxOutput_GAP.Text = "Вывод:";
            // 
            // textBoxOutput_GAP
            // 
            textBoxOutput_GAP.BackColor = SystemColors.Window;
            textBoxOutput_GAP.Dock = DockStyle.Fill;
            textBoxOutput_GAP.Location = new Point(3, 19);
            textBoxOutput_GAP.Multiline = true;
            textBoxOutput_GAP.Name = "textBoxOutput_GAP";
            textBoxOutput_GAP.ReadOnly = true;
            textBoxOutput_GAP.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_GAP.Size = new Size(384, 327);
            textBoxOutput_GAP.TabIndex = 0;
            textBoxOutput_GAP.TextChanged += textBoxOutput_GAP_TextChanged;
            // 
            // panelLeft_GAP
            // 
            panelLeft_GAP.Controls.Add(groupBoxInput_GAP);
            panelLeft_GAP.Dock = DockStyle.Left;
            panelLeft_GAP.Location = new Point(0, 162);
            panelLeft_GAP.Name = "panelLeft_GAP";
            panelLeft_GAP.Size = new Size(391, 349);
            panelLeft_GAP.TabIndex = 2;
            // 
            // groupBoxInput_GAP
            // 
            groupBoxInput_GAP.Controls.Add(textBoxInput_GAP);
            groupBoxInput_GAP.Dock = DockStyle.Fill;
            groupBoxInput_GAP.Location = new Point(0, 0);
            groupBoxInput_GAP.Name = "groupBoxInput_GAP";
            groupBoxInput_GAP.Size = new Size(391, 349);
            groupBoxInput_GAP.TabIndex = 0;
            groupBoxInput_GAP.TabStop = false;
            groupBoxInput_GAP.Text = "Ввод:";
            // 
            // textBoxInput_GAP
            // 
            textBoxInput_GAP.BackColor = SystemColors.Window;
            textBoxInput_GAP.Dock = DockStyle.Fill;
            textBoxInput_GAP.Location = new Point(3, 19);
            textBoxInput_GAP.Multiline = true;
            textBoxInput_GAP.Name = "textBoxInput_GAP";
            textBoxInput_GAP.ReadOnly = true;
            textBoxInput_GAP.ScrollBars = ScrollBars.Vertical;
            textBoxInput_GAP.Size = new Size(385, 327);
            textBoxInput_GAP.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(391, 162);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 349);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialog_GAP
            // 
            openFileDialog_GAP.FileName = "openFileDialogLoad";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(panelFill_GAP);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_GAP);
            Controls.Add(panelUP_GAP);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 29 | Гизатуллин А. П.";
            panelUP_GAP.ResumeLayout(false);
            groupBoxTask_GAP.ResumeLayout(false);
            groupBoxTask_GAP.PerformLayout();
            panelFill_GAP.ResumeLayout(false);
            groupBoxOutput_GAP.ResumeLayout(false);
            groupBoxOutput_GAP.PerformLayout();
            panelLeft_GAP.ResumeLayout(false);
            groupBoxInput_GAP.ResumeLayout(false);
            groupBoxInput_GAP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelUP_GAP;
        private Panel panelFill_GAP;
        private Panel panelLeft_GAP;
        private Splitter splitter1;
        private GroupBox groupBoxTask_GAP;
        private TextBox textBoxTask_GAP;
        private GroupBox groupBoxInput_GAP;
        private TextBox textBoxInput_GAP;
        private Button buttonHelp_GAP;
        private Button buttonLoad_GAP;
        private Button buttonStart_GAP;
        private GroupBox groupBoxOutput_GAP;
        private TextBox textBoxOutput_GAP;
        private OpenFileDialog openFileDialog_GAP;
        private ToolTip toolTipHelp_GAP;
    }
}