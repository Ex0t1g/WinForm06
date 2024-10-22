namespace WinForm06
{
    partial class FichMenu
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(12, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(288, 48);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Пин-Код";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBoxesChanget;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(12, 93);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(288, 48);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Двухфакторнааунтефикация";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBoxesChanget;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(12, 141);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(288, 48);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Биометрия";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckBoxesChanget;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox4.Location = new Point(12, 189);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(288, 48);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Сообщение о входе";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += CheckBoxesChanget;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(317, 306);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Далее";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FichMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 341);
            Controls.Add(button2);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FichMenu";
            Text = "Выбор фич банка";
            FormClosing += ChoiseModules_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button2;
    }
}