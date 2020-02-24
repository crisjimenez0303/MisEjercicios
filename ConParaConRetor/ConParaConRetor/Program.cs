using System;


    class Program
    {
        static void Main(string[] args)
        {
            int numeronotas = 0;
            Console.WriteLine("===NOTAS===");
            Console.WriteLine("ingrese el numero de notas: ");
            Int32.TryParse(Console.ReadLine(), out numeronotas);
            string resultado = calcularnotas(numeronotas);
        }
        public static string calcularnotas(int numeronotas)
        {   
            
            decimal nota = 0;
            decimal sumanotas = 0;
            for (int i = 1; i <= numeronotas; i++)
            {
                Console.Write("ingrese la nota N. " + i +": ");
                decimal.TryParse(Console.ReadLine(), out nota);
                sumanotas +=  nota/numeronotas;

                
            }
            Console.WriteLine("su promedio es = {0:F2} ", sumanotas);

            
            if (sumanotas >= 6)
            {
                Console.WriteLine("APROBADO");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("REPROBADO");
                Console.ReadLine();
            }
            return "";
        }
    }

