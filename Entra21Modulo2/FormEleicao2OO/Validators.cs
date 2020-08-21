using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEleicao2OO
{
    class Validators
    {
        private string ValidarNome(string nome)
        {
            string erros = "";
            if (string.IsNullOrWhiteSpace(nome))
            {
                erros += "Nome deve ser informado";
            }
            else if (nome.Length < 3 || nome.Length > 70)
            {
                erros += "O nome deve conter de 3 a 70 caracteres";
            }
            for (int i = 0; i < nome.Length; i++)
            {
                if (!char.IsLetter(nome[i]) && nome[i] != ' ')
                {
                    erros += "O nome deve conter carateres válidos";
                    break;
                }
            }
            return erros;
        }
        private string ValidarNumero(string num)
        {
            string erros = "";
            if (string.IsNullOrWhiteSpace(num))
            {
                erros += "Numero deve ser informado";
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (char.IsLetter(num[i]) && num[i] != ' ')
                {
                    erros += "Apenas numeros";
                    break;
                }
            }
            return erros;
        }
        private string VerificarImagem (Image check)
        {
            string erros = "";
            if (check == null)
            {
                erros += $"Selecione uma imagem";
            }
            return erros;
        }
        public string Validar(Candidato candidato)
        {
            string erros = ValidarNome(candidato.Nome);
            erros += ValidarNumero(candidato.Numero);
            erros += VerificarImagem(candidato.Foto);
            return erros;
        }
    }
}
