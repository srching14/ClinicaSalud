using System;
namespace ClinicaSalud.models;

public class Patient
{
    public Guid id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string symptom { get; set; }

    public override string ToString()
    {
        return $"ID: {id}, Name: {name}, Age: {age}, Symptom: {symptom}";
    }
    public Patient(string name, int age, string symptom)
    {
        this.name = name;
        this.age = age;
        this.symptom = symptom;
    }
}
