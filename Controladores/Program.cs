using ejercicio3Bucles.Servicios;

namespace ejercicio3Bucles
{
    class Program
    {
        static void Main(string[] args)
        {

            solicitudNumeroInterfaz sn = new solicitudNumeroImplementacion();
            int numeroInt= sn.numeroInt();

            operacionesInterfaz op =new operacionesImplementacion();
             op.calculo(numeroInt);
        }
    }

}



