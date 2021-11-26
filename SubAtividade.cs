using System;
using System.Windows.Forms;

namespace Anoteitor
{
    public partial class SubAtividade : Form
    {
        private string Atividade = "";
        private string NomeSubAtividade = "";
        private int QtdSub = 0;
        public SubAtividade(string Ativ)
        {
            InitializeComponent();
            this.Atividade = Ativ;
            this.lbAtividade.Text = "Atividade: " + Ativ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Grava();
        }

        private void Grava()
        {
            this.NomeSubAtividade = txSub.Text;
            INI cIni = new INI();
            this.QtdSub = cIni.ReadInt(this.Atividade, "QtdSub", 0) + 1;
            cIni.WriteInt(this.Atividade, "QtdSub", this.QtdSub);
            cIni.WriteString(this.Atividade, ("Sub"+ this.QtdSub.ToString()), this.NomeSubAtividade);
            cIni.WriteString(this.Atividade, "SubAtual", this.NomeSubAtividade);
            this.DialogResult = DialogResult.OK;
            Close();
        }
        public string Nome()
        {
            return this.NomeSubAtividade;
        }

        private void txSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.Grava();
        }

        public int getQtdSub()
        {
            return this.QtdSub;
        }
    }
}
