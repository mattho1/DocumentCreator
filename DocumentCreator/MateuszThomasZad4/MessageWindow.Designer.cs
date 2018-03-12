namespace DocumentCreator
{
    partial class MessageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWindow));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(391, 45);
            this.panelHeader.TabIndex = 8;
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
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(50, 7);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(160, 34);
            this.labelTitleForm.TabIndex = 2;
            this.labelTitleForm.Text = "Komunikat";
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNews.ForeColor = System.Drawing.Color.White;
            this.labelNews.Location = new System.Drawing.Point(12, 88);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(114, 23);
            this.labelNews.TabIndex = 9;
            this.labelNews.Text = "Komunikat";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(73, 217);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(232, 31);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bunifuDragControlMoveWindow
            // 
            this.bunifuDragControlMoveWindow.Fixed = true;
            this.bunifuDragControlMoveWindow.Horizontal = true;
            this.bunifuDragControlMoveWindow.TargetControl = this.panelHeader;
            this.bunifuDragControlMoveWindow.Vertical = true;
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(391, 287);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageWindow";
            this.Text = "MessageWindow";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Button buttonOK;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
    }
}