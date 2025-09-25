using System;
using System.Collections.Generic;
using ClinicaSalud.Models;
using ClinicaSalud.Services;

namespace ClinicaSalud
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Paciente> pacientes = new List<Paciente>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- Menú Principal Clínica Salud+ ---");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Listar pacientes");
                Console.WriteLine("3. Buscar paciente por nombre");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        PacienteService.RegistrarPaciente(pacientes);
                        break;
                    case "2":
                        PacienteService.ListarPacientes(pacientes);
                        break;
                    case "3":
                        PacienteService.BuscarPacientePorNombre(pacientes);
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("👋 Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("⚠️ Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
