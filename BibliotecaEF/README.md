# BibliotecaEF

Aplicación de consola desarrollada en C# para administrar autores, categorías y libros.

## Funcionalidades

- Registrar autores.
- Modificar el nombre de autores existentes.
- Registrar categorías.
- Registrar libros asociados a un autor y una categoría.
- Visualizar autores, categorías y libros.
- Mostrar el título, año, autor y categoría de cada libro.
- Modificar el título de un libro.
- Eliminar libros de forma lógica.
- Mostrar únicamente los libros activos.
- Persistir los datos mediante Entity Framework Core y SQLite.

## Estructura

La solución contiene dos proyectos:

- `AccesoDatos`: modelos, contexto, repositorios y migraciones.
- `AppConsola`: aplicación de consola y menú principal.

## Tecnologías

- .NET 10
- C#
- Entity Framework Core 10
- SQLite

## Entidades

- `Autor`: un autor puede tener varios libros.
- `Categoria`: una categoría puede contener varios libros.
- `Libro`: pertenece a un único autor y a una única categoría.

## Eliminación lógica

Los libros contienen la propiedad:

```csharp
public bool Activo { get; set; } = true;
```

Al eliminar un libro, el registro no se borra de la base de datos. Su propiedad `Activo` cambia a `false`.

La opción `Ver Libros` utiliza un filtro para mostrar solamente libros activos:

```csharp
.Where(libro => libro.Activo)
```

## Restaurar el proyecto

Desde la carpeta `BibliotecaEF`, ejecutar:

```powershell
dotnet restore
```

## Aplicar las migraciones

```powershell
dotnet ef database update --project .\AccesoDatos\AccesoDatos.csproj --startup-project .\AppConsola\AppConsola.csproj
```

La aplicación también aplica automáticamente las migraciones pendientes al iniciarse.

## Ejecutar

```powershell
dotnet run --project .\AppConsola\AppConsola.csproj
```

## Menú

```text
1. Alta Autor
2. Alta Categoría
3. Alta Libro
4. Ver Autores
5. Ver Categorías
6. Ver Libros
7. Modificar Libro
8. Eliminar Libro
9. Modificar Autor
0. Salir
```