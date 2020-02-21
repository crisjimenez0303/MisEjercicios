using System;


    class Program
    {
        static void Main(string[] args)
        {
            string[] operacion = new string[5];
            operacion[0] = ("SUMA");
            operacion[1] = "RESTA";
            operacion[2] = "MULTIPLICACION";
            operacion[3] = "DIVISION";
            operacion[4] = "ERROR";
            string usurespuesta;
            int num1 = 0;
            int num2 = 0;
            int num = 0;
            int opcion =0;

            Console.WriteLine("desea realizar una operacion:  Y/N ");
            usurespuesta = Console.ReadLine();
            while (usurespuesta == "Y") 
            {
                Console.WriteLine("ingrese el primer numero: ");
                num1 = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                for (int oper = 0; oper < 4; oper++)
                {                                      
                    Console.WriteLine((oper + 1)+ "-" + operacion[oper]);

                }
                Console.WriteLine("seleccione la operacion que desea realizar: ");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                { 
                    case 1: Console.WriteLine("LA OPERACION SELECCIONADA ES SUMA");                       
                   opcion= num1 + num2;
                   Console.WriteLine(num1 + "+" + num2 + " = " + opcion + ".");
                   break;
                    case 2: Console.WriteLine("LA OPERACION SELECCIONADA ES RESTA");                  
                   opcion = num1 - num2;
                   Console.WriteLine(num1 + " - " + num2 + " = " + opcion + ".");
                   break;
                    case 3: Console.WriteLine("LA OPERACION SELECCIONADA ES MULTIPLICACION");
                  opcion = num1 * num2;
                  Console.WriteLine(num1 + " * " + num2 + " = " + opcion + ".");
                   break;
                    case 4: Console.WriteLine("LA OPERACION SELECCIONADA ES DIVISION");                   
                   opcion = num1 / num2;
                   Console.WriteLine(num1 + " / " + num2 + " = " + opcion + ".");
                   break;
                    case 5:
                    default:
                     Console.WriteLine("ha seleccionado la opcion incorrecta: " );
                   break;

                 
                }

               
                Console.WriteLine("desea realizar otra operacion:  Y/N ");
                usurespuesta = Console.ReadLine();
                           
            }





        }
    }

