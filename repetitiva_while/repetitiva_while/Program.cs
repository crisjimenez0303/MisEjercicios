using System;


    class Program
    {
        static void Main(string[] args)
        {
            string nombreUsuario = "";
            Console.Write("por favor, ingrese su nombre: ");
            nombreUsuario = Console.ReadLine();
            while(nombreUsuario != "FIN")
            { Console.WriteLine ("Bienvenido, Sr(a) " + nombreUsuario +"."); 
              Console.WriteLine ("");
              Console.Write("por favor, ingrese su nombre: ");
              nombreUsuario= Console.ReadLine();
              
            }
            Console.WriteLine("fin del programa");
            Console.ReadLine();

        }
    }
