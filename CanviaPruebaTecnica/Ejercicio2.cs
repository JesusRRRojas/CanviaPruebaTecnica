using System;
using System.Collections.Generic;
using System.Text;

namespace CanviaPruebaTecnica
{
    public class Ejercicio2
    {
        private bool Verificar(string initial, string target)
        {
            if (initial.Length<1 && initial.Length>999)
            {
                return false;
            }
            if (target.Length < 2 && target.Length > 1000)
            {
                return false;
            }

            return true;

        }


        public string canObtain(string initial, string target) {

            if (!Verificar(initial, target))
            {
                return "Regla principal no cumple";
            }


            bool revertir = false;

            while (initial.Length < target.Length)
            {
                if (revertir)
                {
                    initial = Revertir(initial);
                    initial += "B";
                    revertir = false;
                }
                else
                {
                    initial += "A";
                    revertir = true;
                }

            }
            return initial == target ? "Possible" : "Impossible";

        }
        private string Revertir(string texto)
        {
            char[] newText = texto.ToCharArray();
            Array.Reverse(newText);
            return new string(newText);
        }
    }
}
