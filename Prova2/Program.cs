using Prova2;
using System;
namespace ProgramaPrincipal
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a Idade: ");
            int.TryParse(Console.ReadLine(), out int idade);
            Console.WriteLine("Informe a escola: ");
            string escola = Console.ReadLine();
            var aluno = new CadastroAluno(nome, idade, escola);
            Console.WriteLine("--------------------");
            




            double media = 0.0;
            for(int i = 1; i<= 3; i++)
            {
                Console.WriteLine($"Informe as notas do {i}º Bimestre:  ");
                Console.WriteLine("Informe a nota do aluno em Matemática: ");
                double.TryParse(Console.ReadLine(), out double notaMat);

                Console.WriteLine("Informe a nota do aluno em Português: ");
                double.TryParse(Console.ReadLine(), out double notaPort);

                Console.WriteLine("Informe a nota do aluno em Ciências: ");
                double.TryParse(Console.ReadLine(), out double notaCiencias);

                Console.WriteLine("Informe a nota do aluno em Geografia: ");
                double.TryParse(Console.ReadLine(), out double notaGeo);

                Console.WriteLine("Informe a nota do aluno em História: ");
                double.TryParse(Console.ReadLine(), out double notaHist);

                Console.WriteLine("Informe a nota do aluno em Educação Física: ");
                double.TryParse(Console.ReadLine(), out double notaEdFisica);

                Console.WriteLine("Informe a nota do aluno em Ensino Religioso: ");
                double.TryParse(Console.ReadLine(), out double notaEnsReligioso);

                Console.WriteLine("Informe a nota do aluno em Inglês: ");
                double.TryParse(Console.ReadLine(), out double notaIngles);

                Console.WriteLine("Informe a nota do aluno em Artes: ");
                double.TryParse(Console.ReadLine(), out double notaArtes);
                media = ((notaMat + notaPort + notaCiencias + notaGeo + notaHist + notaEdFisica + notaEnsReligioso + notaIngles + notaArtes) / 9.0) / 10.0;
                aluno.Medias(media);
                
            }


            Console.WriteLine($"{aluno.Nome}, {aluno.Idade} anos, estuda na escola {aluno.Escola}.");
            Console.WriteLine(aluno);












        }



    }



}
