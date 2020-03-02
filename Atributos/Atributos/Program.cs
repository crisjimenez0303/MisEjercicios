using System;


namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aprendiz apSena = new Aprendiz();
            apSena.Nombres = "cristian camilo";
            apSena.Apellidos = "jimenez torres";
            apSena.DepartamentoDeResidencia = "pitalito";
            saludo(apSena);
        }
        private static void saludo(Aprendiz apSena)
        {
            Console.WriteLine("Bienvenido Sr.(a)" + apSena.Nombres +" "+ apSena.Apellidos + ", usted vive en: "+ apSena.DepartamentoDeResidencia);
            Console.ReadLine();
        }
    }
}
