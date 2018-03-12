namespace DocumentCreator
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.bunifuDragControlAplication = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(213, 179);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(257, 32);
            this.textBoxPassword.TabIndex = 0;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(213, 241);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(257, 41);
            this.buttonLogIn.TabIndex = 1;
            this.buttonLogIn.Text = "Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(125, 137);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(68, 23);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(125, 182);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Hasło:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(213, 134);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(257, 32);
            this.textBoxLogin.TabIndex = 4;
            // 
            // labelLoginText
            // 
            this.labelLoginText.AutoSize = true;
            this.labelLoginText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginText.ForeColor = System.Drawing.Color.White;
            this.labelLoginText.Location = new System.Drawing.Point(208, 89);
            this.labelLoginText.Name = "labelLoginText";
            this.labelLoginText.Size = new System.Drawing.Size(262, 28);
            this.labelLoginText.TabIndex = 5;
            this.labelLoginText.Text = "Formularz logowania:";
            // 
            // bunifuDragControlAplication
            // 
            this.bunifuDragControlAplication.Fixed = true;
            this.bunifuDragControlAplication.Horizontal = true;
            this.bunifuDragControlAplication.TargetControl = this.panelHeader;
            this.bunifuDragControlAplication.Vertical = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMinimize);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(618, 45);
            this.panelHeader.TabIndex = 6;
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(567, 0);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 0;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(513, 0);
            this.bunifuImageButtonMinimize.Name = "bunifuImageButtonMinimize";
            this.bunifuImageButtonMinimize.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMinimize.TabIndex = 1;
            this.bunifuImageButtonMinimize.TabStop = false;
            this.bunifuImageButtonMinimize.Zoom = 10;
            this.bunifuImageButtonMinimize.Click += new System.EventHandler(this.bunifuImageButtonMinimize_Click);
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(50, 7);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(168, 34);
            this.labelTitleForm.TabIndex = 2;
            this.labelTitleForm.Text = "Logowanie";
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 3;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(618, 343);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelLoginText);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Logowanie";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLoginText;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlAplication;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
    }
}