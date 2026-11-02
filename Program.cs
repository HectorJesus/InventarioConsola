//Da valores a la calse equipo
var equipos = new List<Equipo>
{
    new Equipo {ID = 1, Nombre = "Proyector", Sala = "1", Tipo = "Tradicional"},
    new Equipo {ID = 2, Nombre = "Servidor", Sala = "2", Tipo = "4D"},
    new Equipo {ID = 3, Nombre = "Pantalla", Sala = "3", Tipo = "Tradicional"}
};
//Imprime todos los equipos
Console.WriteLine("=====Equipos=======");

foreach (var e in equipos)
{
    Console.WriteLine($"{e.ID} - {e.Nombre} - {e.Sala} - {e.Tipo}");
}

Console.WriteLine();

// Filtra solo proyectores
Console.WriteLine("=====Solo Proyectores=========");

var proyectores = equipos.Where(e => e.Nombre == "Proyector");
foreach (var p in proyectores)
{
    Console.WriteLine($"{p.Nombre} - {p.Sala}");
}
//Inicia la clase equipo
