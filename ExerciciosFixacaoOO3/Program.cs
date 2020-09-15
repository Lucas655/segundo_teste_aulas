using System;
using System.Globalization;

namespace ExerciciosFixacaoOO3 {
    class Program {
        static void Main(string[] args) {

            //Exercício1
            /*
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.WriteLine("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);
            */

            //Exercício2
            /*
            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            f.AumentaSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: "+f);
           */

            //Exercício2

            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.Write("Nota1: ");
            a.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Nota1: ");
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota1: ");
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a.CalcularNotaFinal() >= 60.0) {
                Console.WriteLine(a);
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine(a);
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram "+a.DiferencaMediaMaximaETirada().ToString("F2",CultureInfo.InvariantCulture)+" Pontos");
            }

        }
    }
}
