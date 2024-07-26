using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_Escuela.Models;

public class AdministradorApp
{
    public List<Profesor> Profesores { get; set; }
    public List<Estudiante> Estudiantes { get; set; }

    // constructor
    public AdministradorApp()
    {
        Profesores = new List<Profesor>();
        Estudiantes = new List<Estudiante>();
    }

    // Metodos

    // AgregarProfesor

    public void AgregarProfesor(Profesor p)
    {
        Profesores.Add(p);

    }

    // AgregarEstudiante
    public void AgregarEstudiante(Estudiante e)
    {
        Estudiantes.Add(e);
    }

    // Mostrar Profesores
    public void MostrarProfesores()
    {
        Console.Clear();

        foreach (Profesor p in Profesores)
        {
            p.MostrarDetalles();
        }
    }

    public void MostrarEstudiantes()
    {
        Console.Clear();
        foreach (Estudiante e in Estudiantes)
        {
            e.MostrarDetalles();
        }
    }

    public void MostrarPromedioSuperior()
    {
        Console.Clear();

        var estudiantesConPromedioSuperior = Estudiantes
            .Where(x => x.CalcularPromedio() > 8.5)
            .Select(x => x)
            .ToList();
        Console.WriteLine("Estudiantes con promedio superior a 8.5:");
        foreach (var e in estudiantesConPromedioSuperior)
        {
            Console.WriteLine(e);
        }
    }

    public void ObtenerProfesoresConMasCursos()
    {
        Console.Clear();

        var profesoresConMasCursos = Profesores
            .GroupBy(x => x)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToList();
        Console.WriteLine("Profesores con más de un curso:");
        foreach (var p in profesoresConMasCursos)
        {
            Console.WriteLine(p);
        }
    }

    public void FiltrarEdadEstudiantes()
    {
        Console.Clear();

        foreach (Estudiante e in Estudiantes)
        {
            if (e.CalcularEdad() > 16)
            {
                Console.WriteLine($@"
                Nombre: {e.Nombre}
                Apellidos: {e.Apellidos}
                Edad: {e.CalcularEdad()}
                ");

            }
        }
    }

    public void EstudiantesPorApellido()
    {
        Console.Clear();

        foreach (Estudiante e in Estudiantes.OrderBy(x => x.Apellidos))
        {
            Console.WriteLine($@"
            Nombre: {e.Nombre}
            Apellidos: {e.Apellidos}
            Edad: {e.CalcularEdad() + " años"}
            ");
        }
    }

    public void ObtenerSueldos()
    {
        Console.Clear();

        double sueldos = Profesores.Sum(x => x.Sueldo);
        Console.WriteLine($"Sueldos totales: {sueldos}");
    }

    public void NotaMayorPorCurso()
    {
        Console.Clear();

        Estudiante? estudianteEncontrado = null;

        Console.WriteLine("Ingrese el curso: ");
        string curso = Console.ReadLine();

        double notaMayor = double.MinValue;
        bool encontrado = false;

        if (string.IsNullOrWhiteSpace(curso))
        {
            Console.WriteLine("Por favor ingrese un curso, Quiere volver a intentar? s/n");
            string respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                NotaMayorPorCurso();
            }
            else
            {
                return;
            }

        }
        else
        {
            foreach (Estudiante e in Estudiantes)
            {
                double nota = e.Calificaciones.Max();
                if (curso == e.CursoActual && nota > notaMayor)
                {
                    notaMayor = nota;
                    encontrado = true;
                    estudianteEncontrado = e;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($@"
            Nombre: {estudianteEncontrado.Nombre}
            Apellidos: {estudianteEncontrado.Apellidos}
            Nota: {notaMayor}
            ");
            }
            else
            {
                Console.WriteLine("No se encontró ningún estudiante con la nota más alta en el curso especificado.");
            }
        }
    }

    public void ProfesoresConMasDe10Años()
    {
        Console.Clear();
        foreach (Profesor p in Profesores)
        {
            if (p.CalcularAntiguedad() > 10)
            {
                Console.WriteLine($@"
                Nombre: {p.Nombre}
                Apellidos: {p.Apellidos}
                antiguedad: {p.CalcularAntiguedad() + " años"}
                ");

            }
        }
    }

    public void AsignaturasUnicas()
    {
        Console.Clear();

        List<string> asignaturasUnicas = new List<string>();
        foreach (Profesor p in Profesores)
        {
            foreach (string c in p.Cursos)
            {
                if (!asignaturasUnicas.Contains(c))
                {
                    asignaturasUnicas.Add(c);
                }
            }
        }
        Console.WriteLine("Asignaturas unicas:");
        foreach (string c in asignaturasUnicas)
        {
            Console.WriteLine(c);
        }
    }

    public void AcudienteEsMaria()
    {
        Console.Clear();

        foreach (Estudiante e in Estudiantes)
        {
            if (e.NombreAcudiente.Contains("Maria"))
            {
                Console.WriteLine($@"
                Nombre: {e.Nombre}
                Apellidos: {e.Apellidos}
                Nombre Acudiente: {e.NombreAcudiente}
                ");
            }
        }
    }
    public void ListaSalariosDescencientes()
    {
        Console.Clear();

        foreach (Profesor p in Profesores.OrderBy(x => x.Sueldo))
        {
            Console.WriteLine($@"
            Nombre: {p.Nombre}
            Apellidos: {p.Apellidos}
            Sueldo: {p.Sueldo}
            ");
        }
    }

    public void PromedioEdades()
    {
        Console.Clear();

        double promedio = Estudiantes.Average(x => x.CalcularEdad());
        Console.WriteLine($"Promedio de edades: {promedio}");
    }

    public void ProfesoresMatematicas()
    {
        Console.Clear();
        foreach (Profesor p in Profesores)
        {
            if (p.Cursos.Contains("Matemáticas"))
            {
                Console.WriteLine($@"
                Nombre: {p.Nombre}
                Apellidos: {p.Apellidos}
                Cursos: {p.Cursos}
                ");
            }
        }
    }

    public void CursosConMasDeTresCalificaciones()
    {
        Console.Clear();

        var cursosConMasDeTresCalificaciones = Estudiantes
            .SelectMany(x => x.CursoActual)
            .GroupBy(x => x)
            .Where(x => x.Count() > 3)
            .Select(x => x.Key)
            .ToList();
        Console.WriteLine("Cursos con más de tres calificaciones:");
        foreach (var c in cursosConMasDeTresCalificaciones)
        {
            Console.WriteLine(c);
        }
    }
    public void AntiguedadPromedio()
    {
        Console.Clear();

        double promedio = Profesores.Average(x => x.CalcularAntiguedad());
        Console.WriteLine($"Promedio de antiguedad: {promedio}");
    }

    public void InterfazVisual()
    {

        Console.WriteLine(
@"
╔══════════════════════════════════════════════════╗
║                 MENU DE OPCIONES                 ║                   
║                    COLEGIO                       ║
║                                                  ║
║           1. Agregar Profesor                    ║
║           2. Agregar Estudiante                  ║
║           3. Mostrar Profesores                  ║
║           4. Mostrar Estudiantes                 ║
║           5. Mostrar Promedio                    ║
║           6. Mostrar Profesores con 10 años exp  ║
║           7. Filtrar Estudiantes por Edad        ║
║           8. Estudiantes por Apellidos           ║
║           9. Obtener Sueldos                     ║
║          10. Nota Mayor por Cursos               ║
║          11. Profesores con más de 10 años       ║
║          12. Asignaturas Únicas                  ║
║          13. Acudiente es Maria                  ║
║          14. Lista de Salarios Descendientes     ║
║          15. Promedio de Edades                  ║
║          16. Profesores de Matemáticas           ║
║          17. Cursos con más de 3 Calificaciones  ║
║          18. Antigüedad Promedio                 ║
║          19. Salir                               ║
╚══════════════════════════════════════════════════╝
            Opción: "
);




    }

}