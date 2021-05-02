using System;

namespace CanviaPruebaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ejercicio1 _ejer1= new Ejercicio1();
            _ejer1.Ejecutar( new string[] { "NNYN", "NNYN", "NNNN", "NYYN" });

            _ejer1 = new Ejercicio1();
            _ejer1.Ejecutar(new string[] { "N"});


            string respuesta;
            Ejercicio2 _ejer2 = new Ejercicio2();
            respuesta = _ejer2.canObtain("B", "ABBA");
            Console.WriteLine(respuesta);
            respuesta = _ejer2.canObtain("AB", "ABB");
            Console.WriteLine(respuesta);
            respuesta = _ejer2.canObtain("BBAB", "ABABABABB");
            Console.WriteLine(respuesta);
            respuesta = _ejer2.canObtain("BBBBABABBBBBBA", "BBBBABABBABBBBBBABABBBBBBBBABAABBBAA");
        }



       
    }
}
