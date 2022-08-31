using Prova2;
using System;
namespace ProgramaPrincipal
{
    class program
    {
        public static void Main(string[] args)
        {
            //Vou pegar todas as informações do aluno.
            Console.WriteLine("Informe o Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a Idade: ");
            int.TryParse(Console.ReadLine(), out int idade);
            Console.WriteLine("Informe a escola: ");
            string escola = Console.ReadLine();
            var aluno = new CadastroAluno(nome, idade, escola);//Construtor com 3 atributos, que vai receber os dados salvos nas varíaveis acima.
            Console.WriteLine("--------------------");
            




            double media = 0.0;//Criado uma variavel do tipo double media, que vai receber o valor 0, criada fora do repetidor for, para ser usada fora do escopo de for,caso precise. 
            for(int i = 1; i<= 3; i++)//Aqui está dizendo basicamente para repetir 3 vezes. 
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
                //Depois de somar tudo e dividir e pegar a média do primeiro bimestre, vai jogar para o construtor Medias, lá na classe CadastroAluno, que vai repassar todas as vezes o valor da media do bimestre para que seja somada com a próxima.
                aluno.Medias(media);//Enviado o valor de media para o método poder somar e guardar no atributo da classe.

                
            }


            Console.WriteLine($"{aluno.Nome}, {aluno.Idade} anos, estuda na escola {aluno.Escola}.");//Mostra os dados
            Console.WriteLine(aluno);//Aqui como já foi formatado com tostring dentro da classe, então não precisa formatar aqui também. Apenas chamamos o objeto que está utilizando os dados da classe.












        }



    }



}
