using taller_Escuela.Models;
using System.Globalization;

Console.Clear();

var administradorApp = new AdministradorApp();

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 1,
    Nombre = "Juan",
    Apellidos = "Perez",
    TipoDocumento = "CC",
    NroDocumento = "12345678",
    Email = "juanPerez@gmail.com",
    Telefono = "123456789",
    Asignatura = "Matematicas",
    Sueldo = 9000,
    FechaContrato = new DateTime(2018, 5, 11),
    Cursos = new List<string> {"Matematicas", "Fisica", "Biologia"}
});

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 2,
    Nombre = "Pedro",
    Apellidos = "Sanchez",
    TipoDocumento = "CC",
    NroDocumento = "12345678",
    Email = "pedroLopez@gmail.com",
    Telefono = "123456789",
    Asignatura = "Historia",
    Sueldo = 6000,
    FechaContrato = new DateTime(2010, 3, 11),
    Cursos = new List<string> {"Historia", "Lengua"}
});

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 3,
    Nombre = "Maria",
    Apellidos = "Gonzalez",
    TipoDocumento = "CC",
    NroDocumento = "12345678",
    Email = "mariaGonzalez@gmail.com",
    Telefono = "123456789",
    Asignatura = "Informática",
    Sueldo = 5000,
    FechaContrato = new DateTime(2020, 5, 1),
    Cursos = new List<string> {"Informática"}
});

// Estudiantes
administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 1,
    Nombre = "Maria",
    Apellidos = "Becerra",
    TipoDocumento = "CC",
    NroDocumento = "12345678",
    Email = "MriaBecerra@gmail.com",
    Telefono = "123456789",
    NombreAcudiente = "Gregorio",
    CursoActual = "Matematicas",
    FechaNacimiento = new DateOnly(2006, 6, 1),
    Calificaciones = new List<double> { 9.5, 9.0, 9.5 }
});

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 2,
    Nombre = "antonio",
    Apellidos = "Gonzalez",
    TipoDocumento = "TI",
    NroDocumento = "12345678",
    Email = "AntonioGonzalez@gmail.com",
    Telefono = "123456789",
    NombreAcudiente = "Pedro",
    CursoActual = "Historia",
    FechaNacimiento = new DateOnly(2010, 9, 12),
    Calificaciones = new List<double> { 2.0, 5.0, 3.5 }
});

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 3,
    Nombre = "Luis",
    Apellidos = "Antares",
    TipoDocumento = "TI",
    NroDocumento = "12345678",
    Email = "LuisAntares@gmail.com",
    Telefono = "123456789",
    NombreAcudiente = "Alberto",
    CursoActual = "Historia",
    FechaNacimiento = new DateOnly(2009, 8, 10),
    Calificaciones = new List<double> { 7.1, 8.0, 3.5 }
});

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 4,
    Nombre = "German",
    Apellidos = "Rodriguez",
    TipoDocumento = "CC",
    NroDocumento = "12345678",
    Email = "GermanRodriguez@gmail.com",
    Telefono = "123456789",
    NombreAcudiente = "Maria",
    CursoActual = "Fisica",
    FechaNacimiento = new DateOnly(2006, 10, 15),
    Calificaciones = new List<double> { 4.5, 6.5 }
});

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 5,
    Nombre = "Carlos",
    Apellidos = "Rodriguez",
    TipoDocumento = "CC",
    NroDocumento = "12345678",
    Email = "CarlosRodriguez@gmail.com",
    Telefono = "123456789",
    NombreAcudiente = "Maria",
    CursoActual = "Matematicas",
    FechaNacimiento = new DateOnly(2006, 10, 3),
    Calificaciones = new List<double> { 6.5, 7.9, 9.5 }
});
/*
administradorApp.Estudiantes[0].CalcularPromedio();
Console.WriteLine($"Promedio: " +administradorApp.Estudiantes[0].CalcularPromedio());
*/

bool seguir = true;
while (seguir)
{   
    Console.Clear();

    administradorApp.InterfazVisual();
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            administradorApp.AgregarProfesorNuevo();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 2:
            administradorApp.AgregarEstudianteNuevo();
            break;
        case 3:
            administradorApp.MostrarProfesores();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 4:
            administradorApp.MostrarEstudiantes();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 5:
            administradorApp.MostrarPromedioSuperior();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 6:
            administradorApp.ObtenerProfesoresConMasCursos();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 7:
            administradorApp.FiltrarEdadEstudiantes();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 8:
            administradorApp.EstudiantesPorApellido();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 9:
            administradorApp.ObtenerSueldos();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 10:
            administradorApp.NotaMayorPorCurso();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 11:
            administradorApp.ProfesoresConMasDe10Años();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 12:
            administradorApp.AsignaturasUnicas();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 13:
            administradorApp.AcudienteEsMaria();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 14:
            administradorApp.ListaSalariosDescencientes();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 15:
            administradorApp.PromedioEdades();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 16:
            administradorApp.ProfesoresMatematicas();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 17:
            administradorApp.CursosConMasDeTresCalificaciones();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 18:
            administradorApp.AntiguedadPromedio();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            break;
        case 19:
            Console.WriteLine("¿Desea salir? s/n");
            string respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                seguir = false;
            }
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}
