using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiatemaEmergencia
{
    public class Ambulancia : UnidadEmergencia
    {
        private List<Paciente> pacientes;
        private const int MAXIMO_PACIENTES = 3;

        public double KitsTrauma { get; private set; }

        public Ambulancia(string identificador, double kitsIniciales)
            : base(identificador)
        {
            pacientes = new List<Paciente>();
            KitsTrauma = kitsIniciales;
        }

        public void AgregarPaciente(Paciente paciente)
        {
            if (paciente.Gravedad < 1 || paciente.Gravedad > 5)
            {
                Console.WriteLine("La gravedad debe estar entre 1 y 5.");
                return;
            }

            if (pacientes.Count >= MAXIMO_PACIENTES)
            {
                Console.WriteLine("La ambulancia está llena.");
                return;
            }
            pacientes.Add(paciente);

            Console.WriteLine("Paciente agregado correctamente.");
        }

        public override void EjecutarProtocolo()
        {
            if (pacientes.Count == 0)
            {
                Console.WriteLine("No hay pacientes a bordo.");
                return;
            }

            if (KitsTrauma <= 0)
            {
                Console.WriteLine("No hay kits de trauma disponibles.");
                return;
            }

            Console.WriteLine("Enviando paramédicos y preparando la camilla.");

            Paciente pacienteGrave = pacientes[0];
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Gravedad > pacienteGrave.Gravedad)
                {
                    pacienteGrave = paciente;
                }
            }

            Console.WriteLine(
                "Atendiendo al paciente: " + pacienteGrave.Nombre
            );

            double consumo;

            if (pacienteGrave.Gravedad == 5)
            {
                consumo = 1;
            }
            else
            {
                consumo = 0.5;
            }

            if (KitsTrauma < consumo)
            {
                Console.WriteLine("No hay suficientes kits de trauma.");
                return;
            }
            KitsTrauma = KitsTrauma - consumo;

            pacientes.Remove(pacienteGrave);

            Estado = "En Servicio";

            Console.WriteLine("Paciente atendido correctamente.");
            Console.WriteLine("Kits restantes: " + KitsTrauma);

            if (Radio != null)
            {
                Radio.Bip();
            }
        }
    }
}
