using System;
using System.Collections.Generic;
using SiatemaEmergencia;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UnidadEmergencia> unidades = new List<UnidadEmergencia>();
            List<Radio> radios = new List<Radio>();

            int opcion;

            do
            {
                Console.WriteLine("\n===== SISTEMA DE EMERGENCIAS =====");
                Console.WriteLine("1. Crear ambulancia");
                Console.WriteLine("2. Crear camión de bomberos");
                Console.WriteLine("3. Crear radio");
                Console.WriteLine("4. Encender radio");
                Console.WriteLine("5. Instalar radio");
                Console.WriteLine("6. Agregar paciente");
                Console.WriteLine("7. Recargar camión");
                Console.WriteLine("8. Ejecutar protocolo");
                Console.WriteLine("9. Mostrar unidades");
                Console.WriteLine("0. Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearAmbulancia();
                        break;

                    case 2:
                        CrearCamion();
                        break;

                    case 3:
                        CrearRadio();
                        break;

                    case 4:
                        EncenderRadio();
                        break;

                    case 5:
                        InstalarRadio();
                        break;

                    case 6:
                        AgregarPaciente();
                        break;

                    case 7:
                        RecargarCamion();
                        break;

                    case 8:
                        EjecutarProtocolo();
                        break;

                    case 9:
                        MostrarUnidades();
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcion != 0);


            void CrearAmbulancia()
            {
                Console.Write("Identificador de la ambulancia: ");
                string identificador = Console.ReadLine();

                Console.Write("Cantidad de kits de trauma: ");
                double kits = double.Parse(Console.ReadLine());

                Ambulancia ambulancia = new Ambulancia(
                    identificador,
                    kits
                );

                unidades.Add(ambulancia);

                Console.WriteLine("Ambulancia creada correctamente.");
            }


            void CrearCamion()
            {
                Console.Write("Identificador del camión: ");
                string identificador = Console.ReadLine();

                Console.Write("Cantidad de agua inicial: ");
                double agua = double.Parse(Console.ReadLine());

                CamionBomberos camion = new CamionBomberos(
                    identificador,
                    agua
                );

                unidades.Add(camion);

                Console.WriteLine("Camión creado correctamente.");
            }


            void CrearRadio()
            {
                Console.Write("Modelo de la radio: ");
                string modelo = Console.ReadLine();

                Radio radio = new Radio(modelo);

                radios.Add(radio);

                Console.WriteLine("Radio creada correctamente.");
            }


            void EncenderRadio()
            {
                Console.Write("Modelo de la radio: ");
                string modelo = Console.ReadLine();

                foreach (Radio radio in radios)
                {
                    if (radio.Modelo == modelo)
                    {
                        radio.Encender();
                        return;
                    }
                }

                Console.WriteLine("Radio no encontrada.");
            }


            void InstalarRadio()
            {
                Console.Write("Identificador de la unidad: ");
                string identificador = Console.ReadLine();

                UnidadEmergencia unidad = BuscarUnidad(identificador);

                if (unidad == null)
                {
                    Console.WriteLine("Unidad no encontrada.");
                    return;
                }

                Console.Write("Modelo de la radio: ");
                string modelo = Console.ReadLine();

                foreach (Radio radio in radios)
                {
                    if (radio.Modelo == modelo)
                    {
                        unidad.InstalarRadio(radio);
                        return;
                    }
                }

                Console.WriteLine("Radio no encontrada.");
            }


            void AgregarPaciente()
            {
                Console.Write("Identificador de la ambulancia: ");
                string identificador = Console.ReadLine();

                UnidadEmergencia unidad = BuscarUnidad(identificador);

                if (unidad == null)
                {
                    Console.WriteLine("Unidad no encontrada.");
                    return;
                }

                Ambulancia ambulancia = unidad as Ambulancia;

                if (ambulancia == null)
                {
                    Console.WriteLine("La unidad seleccionada no es una ambulancia.");
                    return;
                }

                Console.Write("Nombre del paciente: ");
                string nombre = Console.ReadLine();

                Console.Write("Gravedad (1 a 5): ");
                int gravedad = int.Parse(Console.ReadLine());

                Paciente paciente = new Paciente(nombre, gravedad);

                ambulancia.AgregarPaciente(paciente);
            }


            void RecargarCamion()
            {
                Console.Write("Identificador del camión: ");
                string identificador = Console.ReadLine();

                UnidadEmergencia unidad = BuscarUnidad(identificador);

                if (unidad == null)
                {
                    Console.WriteLine("Unidad no encontrada.");
                    return;
                }

                CamionBomberos camion = unidad as CamionBomberos;

                if (camion == null)
                {
                    Console.WriteLine("La unidad seleccionada no es un camión.");
                    return;
                }

                Console.Write("Cantidad de litros a agregar: ");
                double cantidad = double.Parse(Console.ReadLine());

                camion.Recargar(cantidad);
            }


            void EjecutarProtocolo()
            {
                Console.Write("Identificador de la unidad: ");
                string identificador = Console.ReadLine();

                UnidadEmergencia unidad = BuscarUnidad(identificador);

                if (unidad == null)
                {
                    Console.WriteLine("Unidad no encontrada.");
                    return;
                }

                unidad.EjecutarProtocolo();
            }


            UnidadEmergencia BuscarUnidad(string identificador)
            {
                foreach (UnidadEmergencia unidad in unidades)
                {
                    if (unidad.Identificador == identificador)
                    {
                        return unidad;
                    }
                }

                return null;
            }


            void MostrarUnidades()
            {
                Console.WriteLine("\n--- UNIDADES ---");

                if (unidades.Count == 0)
                {
                    Console.WriteLine("No hay unidades registradas.");
                    return;
                }

                foreach (UnidadEmergencia unidad in unidades)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Identificador: " + unidad.Identificador);
                    Console.WriteLine("Estado: " + unidad.Estado);
                    Console.WriteLine("Tipo: " + unidad.GetType().Name);

                    if (unidad.Radio != null)
                    {
                        Console.WriteLine("Radio: " + unidad.Radio.Modelo);
                    }
                    else
                    {
                        Console.WriteLine("Radio: Sin instalar");
                    }
                }
            }
        }
    }
}