using System;

namespace NEW_CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double num1 ;
            Console.WriteLine("Ingrese un valor : ");
            num1 = double.Parse(Console.ReadLine());
            var elBaio = new Calculadora();
            var resultado = elBaio.Sumar (num1, 3);
            resultado=elBaio.Restar(resultado, 3);
            resultado=elBaio.Raiz(resultado);
            resultado=elBaio.Dividir(resultado, 2);
            resultado=elBaio.Multiplicar(resultado, 4);
            Console.WriteLine("El resultado de la operacion es : " + resultado);
            Console.ReadKey();
        }
    }
}
    

