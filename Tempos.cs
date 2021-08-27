using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anoteitor
{
    public partial class Tempos : Form
    {
        private INI cIni;
        private int Qtd = 0;

        public Tempos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Qtd; i++)
            {
                string nmProjeto = "Pro" + (i + 1).ToString();
                string Nome = this.cIni.ReadString("NmProjetos", nmProjeto, "");
                this.cIni.WriteInt(Nome, "Tempo", 0);
            }
            Close();
        }

        private void Tempos_Load(object sender, EventArgs e)
        {
            this.cIni = new INI();
            this.Qtd = this.cIni.ReadInt("Projetos", "Qtd", 0);
            for (int i = 0; i < Qtd; i++)
            {
                string nmProjeto = "Pro" + (i + 1).ToString();
                string Nome = this.cIni.ReadString("NmProjetos", nmProjeto, "");
                int QtMinutos = this.cIni.ReadInt(Nome, "Tempo", 0);
                if (QtMinutos>0)
                {
                    int horas = QtMinutos / 60;
                    int min = QtMinutos - (horas * 60);
                    string Tempo = horas.ToString("00") + ":" + min.ToString("00");
                    ListViewItem listViewItem1 = new ListViewItem(new string[] { Nome, Tempo }, -1);
                    this.lvTempos.Items.Add(listViewItem1);

                }
            }
        }
    }
}
