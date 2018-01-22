using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ConsoleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string risposta;
            Console.WriteLine("inserisca quante volte vuole far ripetere la risposta");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisca la risposta");           
            risposta = Console.ReadLine();
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0}",risposta);
            }
            Console.ReadLine();
        }
    }
}
