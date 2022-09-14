using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark
{
    class Contrato : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
