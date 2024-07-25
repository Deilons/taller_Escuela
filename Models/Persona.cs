using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_Escuela.Models;

public class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string TipoDocumento { get; set; }
    public string NroDocumento { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"TipoDocumento: {TipoDocumento}");
        Console.WriteLine($"NroDocumento: {NroDocumento}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Telefono: {Telefono}");
    }

}
