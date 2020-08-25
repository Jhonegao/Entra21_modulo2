using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEleicao2OO
{
    public class Eleicao
    {
        public List<Candidato> _ListCandidatos { get; private set; }
        public List<Candidato> _ListElegiveis { get; private set; }
        public Eleicao()
        {
            this._ListCandidatos = new List<Candidato>();
            this._ListElegiveis = new List<Candidato>();
        }

        public void CadastrarCandidato(Candidato candidatoCadastrado)
        {

        }

        public void AdicionarEleicao(Candidato cancidatoElegivel)
        {

        }
    }
}