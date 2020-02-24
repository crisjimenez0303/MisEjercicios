using System;


    class Program
    {
        static void Main(string[] args)
        {
                   
            calculadora();
        }
        public static void calculadora()
        {
            int operacion = 0;
            Console.WriteLine("ingrese la operacion" );
            Console.WriteLine("1 - SUMA");
            Console.WriteLine("2 - RESTA");
            Console.WriteLine("3 - MULTIPLICACION");
            Console.WriteLine("4 - DIVISION");
            

            Int32.TryParse(Console.ReadLine(), out operacion);
            switch (operacion)
            {
                case 1: Console.WriteLine("LA OPERACION SELECCIONADA ES SUMA"); 
                    suma();
                    break;
                case 2: Console.WriteLine("LA OPERACION SELECCIONADA ES RESTA");
                    resta();
                    break;
                case 3: Console.WriteLine("LA OPERACION SELECCIONADA ES MULTIPLICACION");
                    multiplicacion();
                    break;
                case 4: Console.WriteLine("LA OPERACION SELECCIONADA ES DIVISION"); 
                    division();
                    break;
                default:
                    Console.WriteLine("ha seleccionado la opcion incorrecta: ");
                    break;
            }
            finejer();
        } 
        public static void suma()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 =0;
            Console.WriteLine("ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
        public static void resta()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 - num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
        public static void multiplicacion()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 * num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
        public static void division()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 / num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
        public static void finejer()
        {
            string respuesta = "";
            Console.WriteLine("desea realizar una operacion:  Y/N ");
            respuesta = Console.ReadLine();
            if (respuesta == "Y")
            {
                calculadora();
            }
            else
            {
                Console.WriteLine("Fin del ejercicio");
                Console.ReadLine();
            }

        }


     }

