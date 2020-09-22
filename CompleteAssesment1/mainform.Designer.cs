namespace CompleteAssesment1
{
    partial class mainform
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
            this.GunShoot = new System.Windows.Forms.Button();
            this.BackgroundPic = new System.Windows.Forms.PictureBox();
            this.ShootAway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // GunShoot
            // 
            this.GunShoot.Location = new System.Drawing.Point(39, 38);
            this.GunShoot.Name = "GunShoot";
            this.GunShoot.Size = new System.Drawing.Size(172, 89);
            this.GunShoot.TabIndex = 1;
            this.GunShoot.Text = "Gun shot";
            this.GunShoot.UseVisualStyleBackColor = true;
            this.GunShoot.Click += new System.EventHandler(this.GunShoot_Click);
            // 
            // BackgroundPic
            // 
            this.BackgroundPic.BackgroundImage = global::CompleteAssesment1.Properties.Resources.Angerpic;
            this.BackgroundPic.InitialImage = global::CompleteAssesment1.Properties.Resources.Angerpic;
            this.BackgroundPic.Location = new System.Drawing.Point(12, 12);
            this.BackgroundPic.Name = "BackgroundPic";
            this.BackgroundPic.Size = new System.Drawing.Size(776, 426);
            this.BackgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundPic.TabIndex = 0;
            this.BackgroundPic.TabStop = false;
            // 
            // ShootAway
            // 
            this.ShootAway.Location = new System.Drawing.Point(39, 162);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(179, 77);
            this.ShootAway.TabIndex = 2;
            this.ShootAway.Text = "ShootAway";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.GunShoot);
            this.Controls.Add(this.BackgroundPic);
            this.Name = "mainform";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundPic;
        private System.Windows.Forms.Button GunShoot;
        private System.Windows.Forms.Button ShootAway;
    }
}

