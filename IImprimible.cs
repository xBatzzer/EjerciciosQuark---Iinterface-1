using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark
{
    interface IImprimible
    {

        /* -- En lo largo de la búsqueda de información sobre interfaces y diseño de arquitectura MVP  me encuentro con que muchos definen atributos a la interface
         * -- eso estaría correcto? En ese caso se implementa también el atributo?
        */
        void Imprimir();
    }
}
