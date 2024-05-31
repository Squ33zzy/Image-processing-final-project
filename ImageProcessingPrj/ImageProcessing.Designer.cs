namespace ImageProcessingPrj
{
    partial class ImageProcessing
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
            browseBtn = new Button();
            runBtn = new Button();
            choiceBox = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(101, 371);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(94, 29);
            browseBtn.TabIndex = 0;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // runBtn
            // 
            runBtn.Location = new Point(600, 371);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(94, 29);
            runBtn.TabIndex = 1;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // choiceBox
            // 
            choiceBox.AutoCompleteCustomSource.AddRange(new string[] { "Sobel Filter", "Median Filter", "" });
            choiceBox.FormattingEnabled = true;
            choiceBox.Items.AddRange(new object[] { "Sobel Filter", "Mean Filter", "Median Filter", "Laplacian Filter" });
            choiceBox.Location = new Point(323, 337);
            choiceBox.Name = "choiceBox";
            choiceBox.Size = new Size(151, 28);
            choiceBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(492, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 283);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(122, 178, 178);
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 54);
            label1.TabIndex = 5;
            label1.Text = "Xử lý ảnh cơ bản";
            // 
            // ImageProcessing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 232, 229);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(choiceBox);
            Controls.Add(runBtn);
            Controls.Add(browseBtn);
            Name = "ImageProcessing";
            Text = "Xử lý ảnh cơ bản";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseBtn;
        private Button runBtn;
        private ComboBox choiceBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
