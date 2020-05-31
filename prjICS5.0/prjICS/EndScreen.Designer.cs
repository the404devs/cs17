namespace prjICS
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.lblError = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblGlitch1 = new System.Windows.Forms.Label();
            this.lblGlitch2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(18, 30);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(63, 23);
            this.lblError.TabIndex = 0;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(18, 83);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(248, 150);
            this.lblMessage.TabIndex = 1;
            // 
            // lblGlitch1
            // 
            this.lblGlitch1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlitch1.ForeColor = System.Drawing.Color.Silver;
            this.lblGlitch1.Location = new System.Drawing.Point(37, -23);
            this.lblGlitch1.Name = "lblGlitch1";
            this.lblGlitch1.Size = new System.Drawing.Size(284, 195);
            this.lblGlitch1.TabIndex = 2;
            this.lblGlitch1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGlitch2
            // 
            this.lblGlitch2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlitch2.ForeColor = System.Drawing.Color.Silver;
            this.lblGlitch2.Location = new System.Drawing.Point(18, 96);
            this.lblGlitch2.Name = "lblGlitch2";
            this.lblGlitch2.Size = new System.Drawing.Size(254, 197);
            this.lblGlitch2.TabIndex = 3;
            this.lblGlitch2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblGlitch2);
            this.Controls.Add(this.lblGlitch1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "EndScreen";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.EndScreen_Load);
            this.Shown += new System.EventHandler(this.EndScreen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblGlitch1;
        private System.Windows.Forms.Label lblGlitch2;
    }
}