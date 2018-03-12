using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentCreator
{
    public partial class ShowDocuments : Form
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
        /// Komunikat wyswietlany użytkownikowi.
        /// </summary>
        MessageWindow message;
        public ShowDocuments(MainForm mainForm, DataClassesDatabaseDataContext context)
        {
            this.context = context;
            this.mainForm = mainForm;
            InitializeComponent();
            groupBoxSaveToCSV.Enabled = false;
            CompleteTypeDocumentsList();
            message = new MessageWindow();
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
        /// Wyświetlenie w datagridview danych o dokumentach.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDocuments_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeDocumentsList.Text.Equals(""))
            {
                SearchAllDocuments();
            }else
            {
                SearchChosenDocuments();
            }
            comboBoxTypeDocumentsList.Text = "";
            groupBoxSaveToCSV.Enabled = true;
        }
        /// <summary>
        /// Wyszukanie dokumentów o typie wybranym z listy rozwijanej.
        /// </summary>
        private void SearchChosenDocuments()
        {
            var documents = from document in context.Documents
                            join client in context.Clients on document.ClientID equals client.ID
                            join item in context.Items on document.ItemID equals item.ID
                            join user in context.Users on document.UserID equals user.ID
                            join type in context.TypeNotifications on document.TypeNotificationID equals type.ID
                            where type.Type == comboBoxTypeDocumentsList.Text
                            select new
                            {
                                NumerZgłoszenia = document.ID,
                                TytułZłoszenia = document.TitleNotification,
                                TypZgłoszenia = type.Type,
                                NazwaPrzedmiotu = item.Name,
                                Marka = item.Brand,
                                ImięKlienta = client.FirstName,
                                NazwiskoKlienta = client.Surname,
                                NumerTelefonuKlienta = client.PhoneNumber,
                                ImięPracownika = user.FirstName,
                                NazwiskoPracownika = user.Surname,
                                Uwaga = document.Description
                            };
            dataGridViewDocuments.DataSource = documents;
        }
        /// <summary>
        /// Wyszukanie wszystkich dokumentów dostepnych w bazie.
        /// </summary>
        private void SearchAllDocuments()
        {
            var documents = from document in context.Documents
                            join client in context.Clients on document.ClientID equals client.ID
                            join item in context.Items on document.ItemID equals item.ID
                            join user in context.Users on document.UserID equals user.ID
                            join type in context.TypeNotifications on document.TypeNotificationID equals type.ID
                            select new 
                            {
                                NumerZgłoszenia = document.ID,
                                TytułZłoszenia = document.TitleNotification,
                                TypZgłoszenia = type.Type,
                                NazwaPrzedmiotu = item.Name,
                                Marka = item.Brand,
                                ImięKlienta = client.FirstName,
                                NazwiskoKlienta = client.Surname,
                                NumerTelefonuKlienta = client.PhoneNumber,
                                ImięPracownika = user.FirstName,
                                NazwiskoPracownika = user.Surname,
                                Uwaga = document.Description
                            };
            dataGridViewDocuments.DataSource = documents;
        }
        /// <summary>
        /// Zapis danych z datagridview do pliku .csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveDocuments_Click(object sender, EventArgs e)
        {
            if (!textBoxFileName.Text.Equals(""))
            {
                CreateCSV();
                textBoxFileName.Text = "";
                message.SetMessage("Stworzono plik");
                message.ShowDialog();
            }
        }
        /// <summary>
        /// Utwórz plik .csv
        /// </summary>
        private void CreateCSV()
        {
            StreamWriter writer = new StreamWriter(textBoxFileName.Text + ".csv", false, Encoding.UTF8);
            if (writer != null)
            {
                writer.WriteLine(@"NumerZgłoszenia;TytułZłoszenia;TypZgłoszenia;NazwaPrzedmiotu;Marka;ImięKlienta;NazwiskoKlienta;NumerTelefonuKlienta;ImięPracownika;NazwiskoPracownika;Uwaga;");
                for (int i = 0; i < dataGridViewDocuments.Rows.Count; i++)
                {
                    writer.WriteLine(String.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}",
                        dataGridViewDocuments[0, i].Value.ToString(), dataGridViewDocuments[1, i].Value.ToString(),
                        dataGridViewDocuments[2, i].Value.ToString(), dataGridViewDocuments[3, i].Value.ToString(),
                        dataGridViewDocuments[4, i].Value.ToString(), dataGridViewDocuments[5, i].Value.ToString(),
                        dataGridViewDocuments[6, i].Value.ToString(), dataGridViewDocuments[7, i].Value.ToString(),
                        dataGridViewDocuments[8, i].Value.ToString(), dataGridViewDocuments[9, i].Value.ToString(),
                        dataGridViewDocuments[10, i].Value.ToString()));
                }
                writer.Close();
            }
        }
        /// <summary>
        /// Uzupełnienie listy rozwijanej zawierajacej typy zgłoszeń.
        /// </summary>
        private void CompleteTypeDocumentsList()
        {
            var types = from element in context.TypeNotifications select element;
            List<TypeNotification> listTypes = types.ToList();
            for (int i = 0; i < listTypes.Count(); i++)
            {
                comboBoxTypeDocumentsList.Items.Add(listTypes[i].Type);
            }
            comboBoxTypeDocumentsList.Text = "";
        }
    }
}
