# cine2doseg API

**cine2doseg** es una API RESTful desarrollada con ASP.NET Core para la gestión de sucursales de cines.

## Descripción

* **Base de datos MySQL**:
  * Base de datos: `cine`
  * Tabla principal: `sucursal`
    * Campos: nombre, dirección, URL, logo
  * Vista: `vwRptSucursales`
  * Stored Procedure: `spInsSucursales`

* **API ASP.NET Core**:
  * Arquitectura MVC
  * Patrón Repository
  * Endpoints RESTful

## Características principales

### Base de datos
* Estructura relacional optimizada
* Validaciones de integridad
* Vistas para consultas complejas
* Stored procedures para operaciones críticas

### API
* Documentación Swagger integrada
* Manejo centralizado de errores
* Validación de modelos
* Soporte para CORS

## Configuración

1. **Requisitos**:
   * .NET 6.0+
   * MySQL 8.0+
   * Visual Studio 2022 (opcional)

2. **Pasos de instalación**:
   * Clonar repositorio
   * Configurar connection string
   * Ejecutar migraciones
   * Iniciar aplicación

## Endpoints

| Método | Endpoint                | Descripción                 |
|--------|-------------------------|-----------------------------|
| GET    | /api/sucursales         | Listar todas las sucursales |
| POST   | /api/sucursales         | Crear nueva sucursal        |
| GET    | /api/sucursales/{id}    | Obtener sucursal específica |
| PUT    | /api/sucursales/{id}    | Actualizar sucursal         |
| DELETE | /api/sucursales/{id}    | Eliminar sucursal           |
