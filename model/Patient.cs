using System;
namespace ClinicaSalud.models;

public class Patient
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string symptom { get; set; }
}
