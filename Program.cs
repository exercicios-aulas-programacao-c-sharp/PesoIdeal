using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            string sexo;
            double pesoIdeal;

            Console.Write("Digite sua altura em m:\t");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sexo [M]asculino | [F]eminino:\t");
            sexo = Console.ReadLine().ToUpper();
            
            if(sexo == "M")
            {
                pesoIdeal = altura * 72.7 - 58.0;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg");
            }
            else if(sexo == "F")
            {
                pesoIdeal = altura * 62.1 - 44.7;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg");
            }
            else
            {
                Console.WriteLine("O sexo informado é inválido");
            }
        }
    }
}
