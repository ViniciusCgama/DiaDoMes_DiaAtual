using System;

namespace Aula01_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {      
          concatenarPalavras(); 
          verAula(); 
        }

        public static void concatenarPalavras()
        {         

            string nome = Console.ReadLine();

            string frase1 = $"{DateTime.Now}";

            Console.WriteLine( );
            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
        }
        public static void verAula()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei execícios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra ETEC!");
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information

