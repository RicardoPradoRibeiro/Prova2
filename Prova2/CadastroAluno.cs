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

        public CadastroAluno()//Construtor padrão
        {
        }

        public CadastroAluno(string nome, int idade, string escola)//Construtor com 3 atributos. 
        {
            Nome = nome;
            Idade = idade;
            Escola = escola;
        }

        public double Medias(double media)//Método que vai armazenar e somar com os valores que for repassado lá do repetir for, para cada bimestre.
        {   
            Media += media; // Media(atributo da classe) Recebe media(Variável criada nesse método, recebido lá do programa principal) + Media(Atributo da classe)
            return Media;//E retorna esse valor para Média(Atributo da classe).


        }
        
        
        public double NotaFinal()//Faz a divisão de todas as notas e da o resultado final.
        {
            return Media / 3.0;



        }

        public override string ToString()//Formatação da classe, para quando chamado o objeto criado lá no programa principal, informe esses dados. 
        {
            return "Media final: " + NotaFinal().ToString("F1", CultureInfo.InvariantCulture);
        }










    }










}

