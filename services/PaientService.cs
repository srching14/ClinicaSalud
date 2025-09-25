using System;
using System.Collections.Generic;
using ClinicaSalud.Models;

namespace ClinicaSalud.Services
{
    public static class PacienteService
    {
        private static int _contadorId = 1;

        public static void RegistrarPaciente(List<Paciente> lista)
        {
            try
            {
                Console.Write("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("❌ El nombre no puede estar vacío.");
                    return;
                }

                Console.Write("Ingrese edad: ");
                if (!int.TryParse(Console.ReadLine(), out int edad) || edad <= 0)
                {
                    Console.WriteLine("❌ Edad inválida.");
                    return;
                }

                Console.Write("Ingrese síntoma: ");
                string sintoma = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(sintoma))
                {
                    Console.WriteLine("❌ El síntoma no puede estar vacío.");
                    return;
                }

                Console.Write("Ingrese nombre de la mascota: ");
                string mascota = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(mascota))
                {
                    Console.WriteLine("❌ La mascota no puede estar vacía.");
                    return;
                }

                Paciente nuevo = new Paciente
                {
                    Id = _contadorId++,
                    Nombre = nombre,
                    Edad = edad,
                    Sintoma = sintoma,
                    Mascota = mascota
                };

                lista.Add(nuevo);
                Console.WriteLine("✅ Paciente registrado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error al registrar paciente: {ex.Message}");
            }
        }

        public static void ListarPacientes(List<Paciente> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            Console.WriteLine("\n📋 Lista de Pacientes:");
            foreach (var p in lista)
            {
                Console.WriteLine(p);
            }
        }

        public static void BuscarPacientePorNombre(List<Paciente> lista)
        {
            Console.Write("Ingrese el nombre del paciente a buscar: ");
            string nombre = Console.ReadLine();

            var encontrado = lista.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
            {
                Console.WriteLine($"🔎 Paciente encontrado: {encontrado}");
            }
            else
            {
                Console.WriteLine("❌ No se encontró ningún paciente con ese nombre.");
            }
        }
    }
}
