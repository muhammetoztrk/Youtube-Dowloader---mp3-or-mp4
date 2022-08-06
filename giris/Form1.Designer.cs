namespace giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.mp3 = new System.Windows.Forms.RadioButton();
            this.mp4 = new System.Windows.Forms.RadioButton();
            this.indir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzantı:";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(132, 60);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(517, 22);
            this.link.TabIndex = 2;
            // 
            // mp3
            // 
            this.mp3.AutoSize = true;
            this.mp3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mp3.Location = new System.Drawing.Point(176, 160);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(64, 25);
            this.mp3.TabIndex = 3;
            this.mp3.TabStop = true;
            this.mp3.Text = "Mp3";
            this.mp3.UseVisualStyleBackColor = true;
            this.mp3.CheckedChanged += new System.EventHandler(this.mp3_CheckedChanged);
            // 
            // mp4
            // 
            this.mp4.AutoSize = true;
            this.mp4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mp4.Location = new System.Drawing.Point(276, 160);
            this.mp4.Name = "mp4";
            this.mp4.Size = new System.Drawing.Size(64, 25);
            this.mp4.TabIndex = 4;
            this.mp4.TabStop = true;
            this.mp4.Text = "Mp4";
            this.mp4.UseVisualStyleBackColor = true;
            this.mp4.CheckedChanged += new System.EventHandler(this.mp4_CheckedChanged);
            // 
            // indir
            // 
            this.indir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indir.Location = new System.Drawing.Point(276, 261);
            this.indir.Name = "indir";
            this.indir.Size = new System.Drawing.Size(156, 53);
            this.indir.TabIndex = 5;
            this.indir.Text = "İndir";
            this.indir.UseVisualStyleBackColor = true;
            this.indir.Click += new System.EventHandler(this.indir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(588, 53);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.indir);
            this.Controls.Add(this.mp4);
            this.Controls.Add(this.mp3);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.RadioButton mp3;
        private System.Windows.Forms.RadioButton mp4;
        private System.Windows.Forms.Button indir;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

