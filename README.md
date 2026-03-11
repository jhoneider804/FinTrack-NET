# FinTrack-NET

API base de `FinTrack` construida con `ASP.NET Core Web API`.

## Requisitos

- `NET SDK 10.0` o superior
- `Git`

## Estructura del repositorio

- `src/FinTrack.Api/`: proyecto Web API
- `FinTrack-NET.slnx`: solución

## Restaurar y ejecutar

Desde la raíz del repositorio (`C:\FindTrack`):

1. Restaurar paquetes:

   `dotnet restore src/FinTrack.Api/FinTrack.Api.csproj`

2. Ejecutar la API:

   `dotnet run --project src/FinTrack.Api/FinTrack.Api.csproj`

## Endpoint inicial

- `GET /weatherforecast`

Si se ejecuta en entorno de desarrollo, la documentación OpenAPI queda disponible en el endpoint configurado por `MapOpenApi()`.

## Notas

- La carpeta `CopilotIndices/` está ignorada por Git.
- La carpeta `.vs/` está ignorada por Git.
