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
    public partial class FormVotos : Form
    {
        public FormVotos(Eleicao elegiveis)
        {
            InitializeComponent() ;
            List<Candidato> listacandi = elegiveis._ListElegiveis;
        }
        TelaInicial TelaInicial = new TelaInicial();
        public void teste()
        {
            
        }
    }
}
