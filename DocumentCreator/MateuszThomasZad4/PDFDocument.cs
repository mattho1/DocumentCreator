using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;

namespace DocumentCreator
{
    abstract public class PDFDocument
    {
        /// <summary>
        /// Obsługa zapisu do pliku PDF o nazwie fileName w odpowiednim układzie tekstu.
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
        static public void CreatPDF(string fileName, string titleDocument, string typeNotification, string clientName,
            string clientSurname, string clientPhoneNumber, string employeeName, string employeeSurname, string itemName,
            string brand, string note, System.Drawing.Image logo )
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName + ".pdf", FileMode.Create));
            document.Open();
            AddLogo(logo, document);
            AddInformationAboutService(document);
            AddTitle("Zgłoszenie serwisowe.\n\n\n", document);
            AddTitleDocument("Tytuł: " + titleDocument + "\n\n\n", document);
            AddParagraph("Powód zgłoszenia\n", document);
            AddParagraph(typeNotification + "\n\n\n", document);
            AddParagraph("Klient\n", document);
            AddParagraph("Imie: " + clientName, document);
            AddParagraph("Nazwisko: " + clientSurname, document);
            AddParagraph("Nr tel. : " + clientPhoneNumber + "\n\n\n", document);
            AddParagraph("Pracownik przyjmujący zgłoszenie\n", document);
            AddParagraph("Imie: " + employeeName, document);
            AddParagraph("Nazwisko: " + employeeSurname + "\n\n\n", document);
            AddParagraph("Przedmiot zgłoszenia\n", document);
            AddParagraph("Nazwa: " + itemName, document);
            AddParagraph("Marka: " + brand + "\n\n\n", document);
            AddParagraph("Uwagi: \n" + note, document);
            document.Close();
        }
        /// <summary>
        /// Dodanie do dokumnetu PDF loga firmy.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="document"></param>
        static private void AddLogo(System.Drawing.Image logo, iTextSharp.text.Document document)
        {
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(logo, BaseColor.BLUE);// imageListLogo.Images[0].Clone(); // ;
            PNG.ScaleToFit(100f, 100f);
            PNG.SetAbsolutePosition(document.PageSize.Width - 36f - 72f, document.PageSize.Height - 36f - 100f);
            PNG.Border = iTextSharp.text.Rectangle.BOX;
            document.Add(PNG);
        }
        /// <summary>
        /// Dodanie do dokumentu informacji o serwisie.
        /// </summary>
        /// <param name="document"></param>
        static private void AddInformationAboutService(iTextSharp.text.Document document)
        {
            AddParagraphAboutService("Serwis:",document);
            AddParagraphAboutService("BestComputerService Sp. z o.o.", document);
            AddParagraphAboutService("ul Reja 2", document);
            AddParagraphAboutService("50-354 Wrocław", document);
            AddParagraphAboutService("Telefon: 899230963", document);
        }
        /// <summary>
        /// Funkcja ustawia odpowiedni format tekstu dla paragrafu z informacjami o serwisie.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="document"></param>
        static private void AddParagraphAboutService(string text, iTextSharp.text.Document document)
        {
            var myFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
            Paragraph paragraph = new Paragraph(text, myFont);
            paragraph.Font.Color = iTextSharp.text.BaseColor.BLUE;
            paragraph.Font.Size = 10;
            document.Add(paragraph);
        }
        /// <summary>
        /// Funkcja ustawia odpowiedni format tekstu dla zwykłego paragrafu tekstu.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="document"></param>
        static private void AddParagraph(string text, iTextSharp.text.Document document)
        {
            var myFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
            Paragraph paragraph = new Paragraph(text, myFont);
            paragraph.Font.Size = 14;
            document.Add(paragraph);
        }
        /// <summary>
        /// Funkcja ustawia odpowiedni format tekstu dla nazwy dokumentu.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="document"></param>
        static private void AddTitle(string text, iTextSharp.text.Document document)
        {
            var myFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
            Paragraph paragraph = new Paragraph(text, myFont);
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Font.Size = 24;
            document.Add(paragraph);
        }
        /// <summary>
        /// Funkcja ustawia odpowiedni format tekstu dla tytułu dokumentu.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="document"></param>
        static private void AddTitleDocument(string text, iTextSharp.text.Document document)
        {
            var myFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
            Paragraph paragraph = new Paragraph(text, myFont);
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Font.Size = 18;
            document.Add(paragraph);
        }
    }
}
