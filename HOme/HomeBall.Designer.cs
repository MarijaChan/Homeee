namespace HOme
{
    partial class HomeBall
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.LabS = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Salmon;
            this.Ball.Location = new System.Drawing.Point(515, 416);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(167, 165);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // LabS
            // 
            this.LabS.AutoSize = true;
            this.LabS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabS.Location = new System.Drawing.Point(12, 9);
            this.LabS.Name = "LabS";
            this.LabS.Size = new System.Drawing.Size(113, 40);
            this.LabS.TabIndex = 1;
            this.LabS.Text = "label1";
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.racket.Location = new System.Drawing.Point(436, 664);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(327, 50);
            this.racket.TabIndex = 2;
            this.racket.TabStop = false;
            this.racket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.racket_MouseDown);
            this.racket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.racket_MouseMove);
            // 
            // HomeBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 920);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.LabS);
            this.Controls.Add(this.Ball);
            this.Name = "HomeBall";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label LabS;
        private System.Windows.Forms.PictureBox racket;
    }
}

