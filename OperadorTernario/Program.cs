using System;

namespace OperadorTernario
{
    class Program
    {   
        private static void Main(string[] args)
        {
            string resultado;
            int valor1 = 10;
            int valor2 = 6;

            resultado = (valor1 > valor2) ? "Valor verdadero" : "Valor Falso";

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}