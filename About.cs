using System;
using System.Windows.Forms;

namespace Anoteitor
{
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            Close();
        }

        private void controlSimplyGoodCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://forum.intonses.com.br/viewtopic.php?f=43&t=292840");
        }

        private void About_Load(object sender, EventArgs e)
        {
            label4.Text = "Versão: " + Application.ProductVersion;
        }
    }
}
