namespace ImageProcessingTake2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grayscaleBtn = new System.Windows.Forms.Button();
            this.invertBtn = new System.Windows.Forms.Button();
            this.histBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sepiaBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.loadBGBtn = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.cameraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(318, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 318);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(63, 23);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(81, 318);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(63, 23);
            this.copyBtn.TabIndex = 3;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // grayscaleBtn
            // 
            this.grayscaleBtn.Location = new System.Drawing.Point(150, 318);
            this.grayscaleBtn.Name = "grayscaleBtn";
            this.grayscaleBtn.Size = new System.Drawing.Size(63, 23);
            this.grayscaleBtn.TabIndex = 4;
            this.grayscaleBtn.Text = "Grayscale";
            this.grayscaleBtn.UseVisualStyleBackColor = true;
            this.grayscaleBtn.Click += new System.EventHandler(this.grayscaleBtn_Click);
            // 
            // invertBtn
            // 
            this.invertBtn.Location = new System.Drawing.Point(150, 347);
            this.invertBtn.Name = "invertBtn";
            this.invertBtn.Size = new System.Drawing.Size(63, 23);
            this.invertBtn.TabIndex = 5;
            this.invertBtn.Text = "Invert";
            this.invertBtn.UseVisualStyleBackColor = true;
            this.invertBtn.Click += new System.EventHandler(this.invertBtn_Click);
            // 
            // histBtn
            // 
            this.histBtn.Location = new System.Drawing.Point(81, 347);
            this.histBtn.Name = "histBtn";
            this.histBtn.Size = new System.Drawing.Size(63, 23);
            this.histBtn.TabIndex = 6;
            this.histBtn.Text = "Histogram";
            this.histBtn.UseVisualStyleBackColor = true;
            this.histBtn.Click += new System.EventHandler(this.histBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 347);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(63, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // sepiaBtn
            // 
            this.sepiaBtn.Location = new System.Drawing.Point(150, 376);
            this.sepiaBtn.Name = "sepiaBtn";
            this.sepiaBtn.Size = new System.Drawing.Size(63, 23);
            this.sepiaBtn.TabIndex = 8;
            this.sepiaBtn.Text = "Sepia";
            this.sepiaBtn.UseVisualStyleBackColor = true;
            this.sepiaBtn.Click += new System.EventHandler(this.sepiaBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(318, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // loadBGBtn
            // 
            this.loadBGBtn.Location = new System.Drawing.Point(249, 318);
            this.loadBGBtn.Name = "loadBGBtn";
            this.loadBGBtn.Size = new System.Drawing.Size(63, 23);
            this.loadBGBtn.TabIndex = 10;
            this.loadBGBtn.Text = "Load BG";
            this.loadBGBtn.UseVisualStyleBackColor = true;
            this.loadBGBtn.Click += new System.EventHandler(this.loadBGBtn_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Location = new System.Drawing.Point(249, 347);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(63, 23);
            this.subtractBtn.TabIndex = 11;
            this.subtractBtn.Text = "Subtract";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.subtractBtn_Click);
            // 
            // cameraBtn
            // 
            this.cameraBtn.Location = new System.Drawing.Point(81, 376);
            this.cameraBtn.Name = "cameraBtn";
            this.cameraBtn.Size = new System.Drawing.Size(63, 23);
            this.cameraBtn.TabIndex = 12;
            this.cameraBtn.Text = "Camera";
            this.cameraBtn.UseVisualStyleBackColor = true;
            this.cameraBtn.Click += new System.EventHandler(this.cameraBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 622);
            this.Controls.Add(this.cameraBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.loadBGBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.sepiaBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.histBtn);
            this.Controls.Add(this.invertBtn);
            this.Controls.Add(this.grayscaleBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button grayscaleBtn;
        private System.Windows.Forms.Button invertBtn;
        private System.Windows.Forms.Button histBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button sepiaBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button loadBGBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button cameraBtn;
    }
}

