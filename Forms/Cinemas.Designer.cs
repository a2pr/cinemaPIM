namespace CinemaPIM.Forms
{
    partial class Cinemas
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
            this.cinema1 = new System.Windows.Forms.PictureBox();
            this.cinema2 = new System.Windows.Forms.PictureBox();
            this.cinema3 = new System.Windows.Forms.PictureBox();
            this.cinema4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cinema1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema4)).BeginInit();
            this.SuspendLayout();
            // 
            // cinema1
            // 
            this.cinema1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cinema1.Location = new System.Drawing.Point(108, 66);
            this.cinema1.Name = "cinema1";
            this.cinema1.Size = new System.Drawing.Size(200, 150);
            this.cinema1.TabIndex = 0;
            this.cinema1.TabStop = false;
            this.cinema1.Click += new System.EventHandler(this.cinema1_Click);
            // 
            // cinema2
            // 
            this.cinema2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cinema2.Location = new System.Drawing.Point(459, 66);
            this.cinema2.Name = "cinema2";
            this.cinema2.Size = new System.Drawing.Size(200, 150);
            this.cinema2.TabIndex = 1;
            this.cinema2.TabStop = false;
            // 
            // cinema3
            // 
            this.cinema3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cinema3.Location = new System.Drawing.Point(108, 270);
            this.cinema3.Name = "cinema3";
            this.cinema3.Size = new System.Drawing.Size(200, 150);
            this.cinema3.TabIndex = 2;
            this.cinema3.TabStop = false;
            // 
            // cinema4
            // 
            this.cinema4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cinema4.Location = new System.Drawing.Point(459, 270);
            this.cinema4.Name = "cinema4";
            this.cinema4.Size = new System.Drawing.Size(200, 150);
            this.cinema4.TabIndex = 3;
            this.cinema4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cinemas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cinemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cinema4);
            this.Controls.Add(this.cinema3);
            this.Controls.Add(this.cinema2);
            this.Controls.Add(this.cinema1);
            this.Name = "Cinemas";
            this.Text = "Cinemas";
            this.Load += new System.EventHandler(this.Cinemas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinema1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cinema1;
        private System.Windows.Forms.PictureBox cinema2;
        private System.Windows.Forms.PictureBox cinema3;
        private System.Windows.Forms.PictureBox cinema4;
        private System.Windows.Forms.Label label1;
    }
}