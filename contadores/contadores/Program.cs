using System;




    class Program
    {
        static void Main(string[] args)
        {
            string producto = "";
            int numeracion = 1;
            Console.Write("ingrese nombre del producto: ");
            producto=Console.ReadLine();
            while (producto != "TERMINAR")
            {
                Console.WriteLine("producto No " + numeracion + ".");
                Console.WriteLine("producto es: " + producto + ".");
                Console.WriteLine();
                Console.Write("por favor, ingrese otro producto: ");
                producto= Console.ReadLine ();
                numeracion += 1;
            }
            Console.WriteLine("fin del programa");
            Console.ReadLine();
        }
    }
