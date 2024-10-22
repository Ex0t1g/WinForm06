namespace WinForm06
{
    partial class MenuStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStart));
            label1 = new Label();
            label2 = new Label();
            closeButton = new Button();
            nextButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 32);
            label1.Name = "label1";
            label1.Size = new Size(243, 74);
            label1.TabIndex = 0;
            label1.Text = "Мастер Установки BiCore Bank";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(48, 144);
            label2.Name = "label2";
            label2.Size = new Size(320, 112);
            label2.TabIndex = 1;
            label2.Text = "Банк только развиввается и предлагает базовые  настройки его";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(208, 304);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(304, 304);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 3;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 124);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MenuStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 341);
            Controls.Add(pictureBox1);
            Controls.Add(nextButton);
            Controls.Add(closeButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuStart";
            Text = "Мастер установки";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button closeButton;
        private Button nextButton;
        private PictureBox pictureBox1;
    }
}
