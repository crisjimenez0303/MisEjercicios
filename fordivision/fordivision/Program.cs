﻿using System;


    class Program
    {
        static void Main(string[] args)
        
        {

            string[] aprendices = new string[3];
            
            
            for (int apr = 0; apr <= 2; apr++)
            {
                Console.WriteLine("Por favor, ingrese el aprendiz N. " + (apr + 1)+ ": ");
                aprendices[apr] = Console.ReadLine();
            }
            for (int apr = 0; apr <= 2; apr++)
            {
                Console.Write((apr+1) + ". "+ aprendices[apr]);
                Console.ReadLine();
            }

            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }

