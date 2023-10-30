using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3Bucles.Servicios
{
    internal class solicitudNumeroImplementacion : solicitudNumeroInterfaz
    {
        public int numeroInt()
        {
            int numeroInt;

            Console.WriteLine("EScriba un numero entero mayor que 0 ");   
            numeroInt= Convert.ToInt32(Console.ReadLine());
            return numeroInt;
        }
    }
}
