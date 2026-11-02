# InventarioConsola

App de consola en C# (.NET 10) para manejar un inventario de equipos de TI
(proyectores, audio, switches) por sala.

## Qué hace
- Define un modelo `Equipo` (Id, Nombre, Tipo, Sala).
- Lista todos los equipos del inventario.
- Filtra equipos por tipo usando LINQ.

## Cómo correrlo
1. Instala el [SDK de .NET 10](https://dotnet.microsoft.com/download).
2. Clona el repo y entra a la carpeta.
3. Corre `dotnet run`.

## Próximos pasos
- Menú interactivo (agregar, buscar y eliminar equipos).
- Convertirlo en una Web API con ASP.NET Core y Entity Framework Core.
- Guardar los datos en SQL Server.
