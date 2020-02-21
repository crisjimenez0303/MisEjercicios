using System;



    class Program
    {
        static void Main(string[] args)
        {
            string nombreUsuario = "";

            Console.Write("por favor, ingrese su nombre: ");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("bienvenido(a), 
            " + nombreUsuario + ".");
            Console.ReadLine();
        }
    }

