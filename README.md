📊 Evaluación Práctica — ASP.NET Core MVC

Este proyecto fue desarrollado en apego a los requerimientos definidos en una evaluación práctica, con el objetivo de demostrar la capacidad para construir una aplicación web utilizando ASP.NET Core MVC, Entity Framework Core y Razor Views.

La solución implementa un CRUD completo de clientes, siguiendo el patrón clásico de aplicaciones MVC renderizadas del lado del servidor (Server-Side Rendering).

🧠 Objetivo de la evaluación

Demostrar dominio en:

ASP.NET Core MVC

Entity Framework Core

Razor Views

Manejo correcto de formularios HTTP (GET/POST)

Protección contra overposting y CSRF

Organización limpia del código y separación de responsabilidades

🧱 Arquitectura de la aplicación
/Controllers     → Lógica HTTP y flujo MVC
/Views           → Razor Views (UI renderizada en servidor)
/Entity          → Entidades del modelo (Cliente)
/AppDb_Context   → Configuración de Entity Framework


La aplicación sigue el patrón Model–View–Controller tradicional, donde el servidor genera las vistas y maneja el estado.

🗂️ Funcionalidad implementada

Se implementa un CRUD completo sobre la entidad Cliente:

Registro de clientes

Visualización de lista

Consulta de detalles

Edición de información

Eliminación de registros

📡 Rutas reales de la aplicación
Método	Ruta	Descripción
GET	/Clientes	Lista de clientes
GET	/Clientes/Details/{id}	Ver detalle
GET	/Clientes/Create	Formulario de alta
POST	/Clientes/Create	Crear cliente
GET	/Clientes/Edit/{id}	Formulario de edición
POST	/Clientes/Edit/{id}	Guardar cambios
GET	/Clientes/Delete/{id}	Confirmación de borrado
POST	/Clientes/Delete/{id}	Eliminar cliente
🛠️ Tecnologías utilizadas
Tecnología	Uso
ASP.NET Core MVC	Framework web
Razor Views	Renderizado del lado del servidor
Entity Framework Core	Acceso a datos
SQL Server	Persistencia
C#	Lenguaje principal
🔐 Buenas prácticas aplicadas

Protección contra overposting con [Bind]

Protección CSRF con [ValidateAntiForgeryToken]

Acceso asíncrono a datos con EF Core

Separación clara entre capas MVC

Manejo correcto de validaciones con ModelState

🚀 Cómo ejecutar
git clone https://github.com/orodrimez/Evaluacion_Practica.git
cd Evaluacion_Practica
dotnet run


Abrir en navegador:

https://localhost:{puerto}/Clientes

📱 Responsive Web Design

Las vistas fueron implementadas bajo un enfoque de Responsive Web Design, permitiendo el uso correcto de la aplicación en dispositivos móviles, tablets y escritorio.
