namespace DocumentCreator
{
    partial class ShowDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDocuments));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewDocuments = new System.Windows.Forms.DataGridView();
            this.buttonShowDocuments = new System.Windows.Forms.Button();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonSaveDocuments = new System.Windows.Forms.Button();
            this.labelTypeNotification = new System.Windows.Forms.Label();
            this.comboBoxTypeDocumentsList = new System.Windows.Forms.ComboBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelSaveToCSV = new System.Windows.Forms.Label();
            this.groupBoxSaveToCSV = new System.Windows.Forms.GroupBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocuments)).BeginInit();
            this.groupBoxSaveToCSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1204, 45);
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
            this.labelTitleForm.Size = new System.Drawing.Size(295, 34);
            this.labelTitleForm.TabIndex = 2;
            this.labelTitleForm.Text = "Wyświetl dokumenty";
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(1153, 0);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 0;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // dataGridViewDocuments
            // 
            this.dataGridViewDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocuments.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewDocuments.Name = "dataGridViewDocuments";
            this.dataGridViewDocuments.RowTemplate.Height = 24;
            this.dataGridViewDocuments.Size = new System.Drawing.Size(1204, 608);
            this.dataGridViewDocuments.TabIndex = 9;
            // 
            // buttonShowDocuments
            // 
            this.buttonShowDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonShowDocuments.FlatAppearance.BorderSize = 0;
            this.buttonShowDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowDocuments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowDocuments.ForeColor = System.Drawing.Color.White;
            this.buttonShowDocuments.Location = new System.Drawing.Point(0, 649);
            this.buttonShowDocuments.Name = "buttonShowDocuments";
            this.buttonShowDocuments.Size = new System.Drawing.Size(552, 134);
            this.buttonShowDocuments.TabIndex = 12;
            this.buttonShowDocuments.Text = "Wyświetl dokumenty";
            this.buttonShowDocuments.UseVisualStyleBackColor = false;
            this.buttonShowDocuments.Click += new System.EventHandler(this.buttonShowDocuments_Click);
            // 
            // bunifuDragControlMoveWindow
            // 
            this.bunifuDragControlMoveWindow.Fixed = true;
            this.bunifuDragControlMoveWindow.Horizontal = true;
            this.bunifuDragControlMoveWindow.TargetControl = this.panelHeader;
            this.bunifuDragControlMoveWindow.Vertical = true;
            // 
            // buttonSaveDocuments
            // 
            this.buttonSaveDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonSaveDocuments.FlatAppearance.BorderSize = 0;
            this.buttonSaveDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDocuments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveDocuments.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDocuments.Location = new System.Drawing.Point(428, 43);
            this.buttonSaveDocuments.Name = "buttonSaveDocuments";
            this.buttonSaveDocuments.Size = new System.Drawing.Size(213, 41);
            this.buttonSaveDocuments.TabIndex = 13;
            this.buttonSaveDocuments.Text = "Zapisz zestawienie";
            this.buttonSaveDocuments.UseVisualStyleBackColor = false;
            this.buttonSaveDocuments.Click += new System.EventHandler(this.buttonSaveDocuments_Click);
            // 
            // labelTypeNotification
            // 
            this.labelTypeNotification.AutoSize = true;
            this.labelTypeNotification.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeNotification.ForeColor = System.Drawing.Color.White;
            this.labelTypeNotification.Location = new System.Drawing.Point(558, 655);
            this.labelTypeNotification.Name = "labelTypeNotification";
            this.labelTypeNotification.Size = new System.Drawing.Size(271, 23);
            this.labelTypeNotification.TabIndex = 15;
            this.labelTypeNotification.Text = "Wybierz rodzaj zgłoszenia: ";
            // 
            // comboBoxTypeDocumentsList
            // 
            this.comboBoxTypeDocumentsList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTypeDocumentsList.FormattingEnabled = true;
            this.comboBoxTypeDocumentsList.Location = new System.Drawing.Point(824, 655);
            this.comboBoxTypeDocumentsList.Name = "comboBoxTypeDocumentsList";
            this.comboBoxTypeDocumentsList.Size = new System.Drawing.Size(377, 31);
            this.comboBoxTypeDocumentsList.TabIndex = 16;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFileName.Location = new System.Drawing.Point(162, 49);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(243, 32);
            this.textBoxFileName.TabIndex = 17;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.ForeColor = System.Drawing.Color.White;
            this.labelFileName.Location = new System.Drawing.Point(7, 52);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(135, 23);
            this.labelFileName.TabIndex = 18;
            this.labelFileName.Text = "Nazwa pliku:";
            // 
            // labelSaveToCSV
            // 
            this.labelSaveToCSV.AutoSize = true;
            this.labelSaveToCSV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSaveToCSV.ForeColor = System.Drawing.Color.White;
            this.labelSaveToCSV.Location = new System.Drawing.Point(6, 18);
            this.labelSaveToCSV.Name = "labelSaveToCSV";
            this.labelSaveToCSV.Size = new System.Drawing.Size(310, 23);
            this.labelSaveToCSV.TabIndex = 19;
            this.labelSaveToCSV.Text = "Zapis zestawienia do pliku .csv";
            // 
            // groupBoxSaveToCSV
            // 
            this.groupBoxSaveToCSV.Controls.Add(this.labelSaveToCSV);
            this.groupBoxSaveToCSV.Controls.Add(this.labelFileName);
            this.groupBoxSaveToCSV.Controls.Add(this.textBoxFileName);
            this.groupBoxSaveToCSV.Controls.Add(this.buttonSaveDocuments);
            this.groupBoxSaveToCSV.Location = new System.Drawing.Point(551, 681);
            this.groupBoxSaveToCSV.Name = "groupBoxSaveToCSV";
            this.groupBoxSaveToCSV.Size = new System.Drawing.Size(649, 101);
            this.groupBoxSaveToCSV.TabIndex = 20;
            this.groupBoxSaveToCSV.TabStop = false;
            // 
            // ShowDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(1204, 777);
            this.Controls.Add(this.groupBoxSaveToCSV);
            this.Controls.Add(this.comboBoxTypeDocumentsList);
            this.Controls.Add(this.labelTypeNotification);
            this.Controls.Add(this.buttonShowDocuments);
            this.Controls.Add(this.dataGridViewDocuments);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDocuments";
            this.Text = "ShowDocuments";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocuments)).EndInit();
            this.groupBoxSaveToCSV.ResumeLayout(false);
            this.groupBoxSaveToCSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private System.Windows.Forms.DataGridView dataGridViewDocuments;
        private System.Windows.Forms.Button buttonShowDocuments;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
        private System.Windows.Forms.Button buttonSaveDocuments;
        private System.Windows.Forms.Label labelTypeNotification;
        private System.Windows.Forms.ComboBox comboBoxTypeDocumentsList;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelSaveToCSV;
        private System.Windows.Forms.GroupBox groupBoxSaveToCSV;
    }
}