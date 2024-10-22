namespace WinForm06
{
    partial class MenuOpt
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
            button2 = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(293, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Далее";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9.75F);
            checkBox3.Location = new Point(37, 127);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(194, 21);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Создать ярлык приложения";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckBoxesChanget;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9.75F);
            checkBox2.Location = new Point(37, 79);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(296, 21);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Создание Защитного облака на приложение";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBoxesChanget;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F);
            checkBox1.Location = new Point(37, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Защита от спам звонков";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBoxesChanget;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(208, 288);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuOpt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 341);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuOpt";
            Text = "MenuOpt";
            FormClosing += ChoiseOptions_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
    }
}