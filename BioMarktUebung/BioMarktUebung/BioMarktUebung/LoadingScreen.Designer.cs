namespace BioMarktUebung
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.loadingProzent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(153, 494);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadingLabel.Location = new System.Drawing.Point(428, 458);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(52, 15);
            this.LoadingLabel.TabIndex = 1;
            this.LoadingLabel.Text = "Loading";
            // 
            // loadingProzent
            // 
            this.loadingProzent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadingProzent.AutoSize = true;
            this.loadingProzent.ForeColor = System.Drawing.SystemColors.Control;
            this.loadingProzent.Location = new System.Drawing.Point(487, 458);
            this.loadingProzent.Name = "loadingProzent";
            this.loadingProzent.Size = new System.Drawing.Size(25, 15);
            this.loadingProzent.TabIndex = 2;
            this.loadingProzent.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 444);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(889, 547);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingProzent);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Natur Biomarkt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Label loadingProzent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

