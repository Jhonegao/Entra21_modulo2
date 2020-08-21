using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEleicao2OO
{
    public class Eleicao
    {
        public List<Candidato> _ListCandidatos { get; set; }
        public List<Candidato> _ListElegiveis { get; set; }
        public Eleicao()
        {
            _ListCandidatos = new List<Candidato>();
            _ListElegiveis = new List<Candidato>();
        }
    }
}
