PeopleFlow
PeopleFlow es un sistema de gestión de personas diseñado para manejar tareas, contratos, liquidaciones, vacaciones, bonificaciones y otros aspectos relacionados con la administración de empleados en una empresa. Este sistema incluye funcionalidades para generar documentos en formato PDF y Excel, gestionar datos de empleados, y realizar análisis de productividad y costos laborales.

Características principales
Gestión de empleados:

Registro y consulta de empleados.
Asignación de tareas a empleados.
Gestión de contratos y anexos.
Generación de documentos:

Generación de contratos, finiquitos, liquidaciones y vacaciones en formato PDF.
Exportación de registros de actividades y productividad en formato Excel.
Gestión de tareas:

Registro y seguimiento de tareas asignadas a empleados.
Análisis de productividad mensual y semanal.
Distribución de costos laborales y sueldos.
Gestión de bonificaciones y deducciones:

Registro y consulta de bonificaciones.
Registro y consulta de deducciones.
Configuración y administración:

Gestión de usuarios y roles.
Configuración de archivos de la empresa.
Panel de control con gráficos y estadísticas.
Análisis y reportes:

Análisis de productividad y ausentismo.
Reportes de liquidaciones y finiquitos.
Estructura del proyecto
El proyecto está organizado en las siguientes carpetas principales:

BO (Business Objects): Contiene la lógica de negocio del sistema, como la generación de documentos, cálculos de productividad y manejo de datos.
DAO (Data Access Objects): Maneja la interacción con la base de datos.
DTO (Data Transfer Objects): Define las estructuras de datos utilizadas en el sistema.
Formularios: Contiene las interfaces gráficas del sistema, organizadas por módulos como contratos, tareas, configuraciones, etc.
Tecnologías utilizadas
Lenguaje: C# (.NET Framework)
Base de datos: MySQL
Bibliotecas:
iText.Html2pdf: Para la generación de documentos PDF a partir de plantillas HTML.
ClosedXML: Para la generación de documentos Excel.
NLog: Para el manejo de logs.
PdfPig: Para la lectura y análisis de documentos PDF.
LiveCharts: Para la visualización de gráficos en el panel de control.
Instalación
Clonar el repositorio:

Configurar la base de datos:

Crear una base de datos MySQL.
Importar el archivo SQL proporcionado en el repositorio para configurar las tablas y datos iniciales.
Configurar la conexión a la base de datos en el archivo de configuración del proyecto.
Configurar NLog:

Asegúrate de que el archivo Nlog.config esté correctamente configurado para registrar logs en el sistema.
Ejecutar el proyecto:

Abre el proyecto en Visual Studio.
Configura el proyecto como aplicación de inicio.
Ejecuta el proyecto.
Uso
Gestión de empleados
Navega al módulo de empleados para registrar, consultar y gestionar empleados.
Asigna tareas y contratos a los empleados desde sus respectivos módulos.
Generación de documentos
Genera contratos, finiquitos, liquidaciones y vacaciones desde los módulos correspondientes.
Exporta registros de actividades y productividad en formato Excel.
Configuración
Configura usuarios, roles y archivos de la empresa desde el módulo de configuraciones.
Análisis y reportes
Consulta gráficos y estadísticas en el panel de control.
Genera reportes de productividad, costos laborales y ausentismo.
Contribución
Si deseas contribuir al proyecto:

Haz un fork del repositorio.
Crea una rama para tu funcionalidad o corrección de errores:
Realiza tus cambios y haz un commit:
Envía tus cambios al repositorio remoto:
Crea un Pull Request en GitHub.
Licencia
Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.

Contacto
Si tienes preguntas o sugerencias, no dudes en ponerte en contacto con el equipo de desarrollo a través de jjosemiguel.jv@gmail.com.
