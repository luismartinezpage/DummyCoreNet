using System;

namespace DummyCoreNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            Console.WriteLine("¿Cuál es tu nombre?");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("mmm.... porque no quieres poner tu nombre? :) ");
            }
            else
            {
                Console.WriteLine(string.Format("Hola {0}, que tengas un buen día", name));
            }

            Console.WriteLine("<pulsa cualquier tecla para salir.");
            Console.ReadKey();
            
        }
    }
}
