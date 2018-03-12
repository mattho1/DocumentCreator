namespace DocumentCreator
{
    partial class DocumentEditWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentEditWindow));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelWriteTiteDocument = new System.Windows.Forms.Label();
            this.buttonSaveDocumentInDatabase = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelTypeNotification = new System.Windows.Forms.Label();
            this.comboBoxTypeNotification = new System.Windows.Forms.ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxNameFile = new System.Windows.Forms.TextBox();
            this.labelSaveToFile = new System.Windows.Forms.Label();
            this.labelNameFile = new System.Windows.Forms.Label();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.labelChoiceFileForm = new System.Windows.Forms.Label();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.buttonRemoveDocument = new System.Windows.Forms.Button();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonSearchDocument = new System.Windows.Forms.Button();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonModifyDocument = new System.Windows.Forms.Button();
            this.comboBoxTitlesDocuments = new System.Windows.Forms.ComboBox();
            this.imageListLogo = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxParametersDocument = new System.Windows.Forms.GroupBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.groupBoxParametersDocument.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(654, 45);
            this.panelHeader.TabIndex = 7;
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
            this.labelTitleForm.Size = new System.Drawing.Size(156, 34);
            this.labelTitleForm.TabIndex = 2;
            this.labelTitleForm.Text = "Dokument";
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(592, 0);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 0;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // labelWriteTiteDocument
            // 
            this.labelWriteTiteDocument.AutoSize = true;
            this.labelWriteTiteDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteTiteDocument.ForeColor = System.Drawing.Color.White;
            this.labelWriteTiteDocument.Location = new System.Drawing.Point(17, 60);
            this.labelWriteTiteDocument.Name = "labelWriteTiteDocument";
            this.labelWriteTiteDocument.Size = new System.Drawing.Size(220, 23);
            this.labelWriteTiteDocument.TabIndex = 9;
            this.labelWriteTiteDocument.Text = "Wpisz tytuł zgłoszenia";
            // 
            // buttonSaveDocumentInDatabase
            // 
            this.buttonSaveDocumentInDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonSaveDocumentInDatabase.FlatAppearance.BorderSize = 0;
            this.buttonSaveDocumentInDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDocumentInDatabase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveDocumentInDatabase.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDocumentInDatabase.Location = new System.Drawing.Point(393, 52);
            this.buttonSaveDocumentInDatabase.Name = "buttonSaveDocumentInDatabase";
            this.buttonSaveDocumentInDatabase.Size = new System.Drawing.Size(232, 31);
            this.buttonSaveDocumentInDatabase.TabIndex = 11;
            this.buttonSaveDocumentInDatabase.Text = "Zapisz dokument";
            this.buttonSaveDocumentInDatabase.UseVisualStyleBackColor = false;
            this.buttonSaveDocumentInDatabase.Click += new System.EventHandler(this.buttonSaveDocumentInDatabase_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(16, 17);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(63, 23);
            this.labelClient.TabIndex = 13;
            this.labelClient.Text = "Klient";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstname.ForeColor = System.Drawing.Color.White;
            this.labelFirstname.Location = new System.Drawing.Point(16, 62);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(65, 23);
            this.labelFirstname.TabIndex = 14;
            this.labelFirstname.Text = "Imie: ";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurname.ForeColor = System.Drawing.Color.White;
            this.labelSurname.Location = new System.Drawing.Point(16, 98);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(108, 23);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFirstname.Location = new System.Drawing.Point(227, 59);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(159, 32);
            this.textBoxFirstname.TabIndex = 16;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurname.Location = new System.Drawing.Point(227, 95);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(159, 32);
            this.textBoxSurname.TabIndex = 17;
            // 
            // labelTypeNotification
            // 
            this.labelTypeNotification.AutoSize = true;
            this.labelTypeNotification.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeNotification.ForeColor = System.Drawing.Color.White;
            this.labelTypeNotification.Location = new System.Drawing.Point(16, 171);
            this.labelTypeNotification.Name = "labelTypeNotification";
            this.labelTypeNotification.Size = new System.Drawing.Size(183, 23);
            this.labelTypeNotification.TabIndex = 18;
            this.labelTypeNotification.Text = "Rodzaj zgłoszenia";
            // 
            // comboBoxTypeNotification
            // 
            this.comboBoxTypeNotification.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTypeNotification.FormattingEnabled = true;
            this.comboBoxTypeNotification.Location = new System.Drawing.Point(20, 206);
            this.comboBoxTypeNotification.Name = "comboBoxTypeNotification";
            this.comboBoxTypeNotification.Size = new System.Drawing.Size(366, 31);
            this.comboBoxTypeNotification.TabIndex = 19;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelItem.ForeColor = System.Drawing.Color.White;
            this.labelItem.Location = new System.Drawing.Point(16, 261);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(213, 23);
            this.labelItem.TabIndex = 20;
            this.labelItem.Text = "Przedmiot zgłoszenia";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNote.ForeColor = System.Drawing.Color.White;
            this.labelNote.Location = new System.Drawing.Point(17, 383);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(70, 23);
            this.labelNote.TabIndex = 22;
            this.labelNote.Text = "Uwagi";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNote.Location = new System.Drawing.Point(20, 419);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(604, 136);
            this.textBoxNote.TabIndex = 23;
            // 
            // textBoxNameFile
            // 
            this.textBoxNameFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameFile.Location = new System.Drawing.Point(166, 836);
            this.textBoxNameFile.Name = "textBoxNameFile";
            this.textBoxNameFile.Size = new System.Drawing.Size(221, 32);
            this.textBoxNameFile.TabIndex = 24;
            // 
            // labelSaveToFile
            // 
            this.labelSaveToFile.AutoSize = true;
            this.labelSaveToFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSaveToFile.ForeColor = System.Drawing.Color.White;
            this.labelSaveToFile.Location = new System.Drawing.Point(17, 760);
            this.labelSaveToFile.Name = "labelSaveToFile";
            this.labelSaveToFile.Size = new System.Drawing.Size(154, 23);
            this.labelSaveToFile.TabIndex = 25;
            this.labelSaveToFile.Text = "Zapisz do pliku";
            // 
            // labelNameFile
            // 
            this.labelNameFile.AutoSize = true;
            this.labelNameFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameFile.ForeColor = System.Drawing.Color.White;
            this.labelNameFile.Location = new System.Drawing.Point(17, 839);
            this.labelNameFile.Name = "labelNameFile";
            this.labelNameFile.Size = new System.Drawing.Size(129, 23);
            this.labelNameFile.TabIndex = 26;
            this.labelNameFile.Text = "Nazwa pliku";
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonSaveToFile.FlatAppearance.BorderSize = 0;
            this.buttonSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveToFile.ForeColor = System.Drawing.Color.White;
            this.buttonSaveToFile.Location = new System.Drawing.Point(393, 835);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(232, 33);
            this.buttonSaveToFile.TabIndex = 27;
            this.buttonSaveToFile.Text = "Zapisz do pliku";
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // labelChoiceFileForm
            // 
            this.labelChoiceFileForm.AutoSize = true;
            this.labelChoiceFileForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoiceFileForm.ForeColor = System.Drawing.Color.White;
            this.labelChoiceFileForm.Location = new System.Drawing.Point(17, 801);
            this.labelChoiceFileForm.Name = "labelChoiceFileForm";
            this.labelChoiceFileForm.Size = new System.Drawing.Size(208, 23);
            this.labelChoiceFileForm.TabIndex = 28;
            this.labelChoiceFileForm.Text = "Wybierz format pliku";
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPDF.ForeColor = System.Drawing.Color.White;
            this.radioButtonPDF.Location = new System.Drawing.Point(321, 799);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(66, 27);
            this.radioButtonPDF.TabIndex = 29;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTXT.ForeColor = System.Drawing.Color.White;
            this.radioButtonTXT.Location = new System.Drawing.Point(431, 799);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(61, 27);
            this.radioButtonTXT.TabIndex = 30;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDocument
            // 
            this.buttonRemoveDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonRemoveDocument.FlatAppearance.BorderSize = 0;
            this.buttonRemoveDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveDocument.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveDocument.Location = new System.Drawing.Point(393, 123);
            this.buttonRemoveDocument.Name = "buttonRemoveDocument";
            this.buttonRemoveDocument.Size = new System.Drawing.Size(232, 31);
            this.buttonRemoveDocument.TabIndex = 31;
            this.buttonRemoveDocument.Text = "Usuń dokument";
            this.buttonRemoveDocument.UseVisualStyleBackColor = false;
            this.buttonRemoveDocument.Click += new System.EventHandler(this.buttonRemoveDocument_Click);
            // 
            // bunifuDragControlMoveWindow
            // 
            this.bunifuDragControlMoveWindow.Fixed = true;
            this.bunifuDragControlMoveWindow.Horizontal = true;
            this.bunifuDragControlMoveWindow.TargetControl = this.panelHeader;
            this.bunifuDragControlMoveWindow.Vertical = true;
            // 
            // buttonSearchDocument
            // 
            this.buttonSearchDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonSearchDocument.FlatAppearance.BorderSize = 0;
            this.buttonSearchDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchDocument.ForeColor = System.Drawing.Color.White;
            this.buttonSearchDocument.Location = new System.Drawing.Point(393, 86);
            this.buttonSearchDocument.Name = "buttonSearchDocument";
            this.buttonSearchDocument.Size = new System.Drawing.Size(232, 31);
            this.buttonSearchDocument.TabIndex = 33;
            this.buttonSearchDocument.Text = "Wyszukaj dokument";
            this.buttonSearchDocument.UseVisualStyleBackColor = false;
            this.buttonSearchDocument.Click += new System.EventHandler(this.buttonSearchDocument_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumber.Location = new System.Drawing.Point(16, 134);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(167, 23);
            this.labelPhoneNumber.TabIndex = 34;
            this.labelPhoneNumber.Text = "Numer telefonu:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(227, 131);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(159, 32);
            this.textBoxPhoneNumber.TabIndex = 35;
            // 
            // buttonModifyDocument
            // 
            this.buttonModifyDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.buttonModifyDocument.FlatAppearance.BorderSize = 0;
            this.buttonModifyDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModifyDocument.ForeColor = System.Drawing.Color.White;
            this.buttonModifyDocument.Location = new System.Drawing.Point(392, 160);
            this.buttonModifyDocument.Name = "buttonModifyDocument";
            this.buttonModifyDocument.Size = new System.Drawing.Size(232, 31);
            this.buttonModifyDocument.TabIndex = 36;
            this.buttonModifyDocument.Text = "Modyfikuj dokument";
            this.buttonModifyDocument.UseVisualStyleBackColor = false;
            this.buttonModifyDocument.Click += new System.EventHandler(this.buttonModifyDocument_Click);
            // 
            // comboBoxTitlesDocuments
            // 
            this.comboBoxTitlesDocuments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTitlesDocuments.FormattingEnabled = true;
            this.comboBoxTitlesDocuments.Location = new System.Drawing.Point(21, 86);
            this.comboBoxTitlesDocuments.Name = "comboBoxTitlesDocuments";
            this.comboBoxTitlesDocuments.Size = new System.Drawing.Size(366, 31);
            this.comboBoxTitlesDocuments.TabIndex = 37;
            // 
            // imageListLogo
            // 
            this.imageListLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLogo.ImageStream")));
            this.imageListLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLogo.Images.SetKeyName(0, "logoBCS.png");
            // 
            // groupBoxParametersDocument
            // 
            this.groupBoxParametersDocument.Controls.Add(this.textBoxBrand);
            this.groupBoxParametersDocument.Controls.Add(this.textBoxItemName);
            this.groupBoxParametersDocument.Controls.Add(this.labelBrand);
            this.groupBoxParametersDocument.Controls.Add(this.labelItemName);
            this.groupBoxParametersDocument.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxParametersDocument.Controls.Add(this.labelPhoneNumber);
            this.groupBoxParametersDocument.Controls.Add(this.textBoxNote);
            this.groupBoxParametersDocument.Controls.Add(this.labelNote);
            this.groupBoxParametersDocument.Controls.Add(this.labelItem);
            this.groupBoxParametersDocument.Controls.Add(this.comboBoxTypeNotification);
            this.groupBoxParametersDocument.Controls.Add(this.labelTypeNotification);
            this.groupBoxParametersDocument.Controls.Add(this.textBoxSurname);
            this.groupBoxParametersDocument.Controls.Add(this.textBoxFirstname);
            this.groupBoxParametersDocument.Controls.Add(this.labelSurname);
            this.groupBoxParametersDocument.Controls.Add(this.labelFirstname);
            this.groupBoxParametersDocument.Controls.Add(this.labelClient);
            this.groupBoxParametersDocument.Location = new System.Drawing.Point(0, 187);
            this.groupBoxParametersDocument.Name = "groupBoxParametersDocument";
            this.groupBoxParametersDocument.Size = new System.Drawing.Size(654, 570);
            this.groupBoxParametersDocument.TabIndex = 38;
            this.groupBoxParametersDocument.TabStop = false;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelItemName.ForeColor = System.Drawing.Color.White;
            this.labelItemName.Location = new System.Drawing.Point(16, 300);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(197, 23);
            this.labelItemName.TabIndex = 36;
            this.labelItemName.Text = "Nazwa przedmiotu:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(17, 337);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(78, 23);
            this.labelBrand.TabIndex = 37;
            this.labelBrand.Text = "Marka:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxItemName.Location = new System.Drawing.Point(227, 297);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(159, 32);
            this.textBoxItemName.TabIndex = 38;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBrand.Location = new System.Drawing.Point(227, 334);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(159, 32);
            this.textBoxBrand.TabIndex = 39;
            // 
            // DocumentEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(654, 887);
            this.Controls.Add(this.buttonModifyDocument);
            this.Controls.Add(this.groupBoxParametersDocument);
            this.Controls.Add(this.comboBoxTitlesDocuments);
            this.Controls.Add(this.buttonSearchDocument);
            this.Controls.Add(this.buttonRemoveDocument);
            this.Controls.Add(this.radioButtonTXT);
            this.Controls.Add(this.radioButtonPDF);
            this.Controls.Add(this.labelChoiceFileForm);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.labelNameFile);
            this.Controls.Add(this.labelSaveToFile);
            this.Controls.Add(this.textBoxNameFile);
            this.Controls.Add(this.labelWriteTiteDocument);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonSaveDocumentInDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocumentEditWindow";
            this.Text = "DocumentEditWindow";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.groupBoxParametersDocument.ResumeLayout(false);
            this.groupBoxParametersDocument.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private System.Windows.Forms.Label labelWriteTiteDocument;
        private System.Windows.Forms.Button buttonSaveDocumentInDatabase;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelTypeNotification;
        private System.Windows.Forms.ComboBox comboBoxTypeNotification;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxNameFile;
        private System.Windows.Forms.Label labelSaveToFile;
        private System.Windows.Forms.Label labelNameFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Label labelChoiceFileForm;
        private System.Windows.Forms.RadioButton radioButtonPDF;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.Button buttonRemoveDocument;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
        private System.Windows.Forms.Button buttonSearchDocument;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonModifyDocument;
        private System.Windows.Forms.ComboBox comboBoxTitlesDocuments;
        private System.Windows.Forms.ImageList imageListLogo;
        private System.Windows.Forms.GroupBox groupBoxParametersDocument;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelItemName;
    }
}