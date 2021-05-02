using System;
using System.Collections.Generic;
using System.Text;

namespace CanviaPruebaTecnica
{
    public class Ejercicio1
    {
        string[] cadena;
        public Ejercicio1()
        {
            //cadena = new string[] { "NNYN", "NNYN", "NNNN", "NYYN" };
            //Console.WriteLine($"Cadena: {cadena}");
        }

        public void Ejecutar(string [] _cadena )
        {
            cadena = _cadena;
            int sum = 0;
            int indice = 0;

            while (indice < cadena.Length)
            {
                int subsuma = 0;
                subsuma = BuscarSubordinados(cadena, indice, 0);
                indice++;
                sum += subsuma;
            }


            //sum = Calculo2(e1, 0, 0);
            Console.WriteLine($"Suma Total : {sum}");
        }
        private int BuscarSubordinados(string[] cadena, int indice, int acumulado)
        {
            if (indice >= cadena.Length)
            {
                return acumulado == 0 ? 1 : acumulado;
            }

            for (int i = 0; i < cadena[indice].Length; i++)
            {
                if (cadena[indice][i] == 'Y')
                {
                    acumulado += BuscarSubordinados(cadena, i, acumulado);
                }
            }

            return acumulado == 0 ? 1 : acumulado;


        }
    }
}
