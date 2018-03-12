using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentCreator
{
    public partial class MessageWindow : Form
    {
        public MessageWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Obsługa potwierdzajacego zapoznanie się z komunikatem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Ustawienie podanej wiadomości w komunikacie.
        /// </summary>
        /// <param name="message"></param>
        public void SetMessage(string message)
        {
            labelNews.Text = message;
        }
    }
}
