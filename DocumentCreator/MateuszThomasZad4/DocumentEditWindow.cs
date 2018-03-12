using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace DocumentCreator
{
    public partial class DocumentEditWindow : Form
    {
        /// <summary>
        /// Referencja do okna głównego.
        /// </summary>
        MainForm mainForm;
        /// <summary>
        /// Kontekst do korzystania z bazy danych.
        /// </summary>
        DataClassesDatabaseDataContext context;
        /// <summary>
        /// Zalogowany pracownik.
        /// </summary>
        User employee;
        /// <summary>
        /// Komunikat wyswietlany użytkownikowi.
        /// </summary>
        MessageWindow message;
        /// <summary>
        /// Informacja czy jakiś dokument zostął znaleziony.
        /// </summary>
        bool IsDocumentFound;
        /// <summary>
        /// Numer znalezionego dokumentu.
        /// </summary>
        int NumberFoundDocument;
        public DocumentEditWindow(string typeWindow, MainForm mainForm, DataClassesDatabaseDataContext context, User employee)
        {
            message = new MessageWindow();
            IsDocumentFound = false;
            NumberFoundDocument = -1;
            this.employee = employee;
            this.context = context;
            this.mainForm = mainForm;
            InitializeComponent();
            CompleteTypeNotificationsList();
            CompleteTitleList();
            SetParameters(typeWindow);
        }
        /// <summary>
        /// Obsługa przycisku zamykającego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonExit_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Close();
        }
        /// <summary>
        /// Obśługa przycisku zapisu dokumentu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveDocumentInDatabase_Click(object sender, EventArgs e)
        {
            if (CheckCorrectness())
            {
                SaveDocumentInDatabase();
                message.SetMessage("Dodano dokument \ndo bazy danych.");
                message.ShowDialog();
                ClearForm();
                CompleteTitleList();
            }
            else
            {
                message.SetMessage("Uzupełnij poprawnie dane.");
                message.ShowDialog();
            }
        }
        /// <summary>
        /// Zapis dokumentu w bazie danych.
        /// </summary>
        private void SaveDocumentInDatabase()
        {
            Document document = new Document();
            document.ClientID = NumberIDClient(textBoxFirstname.Text, textBoxSurname.Text, textBoxPhoneNumber.Text);
            document.TitleNotification = comboBoxTitlesDocuments.Text;
            document.TypeNotificationID = NumberIDType(comboBoxTypeNotification.Text);
            document.ItemID = NumberIDItem(textBoxItemName.Text);
            document.Description = textBoxNote.Text;
            document.UserID = employee.ID;
            context.Documents.InsertOnSubmit(document);
            context.SubmitChanges();
        }
        /// <summary>
        /// Numer ID szukanego przedmiotu.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        private int NumberIDItem(string itemName)
        {
            Item item = (from element in context.Items
                         where element.Name == itemName
                         select element).FirstOrDefault();
            if (item != null)
            {
                return item.ID;
            }
            else
            {
                AddItem(itemName, textBoxBrand.Text);
                return NumberIDItem(itemName);
            }
        }
        /// <summary>
        /// Dodaje przedmiot do bazy danych.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="brand"></param>
        private void AddItem(string itemName, string brand)
        {
            Item item = new Item();
            item.Name = itemName;
            item.Brand = brand;
            context.Items.InsertOnSubmit(item);
            context.SubmitChanges();
        }
        /// <summary>
        /// Numer ID szukanego klienta.
        /// </summary>
        /// <param name="clientFirstName"></param>
        /// <param name="clientSurname"></param>
        /// <param name="clientPhoneNumber"></param>
        /// <returns></returns>
        private int NumberIDClient(string clientFirstName, string clientSurname, string clientPhoneNumber)
        {
            Client client = (from element in context.Clients
                             where element.FirstName == clientFirstName && element.Surname == clientSurname && element.PhoneNumber == clientPhoneNumber
                             select element).FirstOrDefault();
            if(client != null)
            {
                return client.ID;
            }else
            {
                AddClient(clientFirstName, clientSurname, clientPhoneNumber);
                return NumberIDClient(clientFirstName, clientSurname, clientPhoneNumber);
            }
        }
        /// <summary>
        /// Dodanie klienta do bazy danych.
        /// </summary>
        /// <param name="clientFirstName"></param>
        /// <param name="clientSurname"></param>
        /// <param name="clientPhoneNumber"></param>
        private void AddClient(string clientFirstName, string clientSurname, string clientPhoneNumber)
        {
            Client client = new Client();
            client.FirstName = clientFirstName;
            client.Surname = clientSurname;
            client.PhoneNumber = clientPhoneNumber;
            context.Clients.InsertOnSubmit(client);
            context.SubmitChanges(); 
        }
        /// <summary>
        /// Numer ID typu z bazy danych.
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private int NumberIDType(string typeName)
        {
            TypeNotification type = (from element in context.TypeNotifications
                                     where element.Type == typeName
                                     select element).FirstOrDefault();
            return type.ID;
        }
        /// <summary>
        /// Obśługa przycisku zapisu dokumentu do pliku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (CheckCorrectness()&&!textBoxNameFile.Equals(""))
            {
                if (radioButtonPDF.Checked)
                {
                    SaveDocumentToPDF();
                }
                else if (radioButtonTXT.Checked)
                {
                    SaveDocumentToTXT();
                }
                message.SetMessage("Zapisano do pliku.");
                message.ShowDialog();
            }
            else
            {
                message.SetMessage("Uzupełnij poprawnie dane.");
                message.ShowDialog();
            }
        }
        /// <summary>
        /// Sprawdzenie poprawnosci uzupełnienie formularza.
        /// </summary>
        /// <returns></returns>
        private bool CheckCorrectness()
        {
            if (textBoxFirstname.Text.Equals(""))
            {
                return false;
            }
            else if (textBoxPhoneNumber.Text.Equals(""))
            {
                return false;
            }
            else if (textBoxSurname.Text.Equals(""))
            {
                return false;
            }
            else if (comboBoxTitlesDocuments.Text.Equals(""))
            {
                return false;
            }
            else if (comboBoxTypeNotification.Text.Equals(""))
            {
                return false;
            }
            else if (textBoxItemName.Text.Equals(""))
            {
                return false;
            }
            else if (textBoxBrand.Text.Equals(""))
            {
                return false;
            }
            else if (textBoxNote.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Wyczyszczenie pól formularza.
        /// </summary>
        private void ClearForm()
        {
            textBoxFirstname.Text = "";
            textBoxPhoneNumber.Text = "";
            comboBoxTitlesDocuments.Text = "";
            textBoxSurname.Text = "";
            textBoxNote.Text = "";
            textBoxItemName.Text = "";
            textBoxBrand.Text = "";
            comboBoxTypeNotification.Text = "";
        }
        /// <summary>
        /// Obśługa przycisku usuń dokument.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveDocument_Click(object sender, EventArgs e)
        {
            RemoveDocument();
        }
        /// <summary>
        /// Sprawdznie czy można usunąć dokument i obśługa usuwania.
        /// </summary>
        private void RemoveDocument()
        {
            if (IsDocumentFound)
            {
                RemoveDocumentFromDateBase();
                ClearForm();
                CompleteTitleList();
            }
            else
            {
                message.SetMessage("Nie wybrałes dokumentu \ndo usunięcia");
                message.ShowDialog();
            }
        }
        /// <summary>
        /// Usuwa dokument z bazy danych.
        /// </summary>
        private void RemoveDocumentFromDateBase()
        {
            Document document = (from element in context.Documents
                                 where element.ID == NumberFoundDocument
                                 select element).FirstOrDefault();
            context.Documents.DeleteOnSubmit(document);
            context.SubmitChanges();
        }
        /// <summary>
        /// Obsługa przycisku wyszukaj dokument.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchDocument_Click(object sender, EventArgs e)
        {
            Document document = SearchDocument();
            if (document != null)
            {
                IsDocumentFound = true;
                NumberFoundDocument = document.ID;
                CompleteForm(document);
            }
            else
            {
                IsDocumentFound = false;
                NumberFoundDocument = - 1;
                message.SetMessage("Nie znaleziono dokumentu \no podanym tytule");
                message.ShowDialog();
                ClearForm();
            }
        }
        /// <summary>
        /// Wyszukanie dokumentu w bazie danych.
        /// </summary>
        /// <returns></returns>
        private Document SearchDocument()
        {
            Document document = (from element in context.Documents
                                 where element.TitleNotification == comboBoxTitlesDocuments.Text
                                 select element).FirstOrDefault();
            return document;
        }
        /// <summary>
        /// Wypełnienie formularza danymi.
        /// </summary>
        /// <param name="document"></param>
        private void CompleteForm(Document document)
        {
            textBoxFirstname.Text = document.Client.FirstName;
            textBoxPhoneNumber.Text = document.Client.PhoneNumber;
            comboBoxTitlesDocuments.Text = document.TitleNotification;
            textBoxSurname.Text = document.Client.Surname;
            textBoxNote.Text = document.Description;
            textBoxItemName.Text = document.Item.Name;
            textBoxBrand.Text = document.Item.Brand;
            comboBoxTypeNotification.Text = document.TypeNotification.Type;
        }
        /// <summary>
        /// Uzupełnienei listy rozwijanej o typy zgłoszeń.
        /// </summary>
        private void CompleteTypeNotificationsList()
        {
            var types = from element in context.TypeNotifications select element;
            List<TypeNotification> listTypes = types.ToList();
            for (int i = 0; i < listTypes.Count(); i++)
            {
                comboBoxTypeNotification.Items.Add(listTypes[i].Type);
            }
        }
        /// <summary>
        /// Uzupełnienie listy rozwijanej tytułów zgłoszeń
        /// </summary>
        private void CompleteTitleList()
        {
            for (int i = comboBoxTitlesDocuments.Items.Count - 1; i > 0 ; i--)
            {
                comboBoxTitlesDocuments.Items.RemoveAt(i);
            }
            var titles = from element in context.Documents select element;
            List<Document> listTitles = titles.ToList();
            for (int i = 0; i < listTitles.Count(); i++)
            {
                comboBoxTitlesDocuments.Items.Add(listTitles[i].TitleNotification);
            }
            comboBoxTitlesDocuments.Text = "";
        }
        /// <summary>
        /// Obśługa przycisku modyfikuj dokument.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifyDocument_Click(object sender, EventArgs e)
        {
            SaveDocumentInDatabase();
            RemoveDocument();
        }
        /// <summary>
        /// Zapis dokumentu do pliku TXT
        /// </summary>
        private void SaveDocumentToTXT()
        {
            TXTDocument.CreatTXT(textBoxNameFile.Text, comboBoxTitlesDocuments.Text, comboBoxTypeNotification.Text,
               textBoxFirstname.Text, textBoxSurname.Text, textBoxPhoneNumber.Text, employee.FirstName, employee.Surname,
               textBoxItemName.Text, textBoxBrand.Text, textBoxNote.Text, imageListLogo.Images[0]);
        }
        /// <summary>
        /// Zapis dokumentu do pliku PDF
        /// </summary>
        private void SaveDocumentToPDF()
        {
            PDFDocument.CreatPDF(textBoxNameFile.Text, comboBoxTitlesDocuments.Text, comboBoxTypeNotification.Text,
               textBoxFirstname.Text, textBoxSurname.Text, textBoxPhoneNumber.Text, employee.FirstName, employee.Surname,
              textBoxItemName.Text, textBoxBrand.Text, textBoxNote.Text, imageListLogo.Images[0]);
        }
        /// <summary>
        /// Ustawienie okna według funkcji jaką ma spełniać.
        /// </summary>
        /// <param name="typeWindow"></param>
        private void SetParameters(string typeWindow)
        {
            if (typeWindow.Equals("add"))
            {
                SetAddWindow();
            }
            else if (typeWindow.Equals("remove"))
            {
                SetRemoveWindow();
            }
            else if (typeWindow.Equals("modify"))
            {
                SetModifyWindow();
            }
            else if (typeWindow.Equals("search"))
            {
                SetSearchWindow();
            }
        }
        /// <summary>
        /// Ustawienie okna jako okno do dodawania dokumentów.
        /// </summary>
        private void SetAddWindow()
        {
            buttonModifyDocument.Enabled = false;
            buttonRemoveDocument.Enabled = false;
            buttonSearchDocument.Enabled = false;
        }
        /// <summary>
        /// Ustawienie okna jako okno do usuwania dokumentów.
        /// </summary>
        private void SetRemoveWindow()
        {
            buttonSaveDocumentInDatabase.Visible = false;
            buttonModifyDocument.Visible = false;
            groupBoxParametersDocument.Enabled = false;
        }
        /// <summary>
        /// Ustawienie okna jako okno do modyfikowania dokumentów.
        /// </summary>
        private void SetModifyWindow()
        {
            buttonSaveDocumentInDatabase.Visible = false;
            buttonRemoveDocument.Enabled = false;
        }
        /// <summary>
        /// Ustawienie okna jako okno do wyszukiwania dokumentów.
        /// </summary>
        private void SetSearchWindow()
        {
            buttonSaveDocumentInDatabase.Visible = false;
            buttonModifyDocument.Enabled = false;
            buttonRemoveDocument.Enabled = false;
            groupBoxParametersDocument.Enabled = false;
        }
    }
}
