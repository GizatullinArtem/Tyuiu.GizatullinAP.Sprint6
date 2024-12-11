namespace Tyuiu.GiztullinAP.Sprint6.Task1.V24
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
            groupBoxCondition_GAP = new GroupBox();
            labelTask_GAP = new Label();
            groupBoxInput_GAP = new GroupBox();
            textBoxStop_GAP = new TextBox();
            textBoxStart_GAP = new TextBox();
            labelStop_GAP = new Label();
            labelStart_GAP = new Label();
            groupBoxOutput_GAP = new GroupBox();
            textBoxResult_GAP = new TextBox();
            buttonHelp_GAP = new Button();
            buttonDone_GAP = new Button();
            groupBoxCondition_GAP.SuspendLayout();
            groupBoxInput_GAP.SuspendLayout();
            groupBoxOutput_GAP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GAP
            // 
            groupBoxCondition_GAP.Controls.Add(labelTask_GAP);
            groupBoxCondition_GAP.Location = new Point(14, 12);
            groupBoxCondition_GAP.Name = "groupBoxCondition_GAP";
            groupBoxCondition_GAP.Size = new Size(443, 273);
            groupBoxCondition_GAP.TabIndex = 0;
            groupBoxCondition_GAP.TabStop = false;
            groupBoxCondition_GAP.Text = "Условие";
            // 
            // labelTask_GAP
            // 
            labelTask_GAP.AutoSize = true;
            labelTask_GAP.Location = new Point(9, 24);
            labelTask_GAP.Name = "labelTask_GAP";
            labelTask_GAP.Size = new Size(296, 30);
            labelTask_GAP.TabIndex = 0;
            labelTask_GAP.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxInput_GAP
            // 
            groupBoxInput_GAP.Controls.Add(textBoxStop_GAP);
            groupBoxInput_GAP.Controls.Add(textBoxStart_GAP);
            groupBoxInput_GAP.Controls.Add(labelStop_GAP);
            groupBoxInput_GAP.Controls.Add(labelStart_GAP);
            groupBoxInput_GAP.Location = new Point(16, 291);
            groupBoxInput_GAP.Name = "groupBoxInput_GAP";
            groupBoxInput_GAP.Size = new Size(441, 145);
            groupBoxInput_GAP.TabIndex = 1;
            groupBoxInput_GAP.TabStop = false;
            groupBoxInput_GAP.Text = "Ввод данных";
            // 
            // textBoxStop_GAP
            // 
            textBoxStop_GAP.Location = new Point(202, 57);
            textBoxStop_GAP.Name = "textBoxStop_GAP";
            textBoxStop_GAP.Size = new Size(100, 23);
            textBoxStop_GAP.TabIndex = 3;
            // 
            // textBoxStart_GAP
            // 
            textBoxStart_GAP.Location = new Point(16, 54);
            textBoxStart_GAP.Name = "textBoxStart_GAP";
            textBoxStart_GAP.Size = new Size(100, 23);
            textBoxStart_GAP.TabIndex = 2;
            // 
            // labelStop_GAP
            // 
            labelStop_GAP.AutoSize = true;
            labelStop_GAP.Location = new Point(199, 37);
            labelStop_GAP.Name = "labelStop_GAP";
            labelStop_GAP.Size = new Size(72, 15);
            labelStop_GAP.TabIndex = 1;
            labelStop_GAP.Text = "Конец шага";
            labelStop_GAP.Click += label2_Click;
            // 
            // labelStart_GAP
            // 
            labelStart_GAP.AutoSize = true;
            labelStart_GAP.Location = new Point(13, 36);
            labelStart_GAP.Name = "labelStart_GAP";
            labelStart_GAP.Size = new Size(69, 15);
            labelStart_GAP.TabIndex = 0;
            labelStart_GAP.Text = "Старт шага";
            // 
            // groupBoxOutput_GAP
            // 
            groupBoxOutput_GAP.Controls.Add(textBoxResult_GAP);
            groupBoxOutput_GAP.Location = new Point(559, 20);
            groupBoxOutput_GAP.Name = "groupBoxOutput_GAP";
            groupBoxOutput_GAP.Size = new Size(202, 297);
            groupBoxOutput_GAP.TabIndex = 2;
            groupBoxOutput_GAP.TabStop = false;
            groupBoxOutput_GAP.Text = "Вывод";
            // 
            // textBoxResult_GAP
            // 
            textBoxResult_GAP.Location = new Point(6, 23);
            textBoxResult_GAP.Multiline = true;
            textBoxResult_GAP.Name = "textBoxResult_GAP";
            textBoxResult_GAP.Size = new Size(190, 256);
            textBoxResult_GAP.TabIndex = 0;
            // 
            // buttonHelp_GAP
            // 
            buttonHelp_GAP.BackColor = SystemColors.ActiveBorder;
            buttonHelp_GAP.Location = new Point(566, 365);
            buttonHelp_GAP.Name = "buttonHelp_GAP";
            buttonHelp_GAP.Size = new Size(58, 59);
            buttonHelp_GAP.TabIndex = 3;
            buttonHelp_GAP.Text = "?";
            buttonHelp_GAP.UseVisualStyleBackColor = false;
            buttonHelp_GAP.Click += buttonHelp_GAP_Click;
            // 
            // buttonDone_GAP
            // 
            buttonDone_GAP.BackColor = SystemColors.Info;
            buttonDone_GAP.Location = new Point(641, 365);
            buttonDone_GAP.Name = "buttonDone_GAP";
            buttonDone_GAP.Size = new Size(114, 59);
            buttonDone_GAP.TabIndex = 4;
            buttonDone_GAP.Text = "Выполнить";
            buttonDone_GAP.UseVisualStyleBackColor = false;
            buttonDone_GAP.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_GAP);
            Controls.Add(buttonHelp_GAP);
            Controls.Add(groupBoxOutput_GAP);
            Controls.Add(groupBoxInput_GAP);
            Controls.Add(groupBoxCondition_GAP);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 24 | Гизатуллин А. П.";
            groupBoxCondition_GAP.ResumeLayout(false);
            groupBoxCondition_GAP.PerformLayout();
            groupBoxInput_GAP.ResumeLayout(false);
            groupBoxInput_GAP.PerformLayout();
            groupBoxOutput_GAP.ResumeLayout(false);
            groupBoxOutput_GAP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GAP;
        private Label labelTask_GAP;
        private GroupBox groupBoxInput_GAP;
        private Label labelStop_GAP;
        private Label labelStart_GAP;
        private TextBox textBoxStop_GAP;
        private TextBox textBoxStart_GAP;
        private GroupBox groupBoxOutput_GAP;
        private TextBox textBoxResult_GAP;
        private Button buttonHelp_GAP;
        private Button buttonDone_GAP;
    }
}
