using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentCreator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Okno logowania.
        /// </summary>
        LoginForm loginWindow;
        /// <summary>
        /// Okno wyświetlanai dokumentów i zapisywania zestawień.
        /// </summary>
        ShowDocuments showDocumentsWindow;
        /// <summary>
        /// Okno edycji dokumentu.
        /// </summary>
        DocumentEditWindow documentEditWindow;
        /// <summary>
        /// Bieżąca data. 
        /// </summary>
        DateTime thisDay;
        /// <summary>
        /// Kontekst do korzystania z bazy danych.
        /// </summary>
        DataClassesDatabaseDataContext context;
        /// <summary>
        /// Zalogowany pracownik.
        /// </summary>
        User employee;
        public MainForm()
        {
            context = new DataClassesDatabaseDataContext();
            InitializeComponent();
            timerClock.Start();
        }
        /// <summary>
        /// Wyświetlenie okna logowania po uruchomieniu programu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            loginWindow = new LoginForm(context, this);
            loginWindow.ShowDialog();
        }
        /// <summary>
        /// Ustawienie okna ze względu na wynik logowania.
        /// </summary>
        /// <param name="correctLogin"></param>
        /// <param name="employee"></param>
        public void dataFromLoginWindow(bool correctLogin, User employee)
        {
            if (correctLogin)
            {
                this.employee = employee;
                labelSurnameUser.Text += " " + employee.Surname;
                loginWindow.Close();
            }
            else
            {
                loginWindow.Close();
                Close();
            }
        }
        /// <summary>
        /// Obsługa przycisku zamykającego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Obśługa przycisku minimalizującego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Otawrcie okna umozliwiającego dodawanie dokumentu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDocument_Click(object sender, EventArgs e)
        {
            OpenWindow("add");
        }
        /// <summary>
        /// Otawrcie okna umozliwiającego usuwanie dokumentu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveDocument_Click(object sender, EventArgs e)
        {
            OpenWindow("remove");
        }
        /// <summary>
        /// Otawrcie okna umozliwiającego modyfikacje dokumentu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            OpenWindow("modify");
            //this.Visible = false;
            //documentEditWindow = new DocumentEditWindow("modify",this, context, employee);
            //documentEditWindow.ShowDialog();
        }
        /// <summary>
        /// Otawrcie okna umozliwiającego wyszukiwanie dokumentu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchAndSaveToFile_Click(object sender, EventArgs e)
        {
            OpenWindow("search");
        }
        /// <summary>
        /// Funkcja obśługująca otwarcie odpowiedniego okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenWindow(string type)
        {
            this.Visible = false;
            documentEditWindow = new DocumentEditWindow(type, this, context, employee);
            documentEditWindow.ShowDialog();
        }
        /// <summary>
        /// Funkcja otwierajaca okno przeglądania dokumentów i zapisu zestawienia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDocuments_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showDocumentsWindow = new ShowDocuments(this, context);
            showDocumentsWindow.ShowDialog();
        }
        /// <summary>
        /// Odmierzanie czasu. Odmierza 1 sekunde. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerClock_Tick(object sender, EventArgs e)
        {
            showActualTime();
        }
        /// <summary>
        /// Dodanie czasu po utworzeniu nagłówka okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            showActualTime();
        }
        /// <summary>
        /// Ustawienie aktualnego czasu w labelu w nagłówku.
        /// </summary>
        private void showActualTime()
        {
            thisDay = DateTime.Now;
            labelActualTime.Text = thisDay.ToString("T");
        }
    }
}
