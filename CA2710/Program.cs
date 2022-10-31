using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2710
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            string nome;
            string sobrenome;
            a = 10;
            b = 11.5;
            nome = "Pato Donald";
            // aqui vai o comentario
            /*
           Aqui vai um comentario loooongo
           com varias linhas de comentarios.
             */
            Console.WriteLine("digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(nome+" "+sobrenome);
            Console.ReadKey();
        }
    }
}
