namespace DocumentCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelActualTime = new System.Windows.Forms.Label();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlControlAplication = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonAddDocument = new System.Windows.Forms.Button();
            this.buttonRemoveDocument = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSearchAndSaveToFile = new System.Windows.Forms.Button();
            this.buttonShowDocuments = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelSurnameUser = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panelHeader.Controls.Add(this.labelActualTime);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMinimize);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(692, 45);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // labelActualTime
            // 
            this.labelActualTime.AutoSize = true;
            this.labelActualTime.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualTime.ForeColor = System.Drawing.Color.White;
            this.labelActualTime.Location = new System.Drawing.Point(415, 8);
            this.labelActualTime.Name = "labelActualTime";
            this.labelActualTime.Size = new System.Drawing.Size(142, 32);
            this.labelActualTime.TabIndex = 7;
            this.labelActualTime.Text = "Actual time";
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(50, 8);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(92, 34);
            this.labelTitleForm.TabIndex = 5;
            this.labelTitleForm.Text = "Menu";
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 4;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(581, 1);
            this.bunifuImageButtonMinimize.Name = "bunifuImageButtonMinimize";
            this.bunifuImageButtonMinimize.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMinimize.TabIndex = 2;
            this.bunifuImageButtonMinimize.TabStop = false;
            this.bunifuImageButtonMinimize.Zoom = 10;
            this.bunifuImageButtonMinimize.Click += new System.EventHandler(this.bunifuImageButtonMinimize_Click);
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(635, 1);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 1;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // bunifuDragControlControlAplication
            // 
            this.bunifuDragControlControlAplication.Fixed = true;
            this.bunifuDragControlControlAplication.Horizontal = true;
            this.bunifuDragControlControlAplication.TargetControl = this.panelHeader;
            this.bunifuDragControlControlAplication.Vertical = true;
            // 
            // buttonAddDocument
            // 
            this.buttonAddDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonAddDocument.FlatAppearance.BorderSize = 0;
            this.buttonAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDocument.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddDocument.ForeColor = System.Drawing.Color.White;
            this.buttonAddDocument.Location = new System.Drawing.Point(75, 119);
            this.buttonAddDocument.Name = "buttonAddDocument";
            this.buttonAddDocument.Size = new System.Drawing.Size(250, 117);
            this.buttonAddDocument.TabIndex = 1;
            this.buttonAddDocument.Text = "Dodaj";
            this.buttonAddDocument.UseVisualStyleBackColor = false;
            this.buttonAddDocument.Click += new System.EventHandler(this.buttonAddDocument_Click);
            // 
            // buttonRemoveDocument
            // 
            this.buttonRemoveDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonRemoveDocument.FlatAppearance.BorderSize = 0;
            this.buttonRemoveDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveDocument.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveDocument.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveDocument.Location = new System.Drawing.Point(372, 119);
            this.buttonRemoveDocument.Name = "buttonRemoveDocument";
            this.buttonRemoveDocument.Size = new System.Drawing.Size(250, 117);
            this.buttonRemoveDocument.TabIndex = 2;
            this.buttonRemoveDocument.Text = "Usuń";
            this.buttonRemoveDocument.UseVisualStyleBackColor = false;
            this.buttonRemoveDocument.Click += new System.EventHandler(this.buttonRemoveDocument_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModify.ForeColor = System.Drawing.Color.White;
            this.buttonModify.Location = new System.Drawing.Point(75, 271);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(250, 117);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modyfikuj";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSearchAndSaveToFile
            // 
            this.buttonSearchAndSaveToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonSearchAndSaveToFile.FlatAppearance.BorderSize = 0;
            this.buttonSearchAndSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchAndSaveToFile.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchAndSaveToFile.ForeColor = System.Drawing.Color.White;
            this.buttonSearchAndSaveToFile.Location = new System.Drawing.Point(372, 271);
            this.buttonSearchAndSaveToFile.Name = "buttonSearchAndSaveToFile";
            this.buttonSearchAndSaveToFile.Size = new System.Drawing.Size(250, 117);
            this.buttonSearchAndSaveToFile.TabIndex = 4;
            this.buttonSearchAndSaveToFile.Text = "Wyszukaj";
            this.buttonSearchAndSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSearchAndSaveToFile.Click += new System.EventHandler(this.buttonSearchAndSaveToFile_Click);
            // 
            // buttonShowDocuments
            // 
            this.buttonShowDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonShowDocuments.FlatAppearance.BorderSize = 0;
            this.buttonShowDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowDocuments.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowDocuments.ForeColor = System.Drawing.Color.White;
            this.buttonShowDocuments.Location = new System.Drawing.Point(75, 422);
            this.buttonShowDocuments.Name = "buttonShowDocuments";
            this.buttonShowDocuments.Size = new System.Drawing.Size(547, 117);
            this.buttonShowDocuments.TabIndex = 6;
            this.buttonShowDocuments.Text = "Wyświetl zgłoszenia";
            this.buttonShowDocuments.UseVisualStyleBackColor = false;
            this.buttonShowDocuments.Click += new System.EventHandler(this.buttonShowDocuments_Click);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelSurnameUser
            // 
            this.labelSurnameUser.AutoSize = true;
            this.labelSurnameUser.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurnameUser.ForeColor = System.Drawing.Color.White;
            this.labelSurnameUser.Location = new System.Drawing.Point(69, 62);
            this.labelSurnameUser.Name = "labelSurnameUser";
            this.labelSurnameUser.Size = new System.Drawing.Size(198, 34);
            this.labelSurnameUser.TabIndex = 8;
            this.labelSurnameUser.Text = "Zalogowany: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(692, 593);
            this.Controls.Add(this.labelSurnameUser);
            this.Controls.Add(this.buttonShowDocuments);
            this.Controls.Add(this.buttonSearchAndSaveToFile);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonRemoveDocument);
            this.Controls.Add(this.buttonAddDocument);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlControlAplication;
        private System.Windows.Forms.Button buttonAddDocument;
        private System.Windows.Forms.Button buttonRemoveDocument;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSearchAndSaveToFile;
        private System.Windows.Forms.Button buttonShowDocuments;
        private System.Windows.Forms.Label labelActualTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelSurnameUser;
    }
}

