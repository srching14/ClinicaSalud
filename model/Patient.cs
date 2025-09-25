namespace ClinicaSalud.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sintoma { get; set; }
        public string Mascota { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Edad: {Edad}, Síntoma: {Sintoma}, Mascota: {Mascota}";
        }
    }
}
