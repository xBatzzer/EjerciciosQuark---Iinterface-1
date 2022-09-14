using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark
{
    class Impresora
    {
        // -- Esto genera una lista de objetos de clases que implementen la interface IImprimible, no? De esta manera, el día de mañana puedo agregar la clase X, que implemente
        // -- la interface IImprimible sin tocar Impresora, me equivoco?
        private List<IImprimible> colaDeImpresion = new List<IImprimible>();

        
        public void ImprimirTodo()
        {
            foreach(IImprimible i in colaDeImpresion)
            {
                i.Imprimir();
            }
        }

        public void AgregarImprimible(IImprimible unImprimible)
        {
            colaDeImpresion.Add(unImprimible);
        }
    }
}
