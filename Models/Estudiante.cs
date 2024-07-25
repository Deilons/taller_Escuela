using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_Escuela.Models;

public class Estudiante : Persona
{
    public string NombreAcudiente { get; set; }

    public string CursoActual { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    public List<double> Calificaciones { get; set; }

    // Constructor
    public Estudiante()
    {
        Id = 0;
        Nombre = string.Empty;
        Apellidos = string.Empty;
        TipoDocumento = string.Empty;
        NroDocumento = string.Empty;
        Email = string.Empty;
        Telefono = string.Empty;
        NombreAcudiente = string.Empty;
        CursoActual = string.Empty;
        FechaNacimiento = DateOnly.FromDateTime(DateTime.Now);
        Calificaciones = new List<double>();
    }   

    // Metodos
    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"NombreAcudiente: {NombreAcudiente}");
        Console.WriteLine($"CursoActual: {CursoActual}");
        Console.WriteLine($"FechaNacimiento: {FechaNacimiento}");
        Console.Write("Calificaciones: ");
        foreach (double cal in Calificaciones)
        {
            Console.Write(cal + ", ");
        }
        Console.WriteLine();
    }

    public double CalcularPromedio()
    {
        double promedio = Calificaciones.Sum() / Calificaciones.Count;
        return promedio;
    }

    public int CalcularEdad()
    {
        int edad = DateTime.Now.Year - FechaNacimiento.Year;
        return edad;
    }
}
