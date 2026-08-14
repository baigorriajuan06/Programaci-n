using System;
using System.Collections.Generic;
using Videojuego;

class Program
{
    static List<Personaje> personajes = new List<Personaje>();
    static List<Combate> combates = new List<Combate>();

    static void Main()
    {
        int opcion = 0;

        while (opcion != 6)
        {
            Console.WriteLine("===== VIDEOJUEGO RPG =====");
            Console.WriteLine("1 - Registrar personaje");
            Console.WriteLine("2 - Ver personajes");
            Console.WriteLine("3 - Iniciar combate");
            Console.WriteLine("4 - Ver historial");
            Console.WriteLine("5 - Ver estadisticas");
            Console.WriteLine("6 - Salir");
            Console.Write("Opcion: ");

            opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            if (opcion == 1)
            {
                RegistrarPersonaje();
            }
            else if (opcion == 2)
            {
                VerPersonajes();
            }
            else if (opcion == 3)
            {
                IniciarCombate();
            }
            else if (opcion == 4)
            {
                VerHistorial();
            }
            else if (opcion == 5)
            {
                VerEstadisticas();
            }
            else if (opcion == 6)
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opcion incorrecta.");
            }

            Console.WriteLine();
        }
    }

    static void RegistrarPersonaje()
    {
        Console.WriteLine("===== REGISTRAR PERSONAJE =====");

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Nivel: ");
        int nivel = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - Guerrero");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arquero");
        Console.Write("Tipo: ");

        int tipo = int.Parse(Console.ReadLine());

        Personaje personaje = null;

        if (tipo == 1)
        {
            personaje = new Guerrero(nombre, nivel);
        }
        else if (tipo == 2)
        {
            personaje = new Mago(nombre, nivel);
        }
        else if (tipo == 3)
        {
            personaje = new Arquero(nombre, nivel);
        }
        else
        {
            Console.WriteLine("Tipo incorrecto.");
            return;
        }

        personajes.Add(personaje);

        Console.WriteLine("Personaje creado.");
    }

    static void VerPersonajes()
    {
        Console.WriteLine("===== PERSONAJES =====");

        if (personajes.Count == 0)
        {
            Console.WriteLine("No hay personajes.");
            return;
        }

        for (int i = 0; i < personajes.Count; i++)
        {
            Console.WriteLine(
                (i + 1) + " - " +
                personajes[i].Nombre +
                " | Nivel: " + personajes[i].Nivel +
                " | Vida: " + personajes[i].Vida +
                " | Ataque: " + personajes[i].Ataque +
                " | Defensa: " + personajes[i].Defensa
            );
        }
    }

    static void IniciarCombate()
    {
        Console.WriteLine("===== COMBATE =====");

        if (personajes.Count < 2)
        {
            Console.WriteLine("Necesitas al menos 2 personajes.");
            return;
        }

        VerPersonajes();

        Console.Write("Seleccione el primer personaje: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Seleccione el segundo personaje: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 == numero2)
        {
            Console.WriteLine("No puede ser el mismo personaje.");
            return;
        }

        Personaje personaje1 = personajes[numero1 - 1];
        Personaje personaje2 = personajes[numero2 - 1];

        Combate combate = new Combate(personaje1, personaje2);

        combate.Iniciar();

        combates.Add(combate);

        Console.WriteLine();
        Console.WriteLine("===== RESULTADO =====");
        Console.WriteLine("Ganador: " + combate.Ganador.Nombre);
        Console.WriteLine("Turnos: " + combate.Turnos);
    }

    static void VerHistorial()
    {
        Console.WriteLine("===== HISTORIAL =====");

        if (combates.Count == 0)
        {
            Console.WriteLine("No hay combates.");
            return;
        }

        for (int i = 0; i < combates.Count; i++)
        {
            Console.WriteLine(
                (i + 1) + " - " +
                combates[i].Personaje1.Nombre +
                " vs " +
                combates[i].Personaje2.Nombre +
                " | Ganador: " +
                combates[i].Ganador.Nombre +
                " | Turnos: " +
                combates[i].Turnos
            );
        }
    }

    static void VerEstadisticas()
    {
        Console.WriteLine("===== ESTADISTICAS =====");

        for (int i = 0; i < personajes.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Nombre: " + personajes[i].Nombre);
            Console.WriteLine("Combates: " + personajes[i].CombatesJugados);
            Console.WriteLine("Victorias: " + personajes[i].Victorias);
            Console.WriteLine("Derrotas: " + personajes[i].Derrotas);
            Console.WriteLine("Daño infligido: " + personajes[i].DañoInfligido);
            Console.WriteLine("Daño recibido: " + personajes[i].DañoRecibido);
        }
    }
}