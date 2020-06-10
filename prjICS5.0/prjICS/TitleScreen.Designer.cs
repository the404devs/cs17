namespace prjICS
{
    partial class TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            this.lblStart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblNoSave = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(345, 218);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(213, 64);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Game";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Visible = false;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 90);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Interactive Course Simulator: Computer Science 2017";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrompt.ForeColor = System.Drawing.Color.White;
            this.lblNamePrompt.Location = new System.Drawing.Point(32, 218);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(213, 29);
            this.lblNamePrompt.TabIndex = 4;
            this.lblNamePrompt.Text = "Enter Your Name:";
            this.lblNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNamePrompt.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(32, 270);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 29);
            this.txtName.TabIndex = 5;
            this.txtName.Visible = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(253, 351);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(79, 46);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "Help";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelp.Visible = false;
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(345, 121);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(213, 64);
            this.lblLoad.TabIndex = 7;
            this.lblLoad.Text = "Load Game";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoad.Visible = false;
            this.lblLoad.Click += new System.EventHandler(this.lblLoad_Click);
            // 
            // lblNew
            // 
            this.lblNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.White;
            this.lblNew.Location = new System.Drawing.Point(32, 121);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(213, 64);
            this.lblNew.TabIndex = 8;
            this.lblNew.Text = "New Game";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNew.Visible = false;
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(345, 282);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(213, 57);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "This will erase your current game.";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWarning.Visible = false;
            // 
            // lblNoSave
            // 
            this.lblNoSave.BackColor = System.Drawing.Color.Transparent;
            this.lblNoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSave.ForeColor = System.Drawing.Color.White;
            this.lblNoSave.Location = new System.Drawing.Point(345, 185);
            this.lblNoSave.Name = "lblNoSave";
            this.lblNoSave.Size = new System.Drawing.Size(213, 33);
            this.lblNoSave.TabIndex = 10;
            this.lblNoSave.Text = "No saved game found!";
            this.lblNoSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoSave.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjICS.Properties.Resources.clap2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prjICS.Properties.Resources.clap;
            this.pictureBox2.Location = new System.Drawing.Point(525, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::prjICS.Properties.Resources.dance;
            this.pictureBox3.Location = new System.Drawing.Point(185, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::prjICS.Properties.Resources.dance;
            this.pictureBox4.Location = new System.Drawing.Point(338, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pbMusic
            // 
            this.pbMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMusic.Image = ((System.Drawing.Image)(resources.GetObject("pbMusic.Image")));
            this.pbMusic.Location = new System.Drawing.Point(277, 317);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(31, 31);
            this.pbMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusic.TabIndex = 15;
            this.pbMusic.TabStop = false;
            this.pbMusic.Visible = false;
            this.pbMusic.Click += new System.EventHandler(this.pbMusic_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.pbMusic);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblNoSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 447);
            this.MinimumSize = new System.Drawing.Size(600, 447);
            this.Name = "TitleScreen";
            this.Text = "Computer Science 2017";
            this.Load += new System.EventHandler(this.TitleScreen_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblNoSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbMusic;
    }
}

