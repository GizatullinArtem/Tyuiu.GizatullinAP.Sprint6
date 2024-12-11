namespace Tyuiu.GizatullinAP.Sprint6.Task0.V7
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
            label1_GAP = new Label();
            pictureBox_GAP = new PictureBox();
            groupBox2_GAP = new GroupBox();
            textBox1_GAP = new TextBox();
            label2_GAP = new Label();
            groupBox3_GAP = new GroupBox();
            textBox2_GAP = new TextBox();
            button1_GAP = new Button();
            button2_GAP = new Button();
            groupBoxCondition_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_GAP).BeginInit();
            groupBox2_GAP.SuspendLayout();
            groupBox3_GAP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GAP
            // 
            groupBoxCondition_GAP.Controls.Add(label1_GAP);
            groupBoxCondition_GAP.Controls.Add(pictureBox_GAP);
            groupBoxCondition_GAP.Location = new Point(-1, 12);
            groupBoxCondition_GAP.Name = "groupBoxCondition_GAP";
            groupBoxCondition_GAP.Size = new Size(802, 124);
            groupBoxCondition_GAP.TabIndex = 0;
            groupBoxCondition_GAP.TabStop = false;
            groupBoxCondition_GAP.Text = "Условие";
            // 
            // label1_GAP
            // 
            label1_GAP.AutoSize = true;
            label1_GAP.Location = new Point(13, 20);
            label1_GAP.Name = "label1_GAP";
            label1_GAP.Size = new Size(456, 30);
            label1_GAP.TabIndex = 1;
            label1_GAP.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. \r\nОкруглить до трёх знаков после запятой.";
            // 
            // pictureBox_GAP
            // 
            pictureBox_GAP.Image = Properties.Resources.Untitled;
            pictureBox_GAP.Location = new Point(660, 22);
            pictureBox_GAP.Name = "pictureBox_GAP";
            pictureBox_GAP.Size = new Size(129, 70);
            pictureBox_GAP.TabIndex = 0;
            pictureBox_GAP.TabStop = false;
            // 
            // groupBox2_GAP
            // 
            groupBox2_GAP.Controls.Add(textBox1_GAP);
            groupBox2_GAP.Controls.Add(label2_GAP);
            groupBox2_GAP.Location = new Point(19, 164);
            groupBox2_GAP.Name = "groupBox2_GAP";
            groupBox2_GAP.Size = new Size(259, 274);
            groupBox2_GAP.TabIndex = 1;
            groupBox2_GAP.TabStop = false;
            groupBox2_GAP.Text = "Ввод данных";
            // 
            // textBox1_GAP
            // 
            textBox1_GAP.Location = new Point(22, 57);
            textBox1_GAP.Name = "textBox1_GAP";
            textBox1_GAP.Size = new Size(100, 23);
            textBox1_GAP.TabIndex = 1;
            // 
            // label2_GAP
            // 
            label2_GAP.AutoSize = true;
            label2_GAP.Location = new Point(17, 31);
            label2_GAP.Name = "label2_GAP";
            label2_GAP.Size = new Size(86, 15);
            label2_GAP.TabIndex = 0;
            label2_GAP.Text = "Переменная X";
            // 
            // groupBox3_GAP
            // 
            groupBox3_GAP.Controls.Add(textBox2_GAP);
            groupBox3_GAP.Location = new Point(521, 178);
            groupBox3_GAP.Name = "groupBox3_GAP";
            groupBox3_GAP.Size = new Size(267, 163);
            groupBox3_GAP.TabIndex = 2;
            groupBox3_GAP.TabStop = false;
            groupBox3_GAP.Text = "Вывод данных";
            // 
            // textBox2_GAP
            // 
            textBox2_GAP.Location = new Point(17, 39);
            textBox2_GAP.Name = "textBox2_GAP";
            textBox2_GAP.Size = new Size(100, 23);
            textBox2_GAP.TabIndex = 0;
            // 
            // button1_GAP
            // 
            button1_GAP.Location = new Point(545, 384);
            button1_GAP.Name = "button1_GAP";
            button1_GAP.Size = new Size(25, 27);
            button1_GAP.TabIndex = 3;
            button1_GAP.Text = "?";
            button1_GAP.UseVisualStyleBackColor = true;
            button1_GAP.Click += button1_GAP_Click;
            // 
            // button2_GAP
            // 
            button2_GAP.Location = new Point(585, 384);
            button2_GAP.Name = "button2_GAP";
            button2_GAP.Size = new Size(158, 27);
            button2_GAP.TabIndex = 4;
            button2_GAP.Text = "Выполнить";
            button2_GAP.UseVisualStyleBackColor = true;
            button2_GAP.Click += button2_GAP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2_GAP);
            Controls.Add(button1_GAP);
            Controls.Add(groupBox3_GAP);
            Controls.Add(groupBox2_GAP);
            Controls.Add(groupBoxCondition_GAP);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition_GAP.ResumeLayout(false);
            groupBoxCondition_GAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_GAP).EndInit();
            groupBox2_GAP.ResumeLayout(false);
            groupBox2_GAP.PerformLayout();
            groupBox3_GAP.ResumeLayout(false);
            groupBox3_GAP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GAP;
        private Label label1_GAP;
        private PictureBox pictureBox_GAP;
        private GroupBox groupBox2_GAP;
        private TextBox textBox1_GAP;
        private Label label2_GAP;
        private GroupBox groupBox3_GAP;
        private TextBox textBox2_GAP;
        private Button button1_GAP;
        private Button button2_GAP;
    }
}
