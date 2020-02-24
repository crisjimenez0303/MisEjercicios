using System;


    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            string apellido = "";
            Console.Write("por favor, ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("por favor, ingrese su apellido: ");
            apellido = Console.ReadLine();
            mostrarmensaje(nombre, apellido);
        }
        public static void mostrarmensaje(string nombreusuario, string apellidousuario)
         {
             Console.WriteLine("bienvenido, sr(a). " +
                 nombreusuario + " " + apellidousuario);
             Console.ReadLine();

         }
    }


