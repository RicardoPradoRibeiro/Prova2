using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class CadastroAluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Escola { get; set; }

        public double Media { get; set; }

        public CadastroAluno()
        {
        }

        public CadastroAluno(string nome, int idade, string escola)
        {
            Nome = nome;
            Idade = idade;
            Escola = escola;
        }

        public double Medias(double media)
        {   
            Media += media;
            return Media;


        }
        
        
        public double NotaFinal()
        {
            return Media / 3.0;



        }

        public override string ToString()
        {
            return "Media final: " + NotaFinal().ToString("F1", CultureInfo.InvariantCulture);
        }










    }










}

