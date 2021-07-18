using System;
using System.Windows.Forms;

namespace Anoteitor
{
    public partial class ConfigProjeto : Form
    {
        private INI cIni;

        public ConfigProjeto()
        {
            InitializeComponent();
        }

        private void ConfigProjeto_Load(object sender, EventArgs e)
        {
            cIni = new INI();
            string Pasta = cIni.ReadString("Projetos", "Pasta", "");
            textBox1.Text = Pasta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show(this, "É necessário informar o caminho do projeto", "Anoteitor");
            }
            else
            {
                string Pasta = textBox1.Text;
                bool SalvarAuto = (ckSalvar.Checked = true);
                cIni.WriteBool("Projetos", "SalvarAut", SalvarAuto);
                cIni.WriteString("Projetos", "Pasta", Pasta);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
