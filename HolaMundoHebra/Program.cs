using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaMundoHebra
{
    class Program
    {
        static void ejecutar()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hola Mundo desde hebra {0}", i , Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Esto esta antes de la hebra");
            Thread t = new Thread(new ThreadStart(ejecutar));
            t.Name = "Hebra de Arturo";
            t.Start();
            Thread t2 = new Thread(new ThreadStart(ejecutar));
            t2.Name = "Hebra de Maria";
            t2.Start();

            Console.WriteLine("Esto se esta ejecutando despues de la hebra");
            Console.ReadKey();
        }
    }
}
