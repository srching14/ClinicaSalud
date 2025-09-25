using ClinicaSalud.models;

class Program
{
    static void Main()
    {
        var patients = new Patient("John Doe", 30, "Gripe");

        Console.WriteLine($"Patient Name: {patients.name}");
        Console.WriteLine($"Patient Age: {patients.age}");
        Console.WriteLine($"Patient Symptom: {patients.symptom}");
    }
}