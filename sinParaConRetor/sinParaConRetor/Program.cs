using System;


    class Program
    {
        static decimal PrecioProducto = 0; 
        static decimal PrecioProductoConIva = 0;
        static int CategoriaProducto = 0;        
        static void Main(string[] args)
             
        {   
           
            Console.WriteLine("por favor, ingrese el costo del producto: ");
            decimal.TryParse(Console.ReadLine(), out PrecioProducto);
            Console.WriteLine("por favor, ingrese la categoria del producto: ");
            Int32.TryParse(Console.ReadLine(), out CategoriaProducto);

            if (CategoriaProducto == 1)
            {
                PrecioProductoConIva = porcentaje0();
                Console.WriteLine("el precio del producto es: " +
               "con Iva es: {0:C}", PrecioProductoConIva);
            }
            
            if (CategoriaProducto == 2)
            {
                PrecioProductoConIva = porcentaje5();
                Console.WriteLine("el precio del producto es: " +
               "con Iva es: {0:C}", PrecioProductoConIva);
            }
            
             if (CategoriaProducto == 3)
            {
                PrecioProductoConIva = porcentaje10();
                Console.WriteLine("el precio del producto es: " +
               "con Iva es: {0:C}", PrecioProductoConIva);
            }
            
            if (CategoriaProducto == 4)
            {
                PrecioProductoConIva = porcentaje19();
                Console.WriteLine("el precio del producto es: " +
               "con Iva es: {0:C}", PrecioProductoConIva);
            }
            Console.ReadLine();
        }
        public static decimal porcentaje0()
        {
            decimal aux = 0.0M;
            PrecioProducto += PrecioProducto * aux;
            return PrecioProducto;
        }
        public static decimal porcentaje5()
        {
            decimal aux = 0.05M;
            PrecioProducto += PrecioProducto * aux;
            return PrecioProducto;
        }
        public static decimal porcentaje10()
        {
            decimal aux = 0.10M;
            PrecioProducto += PrecioProducto * aux;
            return PrecioProducto;
        }
        public static decimal porcentaje19()
        {
            decimal aux = 0.19M;
            PrecioProducto += PrecioProducto * aux;
            return PrecioProducto;
        }
        
    }
