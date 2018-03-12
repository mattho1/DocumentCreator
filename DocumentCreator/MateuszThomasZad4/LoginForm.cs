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
using System.Security.Cryptography;
using System.IO;

namespace DocumentCreator
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Referencja do okna głównego.
        /// </summary>
        MainForm mainForm;
        /// <summary>
        /// Zaszyfrowane hasło podane przez użytkownika programu.
        /// </summary>
        EncryptedWord password;
        /// <summary>
        /// Liczba prób logowania do zablokowania dostepu.
        /// </summary>
        int numberOfLoginAttempts;
        /// <summary>
        /// Połaczenie z bazą danych.
        /// </summary>
        DataClassesDatabaseDataContext context;
        /// <summary>
        /// Komunikat wyswietlany użytkownikowi.
        /// </summary>
        MessageWindow message;
        /// <summary>
        /// Zalogowany pracownik.
        /// </summary>
        User employee;
        public LoginForm(DataClassesDatabaseDataContext context, MainForm mainForm)
        {
            this.context = context;
            this.mainForm = mainForm;
            message = new MessageWindow();
            numberOfLoginAttempts = 3;
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// Obsługa kliknięcia przycisku zaloguj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (!textBoxLogin.Text.Equals("") && !textBoxPassword.Text.Equals(""))
            {
                password = new EncryptedWord(textBoxPassword.Text);
                if (FindUserWithGivenPassword())
                {
                    CorrectLogin();
                }
                else
                {
                    IncorrectPassword();
                }
            }
        }
        /// <summary>
        /// Funkcja wyszukuje w bazie danych użytkownika o podanym haśle i zwraca go.
        /// Gdy użytkownik zostanie znaleziony zostanei zapisane jego nazwisko.
        /// Sprawdza czy login jest poprawny.
        /// </summary>
        private bool FindUserWithGivenPassword()
        {
            User foundUser = (from user in context.Users where user.Password.Password1 == password.word && user.Login == textBoxLogin.Text select user).FirstOrDefault();
            employee = foundUser;
            if (foundUser != null)
            {
                return true;
            }
            else
            {
                message.SetMessage("Niepoprawny login.");
                message.ShowDialog();
                return false;
            }
        }
        /// <summary>
        /// Funkcja wywoływana po stwierdzeniu podania niepoprawnych danych logowania.
        /// Obsługuje sprawdzenie ile bło prób niepoprawnego logowania.
        /// Zapobiega próbie niedozwolonemu dostępowi metodą siłową.
        /// </summary>
        private void IncorrectPassword()
        {
            numberOfLoginAttempts--;
            if (numberOfLoginAttempts > 0)
            {
                message.SetMessage("Niepoprawne dane logowania.\nPozostały " + numberOfLoginAttempts + " próby logowania.");
                message.ShowDialog();
            }
            else
            {
                message.SetMessage("Przekroczono limit nieporawnych prób logowania.");
                message.ShowDialog();
                mainForm.Close();
                Environment.Exit(0);
                //mainForm.dataFromLoginWindow(false, "brak");
            }
        }
        /// <summary>
        /// Funkcja wywoływana po stwierdzeniu podania poprawnych danych logowania. 
        /// Kończy działanie okna i zwraca wynik oknu głównemu.
        /// </summary>
        private void CorrectLogin()
        {
            mainForm.Visible = true;
            mainForm.dataFromLoginWindow(true, employee);
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
        /// Obsługa przycisku zamykającego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonExit_Click(object sender, EventArgs e)
        {
            mainForm.Close();
            Environment.Exit(0);
        }
    }
}
