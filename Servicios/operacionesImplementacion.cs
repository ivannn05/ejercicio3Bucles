using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3Bucles.Servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void calculo(int numeroInt)
        {
            string aux ="";
            for(int i=1 ; i<=numeroInt ;i++)
            {
                aux = aux + i;

                Console.WriteLine(aux);
            }
           
        }
    }
}
