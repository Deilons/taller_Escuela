using taller_Escuela.Models;

Console.Clear();

var administradorApp = new AdministradorApp();

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 1,
    Nombre = "Juan",
    Apellidos = "Perez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "j@j.com",
    Telefono = "123456789",
    Asignatura = "Programacion",
    Sueldo = 5000,
    FechaContrato = new DateTime(2021, 11, 11),
    Cursos = new List<string> { "Programacion", "Ingles" }
});

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 2,
    Nombre = "Pedro",
    Apellidos = "Lopez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "p@p.com",
    Telefono = "123456789",
    Asignatura = "Programacion",
    Sueldo = 5000,
    FechaContrato = new DateTime(2010, 11, 11),
    Cursos = new List<string> { "Programacion", "Ingles" }
});

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 3,
    Nombre = "Maria",
    Apellidos = "Gonzalez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "m@m.com",
    Telefono = "123456789",
    Asignatura = "Programacion",
    Sueldo = 5000,
    FechaContrato = new DateTime(2021, 11, 11),
    Cursos = new List<string> { "Programacion"}
});
/*
administradorApp.MostrarProfesores();


administradorApp.Profesores[0].ObtenerSueldo();
*/
Console.WriteLine("-----------------------");

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 1,
    Nombre = "Maria",
    Apellidos = "berez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "m@m.com",
    Telefono = "123456789",
    NombreAcudiente = "Pedro",
    CursoActual = "Programacion",
    FechaNacimiento = new DateOnly(2000, 1, 1),
    Calificaciones = new List<double> { 8.5, 9.0, 9.5 }
});

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 2,
    Nombre = "antonio",
    Apellidos = "Gonzalez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "m@m.com",
    Telefono = "123456789",
    NombreAcudiente = "Pedro",
    CursoActual = "Programacion",
    FechaNacimiento = new DateOnly(2010, 1, 1),
    Calificaciones = new List<double> { 8.5, 9.0, 9.5 }
});
administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 3,
    Nombre = "luis",
    Apellidos = "aonzalez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "m@m.com",
    Telefono = "123456789",
    NombreAcudiente = "Pedro",
    CursoActual = "Programacion",
    FechaNacimiento = new DateOnly(2010, 1, 1),
    Calificaciones = new List<double> { 4.5, 4.0, 6.5 }
});
/*
administradorApp.Estudiantes[0].CalcularPromedio();
Console.WriteLine($"Promedio: " +administradorApp.Estudiantes[0].CalcularPromedio());
*/

administradorApp.AsignaturasUnicas();


