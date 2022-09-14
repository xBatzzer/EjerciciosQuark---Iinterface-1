using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark
{
    class Documento : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
