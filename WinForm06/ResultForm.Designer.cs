namespace WinForm06
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox7 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox4.AutoSize = true;
            checkBox4.Enabled = false;
            checkBox4.Font = new Font("Segoe UI", 9.75F);
            checkBox4.Location = new Point(80, 80);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(149, 21);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Сообщение о входе";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.Enabled = false;
            checkBox3.Font = new Font("Segoe UI", 9.75F);
            checkBox3.Location = new Point(80, 64);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(92, 21);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Биометрия";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Font = new Font("Segoe UI", 9.75F);
            checkBox2.Location = new Point(80, 48);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(201, 21);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Двухфакторнаяаунтификация";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Segoe UI", 9.75F);
            checkBox1.Location = new Point(80, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Пин-код";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox6.AutoSize = true;
            checkBox6.Enabled = false;
            checkBox6.Font = new Font("Segoe UI", 9.75F);
            checkBox6.Location = new Point(80, 144);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(311, 21);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "Создание защитного облака над приложением";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox5.AutoSize = true;
            checkBox5.Enabled = false;
            checkBox5.Font = new Font("Segoe UI", 9.75F);
            checkBox5.Location = new Point(80, 128);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(174, 21);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Защита от спам звонков";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox7.AutoSize = true;
            checkBox7.Enabled = false;
            checkBox7.Font = new Font("Segoe UI", 9.75F);
            checkBox7.Location = new Point(80, 160);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(194, 21);
            checkBox7.TabIndex = 5;
            checkBox7.Text = "Создать ярлык приложения";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(80, 208);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 9;
            label1.Text = "Путь установки: C:\\....";
            // 
            // button1
            // 
            button1.Location = new Point(304, 304);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 10;
            button1.Text = "Вперед";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 304);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 11;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 341);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ResultForm";
            Text = "ResultForm";
            FormClosing += ResultForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}