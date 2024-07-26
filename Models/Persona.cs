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

    public Persona()
    {
        Id = 0;
        Nombre = string.Empty;
        Apellidos = string.Empty;
        TipoDocumento = string.Empty;
        NroDocumento = string.Empty;
        Email = string.Empty;
        Telefono = string.Empty;
    }

    public virtual void MostrarDetalles()
    {   
        Console.WriteLine(
    $@"
╔════════════════════════════════════════════════╗
║                   INFORMACIÓN                  ║
╚════════════════════════════════════════════════╝
    Id: {Id}
    Nombre: {Nombre}
    Apellidos: {Apellidos}
    TipoDocumento: {TipoDocumento}
    NroDocumento: {NroDocumento}
    Email: {Email}
    Teléfono: {Telefono}
╚════════════════════════════════════════════════╝"
);

    }

}
