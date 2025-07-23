namespace WinFormDemo
{
    partial class Courses
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
            courseImage = new PictureBox();
            previous = new Button();
            next = new Button();
            ((System.ComponentModel.ISupportInitialize)courseImage).BeginInit();
            SuspendLayout();
            // 
            // courseImage
            // 
            courseImage.Location = new Point(152, 67);
            courseImage.Name = "courseImage";
            courseImage.Size = new Size(483, 274);
            courseImage.TabIndex = 0;
            courseImage.TabStop = false;
            // 
            // previous
            // 
            previous.Location = new Point(152, 361);
            previous.Name = "previous";
            previous.Size = new Size(177, 45);
            previous.TabIndex = 1;
            previous.Text = "Previous";
            previous.UseVisualStyleBackColor = true;
            previous.Click += previous_Click;
            // 
            // next
            // 
            next.Location = new Point(458, 361);
            next.Name = "next";
            next.Size = new Size(177, 45);
            next.TabIndex = 2;
            next.Text = "Next";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(next);
            Controls.Add(previous);
            Controls.Add(courseImage);
            Name = "Courses";
            Text = "Courses";
            Load += Courses_Load;
            ((System.ComponentModel.ISupportInitialize)courseImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox courseImage;
        private Button previous;
        private Button next;
    }
}
