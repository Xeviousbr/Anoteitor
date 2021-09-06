using System;
using System.Windows.Forms;

namespace Anoteitor
{
    public partial class ConfigProjeto : Form
    {
        private INI cIni;
        private bool CopiaOutroDia = false;
        private bool SalvarAuto = true;

        public ConfigProjeto()
        {
            InitializeComponent();
        }

        private void ConfigProjeto_Load(object sender, EventArgs e)
        {
            cIni = new INI();
            string Pasta = cIni.ReadString("Projetos", "Pasta", "");
            textBox1.Text = Pasta;
            ckSalvar.Checked = cIni.ReadBool("Projetos", "SalvarAut", false);
            txSegundos.Enabled = ckSalvar.Checked;
            ckUmDiaOutro.Checked = cIni.ReadBool("Projetos", "CopiaOutroDia", false);
            txSegundos.Text = cIni.ReadInt("Projetos", "Segundos", 2).ToString();
            ckMedeTempos.Checked = cIni.ReadBool("Projetos", "MedeTempos", false);
            txLimCombo.Text = cIni.ReadInt("Projetos", "LimArqs", 31).ToString();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show(this, "É necessário informar o caminho do projeto", "Anoteitor");
            else
            {
                string Pasta = textBox1.Text;
                int Segundos = 0;
                int LimCombo = 0;
                int.TryParse(txLimCombo.Text, out LimCombo);
                int.TryParse(txSegundos.Text, out Segundos);
                LimCombo = LimCombo < 3 ? 2 : LimCombo;
                Segundos = Segundos > 0 ? Segundos : 2;
                cIni.WriteBool("Projetos", "SalvarAut", SalvarAuto);
                cIni.WriteString("Projetos", "Pasta", Pasta);
                cIni.WriteBool("Projetos", "CopiaOutroDia", this.CopiaOutroDia);                
                cIni.WriteInt("Projetos", "Segundos", Segundos);
                cIni.WriteBool("Projetos", "MedeTempos", ckMedeTempos.Checked);
                cIni.WriteInt("Projetos", "LimArqs", LimCombo);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void ckUmDiaOutro_CheckedChanged(object sender, EventArgs e)
        {
            if (ckUmDiaOutro.Checked)
                this.CopiaOutroDia = true;
            else
                this.CopiaOutroDia = false;            
        }

        private void ckSalvar_CheckedChanged(object sender, EventArgs e)
        {
            SalvarAuto = ckSalvar.Checked;
            txSegundos.Enabled = SalvarAuto;
        }

        private void txSegundos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
