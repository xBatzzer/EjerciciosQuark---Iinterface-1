using System;

namespace EjerciciosQuark
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- En este caso aunque yo no haya definido constructores en las clases, se genera automáticamente el const por defecto?
            // -- Esto generalmente se hace así? o es recomendable hacerle el por defecto de todas formas? 
            Impresora impresora = new Impresora();
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();

            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(documento);

            impresora.ImprimirTodo(); 

            Console.ReadKey();     
            
            
        }
    }
}
