namespace prjICS
{
    partial class Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            this.lblName = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            this.lblErrorTotal = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAttack4 = new System.Windows.Forms.Label();
            this.lblAttack3 = new System.Windows.Forms.Label();
            this.lblAttack2 = new System.Windows.Forms.Label();
            this.lblAttack1 = new System.Windows.Forms.Label();
            this.lblDialogue = new System.Windows.Forms.Label();
            this.pnlCharacter = new System.Windows.Forms.Panel();
            this.pgbSanity = new System.Windows.Forms.ProgressBar();
            this.lblSanity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgbCompletion = new System.Windows.Forms.ProgressBar();
            this.lblCompletion = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlCharacter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 23);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Gray;
            this.pnlDisplay.Controls.Add(this.pbMusic);
            this.pnlDisplay.Controls.Add(this.lblErrorTotal);
            this.pnlDisplay.Controls.Add(this.pictureBox3);
            this.pnlDisplay.Controls.Add(this.lblAttack4);
            this.pnlDisplay.Controls.Add(this.lblAttack3);
            this.pnlDisplay.Controls.Add(this.lblAttack2);
            this.pnlDisplay.Controls.Add(this.lblAttack1);
            this.pnlDisplay.Controls.Add(this.lblDialogue);
            this.pnlDisplay.Location = new System.Drawing.Point(0, 508);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(437, 252);
            this.pnlDisplay.TabIndex = 6;
            // 
            // pbMusic
            // 
            this.pbMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMusic.Image = ((System.Drawing.Image)(resources.GetObject("pbMusic.Image")));
            this.pbMusic.Location = new System.Drawing.Point(391, 11);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(31, 31);
            this.pbMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusic.TabIndex = 110;
            this.pbMusic.TabStop = false;
            this.pbMusic.Click += new System.EventHandler(this.pbMusic_Click);
            // 
            // lblErrorTotal
            // 
            this.lblErrorTotal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblErrorTotal.Location = new System.Drawing.Point(45, 11);
            this.lblErrorTotal.Name = "lblErrorTotal";
            this.lblErrorTotal.Size = new System.Drawing.Size(73, 32);
            this.lblErrorTotal.TabIndex = 14;
            this.lblErrorTotal.Text = "x 0";
            this.lblErrorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::prjICS.Properties.Resources.msg_error;
            this.pictureBox3.Location = new System.Drawing.Point(12, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // lblAttack4
            // 
            this.lblAttack4.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAttack4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttack4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack4.ForeColor = System.Drawing.Color.White;
            this.lblAttack4.Location = new System.Drawing.Point(217, 204);
            this.lblAttack4.Name = "lblAttack4";
            this.lblAttack4.Size = new System.Drawing.Size(200, 36);
            this.lblAttack4.TabIndex = 16;
            this.lblAttack4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAttack4.Click += new System.EventHandler(this.lblAttack4_Click);
            // 
            // lblAttack3
            // 
            this.lblAttack3.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAttack3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttack3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack3.ForeColor = System.Drawing.Color.White;
            this.lblAttack3.Location = new System.Drawing.Point(217, 157);
            this.lblAttack3.Name = "lblAttack3";
            this.lblAttack3.Size = new System.Drawing.Size(200, 36);
            this.lblAttack3.TabIndex = 15;
            this.lblAttack3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAttack3.Click += new System.EventHandler(this.lblAttack3_Click);
            // 
            // lblAttack2
            // 
            this.lblAttack2.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAttack2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttack2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack2.ForeColor = System.Drawing.Color.White;
            this.lblAttack2.Location = new System.Drawing.Point(12, 204);
            this.lblAttack2.Name = "lblAttack2";
            this.lblAttack2.Size = new System.Drawing.Size(200, 36);
            this.lblAttack2.TabIndex = 14;
            this.lblAttack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAttack2.Click += new System.EventHandler(this.lblAttack2_Click);
            // 
            // lblAttack1
            // 
            this.lblAttack1.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAttack1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttack1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack1.ForeColor = System.Drawing.Color.White;
            this.lblAttack1.Location = new System.Drawing.Point(12, 157);
            this.lblAttack1.Name = "lblAttack1";
            this.lblAttack1.Size = new System.Drawing.Size(200, 36);
            this.lblAttack1.TabIndex = 13;
            this.lblAttack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAttack1.Click += new System.EventHandler(this.lblAttack1_Click);
            // 
            // lblDialogue
            // 
            this.lblDialogue.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDialogue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDialogue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogue.ForeColor = System.Drawing.Color.White;
            this.lblDialogue.Location = new System.Drawing.Point(12, 52);
            this.lblDialogue.Name = "lblDialogue";
            this.lblDialogue.Size = new System.Drawing.Size(410, 90);
            this.lblDialogue.TabIndex = 12;
            // 
            // pnlCharacter
            // 
            this.pnlCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCharacter.Controls.Add(this.pgbSanity);
            this.pnlCharacter.Controls.Add(this.lblSanity);
            this.pnlCharacter.Controls.Add(this.lblName);
            this.pnlCharacter.Location = new System.Drawing.Point(20, 249);
            this.pnlCharacter.Name = "pnlCharacter";
            this.pnlCharacter.Size = new System.Drawing.Size(158, 79);
            this.pnlCharacter.TabIndex = 7;
            // 
            // pgbSanity
            // 
            this.pgbSanity.Location = new System.Drawing.Point(3, 53);
            this.pgbSanity.Name = "pgbSanity";
            this.pgbSanity.Size = new System.Drawing.Size(150, 21);
            this.pgbSanity.TabIndex = 13;
            this.pgbSanity.Value = 100;
            // 
            // lblSanity
            // 
            this.lblSanity.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanity.Location = new System.Drawing.Point(6, 27);
            this.lblSanity.Name = "lblSanity";
            this.lblSanity.Size = new System.Drawing.Size(147, 23);
            this.lblSanity.TabIndex = 3;
            this.lblSanity.Text = "Sanity: 100%";
            this.lblSanity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pgbCompletion);
            this.panel1.Controls.Add(this.lblCompletion);
            this.panel1.Controls.Add(this.lblEnemy);
            this.panel1.Location = new System.Drawing.Point(264, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 79);
            this.panel1.TabIndex = 8;
            // 
            // pgbCompletion
            // 
            this.pgbCompletion.Location = new System.Drawing.Point(3, 53);
            this.pgbCompletion.Name = "pgbCompletion";
            this.pgbCompletion.Size = new System.Drawing.Size(150, 21);
            this.pgbCompletion.TabIndex = 14;
            // 
            // lblCompletion
            // 
            this.lblCompletion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletion.Location = new System.Drawing.Point(3, 27);
            this.lblCompletion.Name = "lblCompletion";
            this.lblCompletion.Size = new System.Drawing.Size(150, 23);
            this.lblCompletion.TabIndex = 5;
            this.lblCompletion.Text = "Completion: 0%";
            this.lblCompletion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnemy
            // 
            this.lblEnemy.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemy.Location = new System.Drawing.Point(3, 0);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(150, 23);
            this.lblEnemy.TabIndex = 4;
            this.lblEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.Location = new System.Drawing.Point(338, 359);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(55, 64);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 5;
            this.pbAvatar.TabStop = false;
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy.Location = new System.Drawing.Point(0, 123);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(114, 64);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemy.TabIndex = 4;
            this.pbEnemy.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prjICS.Properties.Resources.Oval;
            this.pictureBox2.Location = new System.Drawing.Point(29, 426);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjICS.Properties.Resources.Oval;
            this.pictureBox1.Location = new System.Drawing.Point(239, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbError
            // 
            this.pbError.Image = global::prjICS.Properties.Resources.msg_error;
            this.pbError.Location = new System.Drawing.Point(245, 215);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(32, 32);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbError.TabIndex = 9;
            this.pbError.TabStop = false;
            this.pbError.Visible = false;
            // 
            // pbCheck
            // 
            this.pbCheck.Image = global::prjICS.Properties.Resources.check;
            this.pbCheck.Location = new System.Drawing.Point(101, 391);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(32, 32);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCheck.TabIndex = 10;
            this.pbCheck.TabStop = false;
            this.pbCheck.Visible = false;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 759);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCharacter);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 797);
            this.MinimumSize = new System.Drawing.Size(450, 797);
            this.Name = "Battle";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Battle_Load);
            this.Shown += new System.EventHandler(this.Battle_Shown);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlCharacter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblDialogue;
        private System.Windows.Forms.Panel pnlCharacter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSanity;
        private System.Windows.Forms.Label lblCompletion;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Label lblAttack4;
        private System.Windows.Forms.Label lblAttack3;
        private System.Windows.Forms.Label lblAttack2;
        private System.Windows.Forms.Label lblAttack1;
        private System.Windows.Forms.ProgressBar pgbSanity;
        private System.Windows.Forms.ProgressBar pgbCompletion;
        private System.Windows.Forms.Label lblErrorTotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbMusic;
    }
}