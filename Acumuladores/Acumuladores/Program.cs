using System;




    class Program
    {
        static void Main(string[] args)

        {
            string respuesta= "";
            int valorproducto = 0;
            int cantidad = 0;
            int noproducto=0;
            int totalproducto=0;
            int valortotal=0;



            Console.WriteLine("desea hacer una compra. SI/NO");
            respuesta = (Console.ReadLine());

            while (respuesta == "SI")
            {
                noproducto++;

                Console.WriteLine("ingrese el valor del producto N." + noproducto + ".");
                valorproducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());
                totalproducto = valorproducto * cantidad;
                valortotal += totalproducto;
               
                Console.WriteLine("desea hacer mas compras. SI/NO");
                respuesta = (Console.ReadLine());
                
            }
            Console.WriteLine("el valor total de la compra es: "+ valortotal
                +".");
            Console.ReadLine();
         }

    }

