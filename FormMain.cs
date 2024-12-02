using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cretaceous_Browser__Official_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            // Set my initial URL to start
            textBoxURL.Text = "https://www.nhm.ac.uk/discover/dino-directory.html";
            // Here we acutomatically go to it.
            webBrowserDisplayPage.Navigate(textBoxURL.Text);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the user clicks the Go button, this will run the code below to navigate to a webpage using the
        /// URL in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonGo_Click(object sender, EventArgs e)
        {
            // This will run the code below to naviagte to a web page using the
            /// URL in the textbox
            webBrowserDisplayPage.Navigate(textBoxURL.Text);
            // So we don't have to manually intercept all errors use this
            webBrowserDisplayPage.ScriptErrorsSuppressed = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
