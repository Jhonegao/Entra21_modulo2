﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace FormEleicao2OO
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public Image Foto { get; set; }
        public int QuantidadeVotos { get; set; } 
        
        public Candidato(string nome,string numero, Image foto)
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Foto = foto;
        }
        public Candidato()
        {

        }
    }
}
