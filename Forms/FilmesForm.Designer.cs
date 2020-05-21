namespace CinemaPIM.Forms
{
    partial class FilmesForm
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
            this.filme1 = new System.Windows.Forms.PictureBox();
            this.filme2 = new System.Windows.Forms.PictureBox();
            this.filme3 = new System.Windows.Forms.PictureBox();
            this.filme4 = new System.Windows.Forms.PictureBox();
            this.filme5 = new System.Windows.Forms.PictureBox();
            this.filme6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.filme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filmes";
            // 
            // filme1
            // 
            this.filme1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filme1.Location = new System.Drawing.Point(99, 100);
            this.filme1.Name = "filme1";
            this.filme1.Size = new System.Drawing.Size(134, 161);
            this.filme1.TabIndex = 1;
            this.filme1.TabStop = false;
            this.filme1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filme1_MouseClick);
            // 
            // filme2
            // 
            this.filme2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filme2.Location = new System.Drawing.Point(321, 100);
            this.filme2.Name = "filme2";
            this.filme2.Size = new System.Drawing.Size(134, 161);
            this.filme2.TabIndex = 2;
            this.filme2.TabStop = false;
            this.filme2.Click += new System.EventHandler(this.filme2_Click);
            this.filme2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filme2_MouseClick);
            // 
            // filme3
            // 
            this.filme3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filme3.Location = new System.Drawing.Point(539, 100);
            this.filme3.Name = "filme3";
            this.filme3.Size = new System.Drawing.Size(134, 161);
            this.filme3.TabIndex = 3;
            this.filme3.TabStop = false;
            this.filme3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filme3_MouseClick);
            // 
            // filme4
            // 
            this.filme4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filme4.Location = new System.Drawing.Point(99, 329);
            this.filme4.Name = "filme4";
            this.filme4.Size = new System.Drawing.Size(134, 161);
            this.filme4.TabIndex = 4;
            this.filme4.TabStop = false;
            this.filme4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filme4_MouseClick);
            // 
            // filme5
            // 
            this.filme5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filme5.Location = new System.Drawing.Point(321, 329);
            this.filme5.Name = "filme5";
            this.filme5.Size = new System.Drawing.Size(134, 161);
            this.filme5.TabIndex = 5;
            this.filme5.TabStop = false;
            this.filme5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filme5_MouseClick);
            // 
            // filme6
            // 
            this.filme6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filme6.Location = new System.Drawing.Point(539, 329);
            this.filme6.Name = "filme6";
            this.filme6.Size = new System.Drawing.Size(134, 161);
            this.filme6.TabIndex = 6;
            this.filme6.TabStop = false;
            this.filme6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filme6_MouseClick);
            // 
            // FilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.filme6);
            this.Controls.Add(this.filme5);
            this.Controls.Add(this.filme4);
            this.Controls.Add(this.filme3);
            this.Controls.Add(this.filme2);
            this.Controls.Add(this.filme1);
            this.Controls.Add(this.label1);
            this.Name = "FilmesForm";
            this.Text = "Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.filme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox filme1;
        private System.Windows.Forms.PictureBox filme2;
        private System.Windows.Forms.PictureBox filme3;
        private System.Windows.Forms.PictureBox filme4;
        private System.Windows.Forms.PictureBox filme5;
        private System.Windows.Forms.PictureBox filme6;
    }
}