using System;

namespace __30__de_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu salario:");
            int salario = int.Parse(Console.ReadLine());

            if (salario>500)
            {
                Console.WriteLine("Desculpe, seu salario não atende os requisitos para o aumento");
                
            }

            else
            {
                Console.WriteLine("Seu salario atende os requisitos para o aumento");
                int por100= salario*100+(30*salario*100)/100;
                int aumento= por100/100;
                Console.WriteLine("Seu salario agora é de: " +aumento);
            }
            
        }
    }
}
