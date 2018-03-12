using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocumentCreator
{
    abstract public class TXTDocument
    {
        /// <summary>
        /// Obsługa zapisu do pliku tekstowego o nazwie fileName w odpowiednim układzie tekstu.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="titleDocument"></param>
        /// <param name="typeNotification"></param>
        /// <param name="clientName"></param>
        /// <param name="clientSurname"></param>
        /// <param name="clientPhoneNumber"></param>
        /// <param name="employeeName"></param>
        /// <param name="employeeSurname"></param>
        /// <param name="itemName"></param>
        /// <param name="brand"></param>
        /// <param name="note"></param>
        /// <param name="logo"></param>
        static public void CreatTXT(string fileName, string titleDocument, string typeNotification, string clientName,
            string clientSurname, string clientPhoneNumber, string employeeName, string employeeSurname, string itemName,
            string brand, string note, System.Drawing.Image logo)
        {
            StreamWriter SW = new StreamWriter(fileName + ".txt");
            SW.WriteLine("Serwis:");
            SW.WriteLine("BestComputerService Sp. z o.o.");
            SW.WriteLine("ul Reja 2");
            SW.WriteLine("50-354 Wrocław");
            SW.WriteLine("Telefon: 899230963");
            SW.WriteLine("");
            SW.WriteLine("Zgłoszenie serwisowe.");
            SW.WriteLine("");
            SW.WriteLine("");
            SW.WriteLine("Tytuł: " + titleDocument);
            SW.WriteLine("");
            SW.WriteLine("Powód zgłoszenia");
            SW.WriteLine(typeNotification);
            SW.WriteLine("");
            SW.WriteLine("Klient");
            SW.WriteLine("Imie: " + clientName);
            SW.WriteLine("Nazwisko: " + clientSurname);
            SW.WriteLine("Nr tel. : " + clientPhoneNumber);
            SW.WriteLine("");
            SW.WriteLine("Pracownik przyjmujący zgłoszenie");
            SW.WriteLine("Imie: " + employeeName);
            SW.WriteLine("Nazwisko: " + employeeSurname);
            SW.WriteLine("");
            SW.WriteLine("Przedmiot zgłoszenia");
            SW.WriteLine("Nazwa: " + itemName);
            SW.WriteLine("Marka: " + brand);
            SW.WriteLine("");
            SW.WriteLine("Uwagi:");
            SW.WriteLine(note);
            SW.Close();
        }

    }
}
