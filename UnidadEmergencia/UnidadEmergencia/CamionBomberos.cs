using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiatemaEmergencia;

namespace SiatemaEmergencia
{
    public class CamionBomberos : UnidadEmergencia
    {
        private const double CAPACIDAD_MAXIMA = 5000;
        private const double CONSUMO_EMERGENCIA = 1000;

        public double Agua { get; private set; }

        public CamionBomberos(string identificador, double aguaInicial)
            : base(identificador)
        {
            if (aguaInicial < 0)
            {
                Agua = 0;
            }
            else if (aguaInicial > CAPACIDAD_MAXIMA)
            {
                Agua = CAPACIDAD_MAXIMA;
            }
            else
            {
                Agua = aguaInicial;
            }
        }

        public void Recargar(double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
                return;
            }

            if (Agua + cantidad > CAPACIDAD_MAXIMA)
            {
                Console.WriteLine("El tanque no puede superar los 5000 litros.");
                return;
            }

            Agua = Agua + cantidad;

            Console.WriteLine("Recarga realizada correctamente.");
        }

        public override void EjecutarProtocolo()
        {
            if (Agua < CONSUMO_EMERGENCIA)
            {
                Console.WriteLine("No hay agua suficiente. Necesita recarga.");
                return;
            }

            Console.WriteLine("Activando mangueras.");
            Console.WriteLine("Comenzando a apagar el fuego.");

            Agua = Agua - CONSUMO_EMERGENCIA;

            Estado = "En Servicio";

            Console.WriteLine("Emergencia atendida.");
            Console.WriteLine("Agua restante: " + Agua + " litros");

            if (Radio != null)
            {
                Radio.Bip();
            }
        }
    }
}
