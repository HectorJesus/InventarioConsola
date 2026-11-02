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

int opc = -1;

while(opc != 0)
{
    Console.WriteLine("=====Inventrario=====");
    Console.WriteLine("1. Ver todos los equipos");
    Console.WriteLine("2. Buscar por sala");
    Console.WriteLine("3. Agregar equipo");
    Console.WriteLine("4. Eliminar equipo");
    Console.WriteLine("0. Salir");
    opc = int.TryParse(Console.ReadLine(), out opc) ? opc : -1;

    switch(opc)
    {
        case 1:
            Console.WriteLine("=====Equipos=======");
            foreach (var e in equipos)
            {
                Console.WriteLine($"{e.ID} - {e.Nombre} - {e.Sala} - {e.Tipo}");
            }
            break;
        case 2:
            Console.WriteLine("Ingrese la sala a buscar:");
            string sala = Console.ReadLine() ?? string.Empty;
            var equiposSala = equipos.Where(e => e.Sala == sala);
            foreach (var e in equiposSala)
            {
                Console.WriteLine($"{e.ID} - {e.Nombre} - {e.Sala} - {e.Tipo}");
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el nombre del equipo:");
            string nombre = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Ingrese la sala del equipo:");
            string nuevaSala = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Ingrese el tipo del equipo:");
            string tipo = Console.ReadLine() ?? string.Empty;

            int nuevoID = equipos.Max(e => e.ID) + 1;
            equipos.Add(new Equipo { ID = nuevoID, Nombre = nombre, Sala = nuevaSala, Tipo = tipo });
            Console.WriteLine("Equipo agregado exitosamente.");
            break;
        case 4:
            Console.WriteLine("Ingrese el ID del equipo a eliminar:");
            int idEliminar = int.TryParse(Console.ReadLine(), out idEliminar) ? idEliminar : 0;
            var equipoAEliminar = equipos.FirstOrDefault(e => e.ID == idEliminar);
            if (equipoAEliminar != null)
            {
                equipos.Remove(equipoAEliminar);
                Console.WriteLine("Equipo eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un equipo con ese ID.");
            }
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }

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
