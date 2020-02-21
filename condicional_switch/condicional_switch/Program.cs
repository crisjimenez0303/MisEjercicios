using System;

    class Program
    {
        static void Main(string[] args)
        {
            string monthletras = "";
            int day = 0;
            int month = 0;
            int year = 0;

            Console.WriteLine("escriba su dia de nacimiento ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba su mes de nacimiento ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba su año de nacimiento ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            switch (month)
            { 
                case 1:
                    monthletras = "enero";
                    break;
                case 2:
                    monthletras = "febrero";
                    break;
                case 3:
                    monthletras = "marzo";
                    break;
                case 4:   
                    monthletras = "abril";
                    break;
                case 5:
                    monthletras = "mayo";
                    break;
                case 6:
                    monthletras = "junio";
                    break;
                case 7:
                    monthletras = "julio";
                    break;
                case 8:
                    monthletras = "agosto";
                    break;
                case 9:
                    monthletras = "septiembre";
                    break;
                case 10:
                    monthletras = "octubre";
                    break;
                case 11:
                    monthletras = "noviembre";
                    break;
                case 12:
                    monthletras = "diciembre";
                    break;
                default :
                    monthletras = "error";
                    break;
                       

            }
            if (monthletras == "error")
            {
                Console.WriteLine("la fecha ingresada es incorrecta");
                Console.ReadLine();
             
            
            }
        
            else 
            {
                 Console.WriteLine("usted nacio el dia "+day+" del mes "+monthletras+" del año "+year+".");
                 Console.ReadLine();
            }

         
       }         
  }
    

