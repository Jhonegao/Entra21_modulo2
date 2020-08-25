using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEleicao2OO
{
    public partial class FormVotos : Form
    {
        public FormVotos(Eleicao elegiveis)
        {
            InitializeComponent();
            this.dgElegiveis.DataSource = elegiveis._ListElegiveis;
            dgElegiveis.Columns["Foto"].Visible = false;
            //dgElegiveis.Columns["QuantidadeVotos"].Visible = false;
        }
        Candidato candidatoASerVotado = new Candidato();

        public void AtualizarLabels(Candidato c, bool tipo, bool limparTxt = false)
        {
            lbNomeCandidatoVotado.Text = c.Nome;
            pbVotacaoImagem.Image = c.Foto;
            cbConfirma.Visible = tipo;
            btnVotar.Enabled = tipo;
            if (limparTxt)
            {
                txtEntradaNum.Clear();
                cbConfirma.Checked = tipo;
            }
        }
        private void txtEntradaNum_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linhaItem in dgElegiveis.Rows)
            {
                if (txtEntradaNum.Text == linhaItem.Cells["Numero"].Value.ToString())
                {
                    candidatoASerVotado = linhaItem.DataBoundItem as Candidato;
                    AtualizarLabels(candidatoASerVotado, true);
                    return;
                }
                else
                {
                    AtualizarLabels(candidatoASerVotado = new Candidato(), false);
                }
            }
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (cbConfirma.Checked)
            {
                candidatoASerVotado.QuantidadeVotos++;
                AtualizarLabels(candidatoASerVotado = new Candidato(), false, true);
            }
            else
            {
                MessageBox.Show("Necessario Confirmacao");
            }
        }
    }
}
