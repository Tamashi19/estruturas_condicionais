using System;

namespace idade_em_semanas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque seu ano de nascimento:");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque seu mes de nascimento:");
            int mesDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque seu dia de nascimento:");
            int diaDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o ano de hoje:");
            int anoDeHoje = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o mes de hoje:");
            int mesDehoje = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o dia de hoje:");
            int diaDeHoje = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu ano de nascimento é: " + anoDeNascimento);
            Console.WriteLine("Seu mes de nascimento é: " + mesDeNascimento);
            Console.WriteLine("Seu dia de nascimento é: " + diaDeNascimento);
        


            // NÃO FEZ ANIVERSARIO
            
            if (mesDeNascimento>mesDehoje )
            {
              int ano = anoDeHoje - anoDeNascimento -1;  

              Console.WriteLine("Você tem: " + ano + " anos" );
             
              int semana = ano*52177457;

                   Console.WriteLine("Você tem: " + semana + " semanas" );

           
            }

            // JA FEZ ANIVERSARIO

            else
            {
                int ano = anoDeHoje - anoDeNascimento ;
                
                 Console.WriteLine("Você tem: " + ano + " anos" );
                 
                  int semana = ano*52177457;

                   Console.WriteLine("Você tem: " + semana + " semanas" );

                  
                  
            }



        }
    }
}
