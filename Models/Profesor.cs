using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_Escuela.Models;

public class Profesor : Persona
{
    public string Asignatura { get; set; }

    public double Sueldo { get; set; }

    public DateTime FechaContrato { get; set; }

    public List<string> Cursos { get; set; }

    // constructor
    public Profesor()
    {
        Id = 0;
        Nombre = string.Empty;
        Apellidos = string.Empty;
        TipoDocumento = string.Empty;
        NroDocumento = string.Empty;
        Email = string.Empty;
        Telefono = string.Empty;
        Asignatura = string.Empty;
        Sueldo = 0;
        FechaContrato = DateTime.Now;
        Cursos = new List<string>();
    }

    // Metodos
    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
Console.WriteLine(
    $@"
╔════════════════════════════════════════════════╗
║                  DETALLES                      ║
╚════════════════════════════════════════════════╝
    Asignatura: {Asignatura}
    Sueldo: {Sueldo}
    FechaContrato: {FechaContrato}
    Cursos: {string.Join(", ", Cursos)}
╚════════════════════════════════════════════════╝
"
);

        Console.WriteLine();
    }
    public int CalcularAntiguedad()
{
    int antiguedad = DateTime.Now.Year - FechaContrato.Year;
    return antiguedad;
}

    public void ObtenerSueldo()
    {
        double sueldo = Sueldo;
        Console.WriteLine($"Sueldo: {sueldo}");
    }
}
