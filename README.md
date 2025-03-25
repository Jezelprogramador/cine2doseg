**cine2doseg API**
cine2doseg es una API RESTful desarrollada con ASP.NET Core para gestionar la información de sucursales de un cine. Este proyecto interactúa con una base de datos MySQL y proporciona endpoints para obtener y gestionar las sucursales de un cine.

Descripción
Este proyecto consta de dos partes principales:

Base de datos MySQL:

Una base de datos llamada cine para almacenar información sobre las sucursales de un cine.

Tabla sucursal que contiene detalles como nombre, dirección, URL del sitio web y logo.

Procedimientos almacenados y vistas para facilitar la manipulación de datos.

API Web en ASP.NET Core:

Exposición de endpoints que permiten obtener y agregar sucursales de cine.

Uso de Model-View-Controller (MVC) y dependencias para la gestión de la lógica de negocio.

Características
Base de datos:
Creación de la base de datos cine con la tabla sucursal.

Implementación de una vista vwRptSucursales para listar todas las sucursales.

Procedimiento almacenado spInsSucursales para insertar nuevas sucursales, con validaciones para evitar nombres o URLs duplicados.

API:
Endpoint GET /cine/sucursal/vwrptsucursales para obtener todas las sucursales.

Endpoint POST /cine/sucursal/spinssucursales para insertar una nueva sucursal, con respuestas basadas en el resultado de la inserción.
