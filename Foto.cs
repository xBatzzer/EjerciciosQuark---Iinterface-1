using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark
{
    class Foto : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
}
