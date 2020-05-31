namespace prjICS
{
    partial class HelpMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.lblHelpText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.tbcHelp = new System.Windows.Forms.TabControl();
            this.tbpOverview = new System.Windows.Forms.TabPage();
            this.tbpClassroom = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpSebnic = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpLessons = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpTests = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpAssignments = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpAbout = new System.Windows.Forms.TabPage();
            this.lnlLink = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpGrads = new System.Windows.Forms.TabPage();
            this.lblMark6 = new System.Windows.Forms.Label();
            this.lblMark5 = new System.Windows.Forms.Label();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.lblName6 = new System.Windows.Forms.Label();
            this.lblName5 = new System.Windows.Forms.Label();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblMark3 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblMark1 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbcHelp.SuspendLayout();
            this.tbpOverview.SuspendLayout();
            this.tbpClassroom.SuspendLayout();
            this.tbpSebnic.SuspendLayout();
            this.tbpLessons.SuspendLayout();
            this.tbpTests.SuspendLayout();
            this.tbpAssignments.SuspendLayout();
            this.tbpAbout.SuspendLayout();
            this.tbpGrads.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(524, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copyright © 2017 Some random company. All rights reserved.";
            // 
            // lblHelpText
            // 
            this.lblHelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpText.ForeColor = System.Drawing.Color.White;
            this.lblHelpText.Location = new System.Drawing.Point(10, 3);
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.Size = new System.Drawing.Size(598, 176);
            this.lblHelpText.TabIndex = 9;
            this.lblHelpText.Text = resources.GetString("lblHelpText.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(56, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 90);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Interactive Course Simulator: Computer Science 2017";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(281, 322);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(81, 35);
            this.lblBack.TabIndex = 11;
            this.lblBack.Text = "Exit";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // tbcHelp
            // 
            this.tbcHelp.Controls.Add(this.tbpOverview);
            this.tbcHelp.Controls.Add(this.tbpClassroom);
            this.tbcHelp.Controls.Add(this.tbpSebnic);
            this.tbcHelp.Controls.Add(this.tbpLessons);
            this.tbcHelp.Controls.Add(this.tbpTests);
            this.tbcHelp.Controls.Add(this.tbpAssignments);
            this.tbcHelp.Controls.Add(this.tbpAbout);
            this.tbcHelp.Controls.Add(this.tbpGrads);
            this.tbcHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcHelp.Location = new System.Drawing.Point(12, 102);
            this.tbcHelp.Name = "tbcHelp";
            this.tbcHelp.SelectedIndex = 0;
            this.tbcHelp.Size = new System.Drawing.Size(619, 217);
            this.tbcHelp.TabIndex = 12;
            // 
            // tbpOverview
            // 
            this.tbpOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpOverview.Controls.Add(this.lblHelpText);
            this.tbpOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpOverview.Location = new System.Drawing.Point(4, 27);
            this.tbpOverview.Name = "tbpOverview";
            this.tbpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOverview.Size = new System.Drawing.Size(611, 186);
            this.tbpOverview.TabIndex = 0;
            this.tbpOverview.Text = "Overview";
            // 
            // tbpClassroom
            // 
            this.tbpClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpClassroom.Controls.Add(this.label2);
            this.tbpClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpClassroom.Location = new System.Drawing.Point(4, 27);
            this.tbpClassroom.Name = "tbpClassroom";
            this.tbpClassroom.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClassroom.Size = new System.Drawing.Size(611, 186);
            this.tbpClassroom.TabIndex = 1;
            this.tbpClassroom.Text = "The Classroom";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 185);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tbpSebnic
            // 
            this.tbpSebnic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpSebnic.Controls.Add(this.label3);
            this.tbpSebnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpSebnic.Location = new System.Drawing.Point(4, 27);
            this.tbpSebnic.Name = "tbpSebnic";
            this.tbpSebnic.Size = new System.Drawing.Size(611, 186);
            this.tbpSebnic.TabIndex = 2;
            this.tbpSebnic.Text = "SEBNIC";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 185);
            this.label3.TabIndex = 11;
            this.label3.Text = "There are two main sections on the SEBNIC menu:\r\n\r\nFiles: From here you can learn" +
    " a new lesson.\r\nQuizzer: From here you can take a quiz or test, as well as work " +
    "on any current assignments.\r\n\r\n\r\n";
            // 
            // tbpLessons
            // 
            this.tbpLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpLessons.Controls.Add(this.label4);
            this.tbpLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpLessons.Location = new System.Drawing.Point(4, 27);
            this.tbpLessons.Name = "tbpLessons";
            this.tbpLessons.Size = new System.Drawing.Size(611, 186);
            this.tbpLessons.TabIndex = 3;
            this.tbpLessons.Text = "Lessons";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(594, 185);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lessons are an essential part of learning new skills.\r\nEach lesson consists of 5 " +
    "simple questions.\r\n\r\nYou must complete all of the lessons to complete the unit t" +
    "est.";
            // 
            // tbpTests
            // 
            this.tbpTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpTests.Controls.Add(this.label5);
            this.tbpTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpTests.Location = new System.Drawing.Point(4, 27);
            this.tbpTests.Name = "tbpTests";
            this.tbpTests.Size = new System.Drawing.Size(611, 186);
            this.tbpTests.TabIndex = 4;
            this.tbpTests.Text = "Tests";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(605, 185);
            this.label5.TabIndex = 13;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // tbpAssignments
            // 
            this.tbpAssignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpAssignments.Controls.Add(this.label6);
            this.tbpAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpAssignments.Location = new System.Drawing.Point(4, 27);
            this.tbpAssignments.Name = "tbpAssignments";
            this.tbpAssignments.Size = new System.Drawing.Size(611, 186);
            this.tbpAssignments.TabIndex = 5;
            this.tbpAssignments.Text = "Assignments";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(589, 185);
            this.label6.TabIndex = 14;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // tbpAbout
            // 
            this.tbpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpAbout.Controls.Add(this.lnlLink);
            this.tbpAbout.Controls.Add(this.label7);
            this.tbpAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpAbout.Location = new System.Drawing.Point(4, 27);
            this.tbpAbout.Name = "tbpAbout";
            this.tbpAbout.Size = new System.Drawing.Size(611, 186);
            this.tbpAbout.TabIndex = 6;
            this.tbpAbout.Text = "About";
            // 
            // lnlLink
            // 
            this.lnlLink.AutoSize = true;
            this.lnlLink.LinkColor = System.Drawing.Color.Silver;
            this.lnlLink.Location = new System.Drawing.Point(7, 142);
            this.lnlLink.Name = "lnlLink";
            this.lnlLink.Size = new System.Drawing.Size(67, 20);
            this.lnlLink.TabIndex = 15;
            this.lnlLink.TabStop = true;
            this.lnlLink.Text = "Website";
            this.lnlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlLink_LinkClicked);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(539, 185);
            this.label7.TabIndex = 14;
            this.label7.Text = "Interactive Course Simulator: Computer Science 2017\r\n\r\nJune 15th, 2017\r\n\r\nBy Owen" +
    " Goodwin, Kevin Cacorovski and Jatin Hajatri";
            // 
            // tbpGrads
            // 
            this.tbpGrads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpGrads.Controls.Add(this.lblMark6);
            this.tbpGrads.Controls.Add(this.lblMark5);
            this.tbpGrads.Controls.Add(this.lblMark4);
            this.tbpGrads.Controls.Add(this.lblName6);
            this.tbpGrads.Controls.Add(this.lblName5);
            this.tbpGrads.Controls.Add(this.lblName4);
            this.tbpGrads.Controls.Add(this.lblMark3);
            this.tbpGrads.Controls.Add(this.lblMark2);
            this.tbpGrads.Controls.Add(this.lblMark1);
            this.tbpGrads.Controls.Add(this.lblName3);
            this.tbpGrads.Controls.Add(this.lblName2);
            this.tbpGrads.Controls.Add(this.lblName1);
            this.tbpGrads.Location = new System.Drawing.Point(4, 27);
            this.tbpGrads.Name = "tbpGrads";
            this.tbpGrads.Size = new System.Drawing.Size(611, 186);
            this.tbpGrads.TabIndex = 7;
            this.tbpGrads.Text = "Graduates";
            // 
            // lblMark6
            // 
            this.lblMark6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark6.ForeColor = System.Drawing.Color.White;
            this.lblMark6.Location = new System.Drawing.Point(470, 139);
            this.lblMark6.Name = "lblMark6";
            this.lblMark6.Size = new System.Drawing.Size(129, 37);
            this.lblMark6.TabIndex = 26;
            this.lblMark6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMark5
            // 
            this.lblMark5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark5.ForeColor = System.Drawing.Color.White;
            this.lblMark5.Location = new System.Drawing.Point(470, 73);
            this.lblMark5.Name = "lblMark5";
            this.lblMark5.Size = new System.Drawing.Size(129, 37);
            this.lblMark5.TabIndex = 25;
            this.lblMark5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMark4
            // 
            this.lblMark4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark4.ForeColor = System.Drawing.Color.White;
            this.lblMark4.Location = new System.Drawing.Point(470, 13);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(129, 37);
            this.lblMark4.TabIndex = 24;
            this.lblMark4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName6
            // 
            this.lblName6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName6.ForeColor = System.Drawing.Color.White;
            this.lblName6.Location = new System.Drawing.Point(318, 139);
            this.lblName6.Name = "lblName6";
            this.lblName6.Size = new System.Drawing.Size(129, 37);
            this.lblName6.TabIndex = 23;
            this.lblName6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName5
            // 
            this.lblName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName5.ForeColor = System.Drawing.Color.White;
            this.lblName5.Location = new System.Drawing.Point(318, 73);
            this.lblName5.Name = "lblName5";
            this.lblName5.Size = new System.Drawing.Size(129, 37);
            this.lblName5.TabIndex = 22;
            this.lblName5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName4
            // 
            this.lblName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName4.ForeColor = System.Drawing.Color.White;
            this.lblName4.Location = new System.Drawing.Point(318, 13);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(129, 37);
            this.lblName4.TabIndex = 21;
            this.lblName4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMark3
            // 
            this.lblMark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark3.ForeColor = System.Drawing.Color.White;
            this.lblMark3.Location = new System.Drawing.Point(165, 139);
            this.lblMark3.Name = "lblMark3";
            this.lblMark3.Size = new System.Drawing.Size(129, 37);
            this.lblMark3.TabIndex = 20;
            this.lblMark3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMark2
            // 
            this.lblMark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark2.ForeColor = System.Drawing.Color.White;
            this.lblMark2.Location = new System.Drawing.Point(165, 73);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(129, 37);
            this.lblMark2.TabIndex = 19;
            this.lblMark2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMark1
            // 
            this.lblMark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark1.ForeColor = System.Drawing.Color.White;
            this.lblMark1.Location = new System.Drawing.Point(165, 13);
            this.lblMark1.Name = "lblMark1";
            this.lblMark1.Size = new System.Drawing.Size(129, 37);
            this.lblMark1.TabIndex = 18;
            this.lblMark1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName3
            // 
            this.lblName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName3.ForeColor = System.Drawing.Color.White;
            this.lblName3.Location = new System.Drawing.Point(17, 139);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(129, 37);
            this.lblName3.TabIndex = 17;
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName2
            // 
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.Color.White;
            this.lblName2.Location = new System.Drawing.Point(17, 73);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(129, 37);
            this.lblName2.TabIndex = 16;
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName1
            // 
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.White;
            this.lblName1.Location = new System.Drawing.Point(17, 13);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(129, 37);
            this.lblName1.TabIndex = 15;
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(642, 362);
            this.ControlBox = false;
            this.Controls.Add(this.tbcHelp);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(658, 400);
            this.MinimumSize = new System.Drawing.Size(658, 400);
            this.Name = "HelpMenu";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpMenu_Load);
            this.tbcHelp.ResumeLayout(false);
            this.tbpOverview.ResumeLayout(false);
            this.tbpClassroom.ResumeLayout(false);
            this.tbpSebnic.ResumeLayout(false);
            this.tbpLessons.ResumeLayout(false);
            this.tbpTests.ResumeLayout(false);
            this.tbpAssignments.ResumeLayout(false);
            this.tbpAbout.ResumeLayout(false);
            this.tbpAbout.PerformLayout();
            this.tbpGrads.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHelpText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TabControl tbcHelp;
        private System.Windows.Forms.TabPage tbpOverview;
        private System.Windows.Forms.TabPage tbpClassroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpSebnic;
        private System.Windows.Forms.TabPage tbpLessons;
        private System.Windows.Forms.TabPage tbpTests;
        private System.Windows.Forms.TabPage tbpAssignments;
        private System.Windows.Forms.TabPage tbpAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tbpGrads;
        private System.Windows.Forms.Label lblMark3;
        private System.Windows.Forms.Label lblMark2;
        private System.Windows.Forms.Label lblMark1;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblMark6;
        private System.Windows.Forms.Label lblMark5;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.Label lblName6;
        private System.Windows.Forms.Label lblName5;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.LinkLabel lnlLink;
    }
}