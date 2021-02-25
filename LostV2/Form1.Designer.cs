namespace LostV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Cushing Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel.Location = new System.Drawing.Point(24, 28);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(339, 257);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "label1";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.outputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.redLabel.Location = new System.Drawing.Point(67, 313);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(257, 23);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "label1";
            this.redLabel.Click += new System.EventHandler(this.RedLabel_Click);
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.blueLabel.Location = new System.Drawing.Point(67, 390);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(257, 23);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "label1";
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Location = new System.Drawing.Point(70, 107);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(221, 178);
            this.picBox1.TabIndex = 5;
            this.picBox1.TabStop = false;
            // 
            // blueImage
            // 
            this.blueImage.Image = global::LostV2.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(24, 380);
            this.blueImage.Margin = new System.Windows.Forms.Padding(2);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(39, 32);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 1;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = global::LostV2.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(24, 303);
            this.redImage.Margin = new System.Windows.Forms.Padding(2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(39, 32);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 0;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 422);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost in a Forest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.PictureBox picBox1;
    }
}

