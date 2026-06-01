namespace imgStylizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Originalimg = new PictureBox();
            Generatedimg = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Originalimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Generatedimg).BeginInit();
            SuspendLayout();
            // 
            // Originalimg
            // 
            Originalimg.Image = (Image)resources.GetObject("Originalimg.Image");
            Originalimg.Location = new Point(12, 69);
            Originalimg.Name = "Originalimg";
            Originalimg.Size = new Size(330, 320);
            Originalimg.SizeMode = PictureBoxSizeMode.Zoom;
            Originalimg.TabIndex = 0;
            Originalimg.TabStop = false;
            // 
            // Generatedimg
            // 
            Generatedimg.Location = new Point(458, 69);
            Generatedimg.Name = "Generatedimg";
            Generatedimg.Size = new Size(330, 320);
            Generatedimg.SizeMode = PictureBoxSizeMode.Zoom;
            Generatedimg.TabIndex = 1;
            Generatedimg.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(351, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Generatedimg);
            Controls.Add(Originalimg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Originalimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Generatedimg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Originalimg;
        private PictureBox Generatedimg;
        private Button button1;
    }
}
