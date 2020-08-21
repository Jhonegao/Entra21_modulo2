using FormEleicao2OO.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEleicao2OO
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        Candidato c1 = new Candidato();
        Candidato c2 = new Candidato();
        Candidato c3 = new Candidato();
        Eleicao CandidatosListas = new Eleicao();
        public int posicao = -1;
        public void LimparCampos()
        {
            txtNomeCandidato.Clear();
            txtNumeroCandidato.Clear();
            pbFotosCandidatos.Image = null;
            posicao = -1;
        }
        public void ControleBotoes(bool set)
        {
            txtNomeCandidato.Clear();
            txtNumeroCandidato.Clear();
            txtNomeCandidato.Enabled = set;
            txtNumeroCandidato.Enabled = set;
            btnCadastrarNovo.Visible = !set;
            btnAdicionarVotacao.Visible = !set;
            btnCadastroCancel.Visible = set;
            btnCadastroOK.Visible = set;
            btnEscolherImagem.Visible = set;
            pbFotosCandidatos.Image = null;
            //resetando a listagem de amostra para o primeiro item do itendex
            //contadorAuxiliar = -1;
        }
        public int ListarCandidato(bool botaoTipo, int posicao)
        {
            int indexador = CandidatosListas._ListCandidatos.Count();
            if (botaoTipo) { posicao++; } else { posicao--; }
            if (posicao < 0) { posicao = indexador - 1; }
            else if (posicao >= indexador) { posicao = 0; }
            txtNomeCandidato.Text = CandidatosListas._ListCandidatos.ElementAt(posicao).Nome;
            txtNumeroCandidato.Text = CandidatosListas._ListCandidatos.ElementAt(posicao).Numero;
            pbFotosCandidatos.Image = CandidatosListas._ListCandidatos.ElementAt(posicao).Foto;
            return posicao;
        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            //fazer load da pré lista de candidatos
            c1.Nome = "joao";
            c1.Numero = "11";
            c1.Foto = Resources.c1;
            c2.Nome = "kkkkk";
            c2.Numero = "112";
            c2.Foto = Resources.c2;
            c3.Nome = "oooooo";
            c3.Numero = "23";
            c3.Foto = Resources.c3;

            CandidatosListas._ListCandidatos.Add(c1);
            CandidatosListas._ListCandidatos.Add(c2);
            CandidatosListas._ListCandidatos.Add(c3);
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            ControleBotoes(true);
        }
        private void btnCadastroCancel_Click(object sender, EventArgs e)
        {
            ControleBotoes(false);
        }
        private void btnCadastroOK_Click(object sender, EventArgs e)
        {
            Candidato candidatoACadastrar = new Candidato();
            Validators validacoes = new Validators();
            candidatoACadastrar.Nome = txtNomeCandidato.Text;
            candidatoACadastrar.Numero = txtNumeroCandidato.Text;
            candidatoACadastrar.Foto = pbFotosCandidatos.Image;
            string erros = validacoes.Validar(candidatoACadastrar);
            if (erros != "")
            {
                MessageBox.Show(erros);
            }
            else
            {
                ControleBotoes(false);
                CandidatosListas._ListCandidatos.Add(candidatoACadastrar);
            }
        }
        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg) | *.jpg; *.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbFotosCandidatos.Image = new Bitmap(open.FileName);
            }
        }
        private void btnAdicionarVotacao_Click(object sender, EventArgs e)
        {
            if (posicao < 0)
            {
                MessageBox.Show("WORK");
            }
            else
            {
                CandidatosListas._ListElegiveis.Add(CandidatosListas._ListCandidatos.ElementAt(posicao));
                CandidatosListas._ListCandidatos.RemoveAt(posicao);
                LimparCampos();
                if (CandidatosListas._ListElegiveis.Count > 1){ btnIniciarVotacao.Enabled = true; }
                if (CandidatosListas._ListElegiveis.Count >= 10){ btnAdicionarVotacao.Visible = false; }
                lbMaxCandidatos.Text = $"Quantidade atual {CandidatosListas._ListElegiveis.Count} /10 candidatos";
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            posicao = ListarCandidato(true, posicao);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            posicao = ListarCandidato(false, posicao);                              
        }
        private void btnIniciarVotacao_Click(object sender, EventArgs e)
        {

            FormVotos newForm = new FormVotos(CandidatosListas);
            newForm.Visible = true;
            this.Visible = false;
        }
    }
}
