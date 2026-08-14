using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Banco banco = new Banco();

            int opcion;

            do
            {
                Console.WriteLine("\n===== SISTEMA BANCARIO =====");
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Consultar cuenta");
                Console.WriteLine("5. Mostrar todas las cuentas");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearCuenta();
                        break;

                    case 2:
                        Depositar();
                        break;

                    case 3:
                        Retirar();
                        break;

                    case 4:
                        ConsultarCuenta();
                        break;

                    case 5:
                        MostrarCuentas();
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcion != 0);

            // CREAR CUENTA

            void CrearCuenta()
            {
                Console.WriteLine("\n--- CREAR CUENTA ---");

                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                Console.Write("Nombre del titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                decimal saldoInicial = decimal.Parse(Console.ReadLine());

                if (saldoInicial < 0)
                {
                    Console.WriteLine("El saldo inicial no puede ser negativo.");
                    return;
                }

                Console.WriteLine("\nTipos de cuenta:");
                Console.WriteLine("1. Cuenta estándar");
                Console.WriteLine("2. Cuenta plus");
                Console.Write("Seleccione el tipo: ");

                int tipo = int.Parse(Console.ReadLine());

                Cuenta nuevaCuenta;

                if (tipo == 1)
                {
                    nuevaCuenta = new CuentaEstandar(numero, titular, saldoInicial);
                }
                else if (tipo == 2)
                {
                    nuevaCuenta = new CuentaPlus(numero, titular, saldoInicial);
                }
                else
                {
                    Console.WriteLine("Tipo de cuenta incorrecto.");
                    return;
                }

                if (banco.AgregarCuenta(nuevaCuenta))
                {
                    Console.WriteLine("Cuenta creada correctamente.");
                }
                else
                {
                    Console.WriteLine("Ya existe una cuenta con ese número.");
                }
            }

            // DEPOSITAR

            void Depositar()
            {
                Console.WriteLine("\n--- DEPOSITAR DINERO ---");

                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                Cuenta cuenta = banco.BuscarCuenta(numero);

                if (cuenta == null)
                {
                    Console.WriteLine("La cuenta no existe.");
                    return;
                }

                Console.Write("Importe a depositar: ");
                decimal importe = decimal.Parse(Console.ReadLine());

                cuenta.Depositar(importe);
            }

            // RETIRAR

            void Retirar()
            {
                Console.WriteLine("\n--- RETIRAR DINERO ---");

                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                Cuenta cuenta = banco.BuscarCuenta(numero);

                if (cuenta == null)
                {
                    Console.WriteLine("La cuenta no existe.");
                    return;
                }

                Console.Write("Importe a retirar: ");
                decimal importe = decimal.Parse(Console.ReadLine());

                cuenta.Retirar(importe);
            }

            // CONSULTAR CUENTA

            void ConsultarCuenta()
            {
                Console.WriteLine("\n--- CONSULTAR CUENTA ---");

                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                Cuenta cuenta = banco.BuscarCuenta(numero);

                if (cuenta == null)
                {
                    Console.WriteLine("La cuenta no existe.");
                    return;
                }

                Console.WriteLine("\n--- DATOS DE LA CUENTA ---");
                Console.WriteLine("Número: " + cuenta.Numero);
                Console.WriteLine("Titular: " + cuenta.Titular);
                Console.WriteLine("Tipo: " + cuenta.GetType().Name);
                Console.WriteLine("Saldo: $" + cuenta.Saldo);
            }

            // MOSTRAR TODAS LAS CUENTAS

            void MostrarCuentas()
            {
                Console.WriteLine("\n--- TODAS LAS CUENTAS ---");

                List<Cuenta> cuentas = banco.ObtenerCuentas();

                if (cuentas.Count == 0)
                {
                    Console.WriteLine("No hay cuentas registradas.");
                    return;
                }

                foreach (Cuenta cuenta in cuentas)
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("Número: " + cuenta.Numero);
                    Console.WriteLine("Titular: " + cuenta.Titular);
                    Console.WriteLine("Tipo: " + cuenta.GetType().Name);
                    Console.WriteLine("Saldo: $" + cuenta.Saldo);
                }
            }
        }
    }
}
