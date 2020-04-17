namespace saleh.program322
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
            this.LogintoIE322 = new System.Windows.Forms.GroupBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbBasicControls = new System.Windows.Forms.GroupBox();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnSelfie = new System.Windows.Forms.Button();
            this.btnPictureBox2 = new System.Windows.Forms.Button();
            this.btnGroupieApp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRandom2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.LogintoIE322.SuspendLayout();
            this.lbBasicControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogintoIE322
            // 
            this.LogintoIE322.Controls.Add(this.btnLogin);
            this.LogintoIE322.Controls.Add(this.lbPassword);
            this.LogintoIE322.Controls.Add(this.txtPassword);
            this.LogintoIE322.Controls.Add(this.txtUser);
            this.LogintoIE322.Controls.Add(this.lbUsername);
            this.LogintoIE322.Location = new System.Drawing.Point(12, 12);
            this.LogintoIE322.Name = "LogintoIE322";
            this.LogintoIE322.Size = new System.Drawing.Size(200, 161);
            this.LogintoIE322.TabIndex = 0;
            this.LogintoIE322.TabStop = false;
            this.LogintoIE322.Text = "Login to IE322";
            this.LogintoIE322.Enter += new System.EventHandler(this.LogintoIE322_Enter);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(18, 40);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(79, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(18, 67);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(104, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbBasicControls
            // 
            this.lbBasicControls.Controls.Add(this.BtnArray);
            this.lbBasicControls.Controls.Add(this.btnCombo);
            this.lbBasicControls.Controls.Add(this.btnCheckBox);
            this.lbBasicControls.Controls.Add(this.btnRadio);
            this.lbBasicControls.Location = new System.Drawing.Point(232, 13);
            this.lbBasicControls.Name = "lbBasicControls";
            this.lbBasicControls.Size = new System.Drawing.Size(202, 106);
            this.lbBasicControls.TabIndex = 1;
            this.lbBasicControls.TabStop = false;
            this.lbBasicControls.Text = "Basic Controls";
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(16, 29);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(75, 23);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(110, 29);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBox.TabIndex = 5;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(16, 66);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGroupieApp);
            this.groupBox1.Controls.Add(this.btnPictureBox2);
            this.groupBox1.Controls.Add(this.btnSelfie);
            this.groupBox1.Controls.Add(this.btnPic);
            this.groupBox1.Location = new System.Drawing.Point(232, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grachical";
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(16, 28);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 0;
            this.btnPic.Text = "PictureBox";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnSelfie
            // 
            this.btnSelfie.Location = new System.Drawing.Point(110, 28);
            this.btnSelfie.Name = "btnSelfie";
            this.btnSelfie.Size = new System.Drawing.Size(75, 23);
            this.btnSelfie.TabIndex = 1;
            this.btnSelfie.Text = "SelfieApp";
            this.btnSelfie.UseVisualStyleBackColor = true;
            // 
            // btnPictureBox2
            // 
            this.btnPictureBox2.Location = new System.Drawing.Point(16, 67);
            this.btnPictureBox2.Name = "btnPictureBox2";
            this.btnPictureBox2.Size = new System.Drawing.Size(75, 23);
            this.btnPictureBox2.TabIndex = 2;
            this.btnPictureBox2.Text = "PictureBox2";
            this.btnPictureBox2.UseVisualStyleBackColor = true;
            // 
            // btnGroupieApp
            // 
            this.btnGroupieApp.Location = new System.Drawing.Point(110, 67);
            this.btnGroupieApp.Name = "btnGroupieApp";
            this.btnGroupieApp.Size = new System.Drawing.Size(75, 23);
            this.btnGroupieApp.TabIndex = 3;
            this.btnGroupieApp.Text = "Groupie App";
            this.btnGroupieApp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRandom2);
            this.groupBox2.Controls.Add(this.btnRandom);
            this.groupBox2.Controls.Add(this.btnTimer);
            this.groupBox2.Controls.Add(this.btnProgress);
            this.groupBox2.Location = new System.Drawing.Point(232, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More Controls";
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(16, 30);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(75, 23);
            this.btnProgress.TabIndex = 0;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(110, 30);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 1;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(16, 68);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRandom2
            // 
            this.btnRandom2.Location = new System.Drawing.Point(110, 68);
            this.btnRandom2.Name = "btnRandom2";
            this.btnRandom2.Size = new System.Drawing.Size(75, 23);
            this.btnRandom2.TabIndex = 3;
            this.btnRandom2.Text = "RandomCombo";
            this.btnRandom2.UseVisualStyleBackColor = true;
            this.btnRandom2.Click += new System.EventHandler(this.btnRandom2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTalk);
            this.groupBox3.Controls.Add(this.btnDraw);
            this.groupBox3.Location = new System.Drawing.Point(232, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Draw and Talk";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(16, 29);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(110, 28);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(75, 23);
            this.btnTalk.TabIndex = 1;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(546, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 106);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(110, 66);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(75, 23);
            this.BtnArray.TabIndex = 7;
            this.BtnArray.Text = "Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbBasicControls);
            this.Controls.Add(this.LogintoIE322);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LogintoIE322.ResumeLayout(false);
            this.LogintoIE322.PerformLayout();
            this.lbBasicControls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogintoIE322;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.GroupBox lbBasicControls;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGroupieApp;
        private System.Windows.Forms.Button btnPictureBox2;
        private System.Windows.Forms.Button btnSelfie;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandom2;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

