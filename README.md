KING TECHNOLOGY – Sistema de Gestión de Productos
Curso: Programación II
Carrera: Ingeniería en Sistemas de Información
Estudiante: Leony Hidalgo Martínez
Universidad: Universidad Internacional San Isidro Labrador (UISIL)

1. Descripción del sistema
KING TECHNOLOGY es una aplicación de escritorio desarrollada como proyecto del curso Programación II. Está pensada para administrar una pequeña tienda de tecnología y permite gestionar las categorías y los productos que ofrece el negocio.

La información se almacena en una base de datos de Microsoft SQL Server. Desde la aplicación se pueden registrar, consultar, modificar y eliminar categorías y productos. También se pueden buscar productos por nombre y consultar el valor del inventario de cada uno.

2. Objetivo
Desarrollar una aplicación de escritorio que permita administrar categorías y productos mediante una interfaz gráfica, aplicando programación orientada a objetos, separación por capas, validaciones y conexión con una base de datos relacional.

3. Tecnologías utilizadas
- Lenguaje: C#.
- Interfaz gráfica: Windows Forms.
- Entorno de desarrollo: Visual Studio.
- Base de datos: Microsoft SQL Server.
- Administración de la base de datos: SQL Server Management Studio (SSMS).
- Control de versiones y repositorio: Git y GitHub.
- 
4. Funcionalidades principales
4.1. Menú principal
Al iniciar la aplicación se muestra el menú principal de KING TECHNOLOGY. Desde ahí se puede abrir el formulario de gestión de categorías, abrir el formulario de gestión de productos o salir del sistema.
4.2. Gestión de categorías
El formulario de categorías permite:
- Registrar una categoría.
- Consultar las categorías registradas en una tabla.
- Seleccionar una categoría para modificarla.
- Eliminar una categoría después de solicitar confirmación.
- Limpiar los campos del formulario.
Cada categoría tiene un identificador, un nombre y una descripción.
4.3. Gestión de productos
El formulario de productos permite:
- Registrar productos y asignarles una categoría.
- Consultar los productos registrados mediante un DataGridView.
- Seleccionar un producto para modificar sus datos.
- Eliminar productos después de solicitar confirmación.
- Buscar productos por nombre.
- Limpiar los campos del formulario.
Para registrar un producto se solicita el nombre, el precio, el stock y la categoría correspondiente. La fecha de registro se asigna automáticamente.
4.4. Valor del inventario
La aplicación calcula el valor del inventario de cada producto con la siguiente operación:

Valor del inventario = Precio × Stock

Este valor se calcula desde la aplicación y no se guarda como una columna adicional en la base de datos.
4.5. Validaciones y mensajes
El sistema valida los datos antes de guardar o modificar un producto. Entre las validaciones se encuentran:
- Los campos obligatorios no deben quedar vacíos.
- El precio debe ser un número válido y mayor que cero.
- El stock debe ser un número entero igual o mayor que cero.
- Se debe seleccionar una categoría.
Se utiliza ErrorProvider para señalar campos que requieren corrección y MessageBox para informar operaciones exitosas, errores, resultados de búsqueda y confirmaciones de eliminación.

5. Base de datos
La base de datos utilizada por el proyecto se llama KingTechnologyDB y contiene como máximo dos tablas principales:
5.1. Tabla Categorias
Los campos de esta tabla son:
- IdCategoria: identificador único de cada categoría. Es la clave primaria.
- Nombre: nombre de la categoría.
- Descripcion: descripción de la categoría.
5.2. Tabla Productos
Los campos de esta tabla son:
- IdProducto: identificador único de cada producto. Es la clave primaria.
- Nombre: nombre del producto.
- Precio: precio unitario del producto.
- Stock: cantidad disponible del producto.
- FechaRegistro: fecha en que se registra el producto.
- IdCategoria: identificador de la categoría a la que pertenece el producto.
La tabla Productos contiene una llave foránea (IdCategoria) que referencia Categorias.IdCategoria. De esta manera, cada producto queda relacionado con una categoría existente.

6. Estructura de los archivos y programación por capas
El código se organiza en carpetas para separar las responsabilidades de la aplicación:
Proyecto_Sistema_KING-TECHNOLOGY/
│
├── Interfaz_KING_TECH/
│   ├── Datos/
│   │   ├── Conexion.cs
│   │   ├── CategoriaDatos.cs
│   │   └── ProductoDatos.cs
│   │
│   ├── Logica/
│   │   ├── CategoriaLogica.cs
│   │   └── ProductoLogica.cs
│   │
│   ├── Modelos/
│   │   ├── Categoria.cs
│   │   └── Producto.cs
│   │
│   ├── Interfaz/
│   │   ├── FrmPrincipal.cs
│   │   ├── FrmCategorias.cs
│   │   └── FrmProductos.cs
│   │
│   └── Archivos de solución y proyecto de Visual Studio
│
├── Script/
│   └── Archivo SQL de creación de la base de datos y datos de prueba
│
├── .gitignore
└── README.md
Las responsabilidades principales son:
- Interfaz: contiene los formularios y controles con los que interactúa el usuario. Recibe los datos y muestra los resultados.
- Logica: contiene los métodos y reglas que coordinan las operaciones del sistema y las validaciones.
- Datos: contiene la conexión con SQL Server y las operaciones para consultar, insertar, modificar y eliminar registros.
- Modelos: contiene las clases que representan las entidades Categoria y Producto, con sus propiedades.
- Script: contiene el archivo SQL necesario para crear la base de datos y cargar datos iniciales.
Esta separación permite mantener el código más ordenado y evita concentrar todo el funcionamiento del programa dentro de los eventos de los botones.

7. Requisitos para ejecutar el sistema
   
Para ejecutar el proyecto en otra computadora se necesita:
1. Windows.
2. Visual Studio con el componente de desarrollo de escritorio de .NET y soporte para Windows Forms.
3. La versión de .NET o .NET Framework que indique el proyecto de Visual Studio.
4. Microsoft SQL Server, por ejemplo SQL Server Express.
5. SQL Server Management Studio (SSMS) para ejecutar y administrar el script de la base de datos.
La versión exacta de .NET se puede revisar en las propiedades del proyecto de Visual Studio. El servidor SQL Server puede tener un nombre de instancia diferente en cada computadora.

8. Instrucciones para crear la base de datos
   
1. Instalar y abrir SQL Server Management Studio.
2. Conectarse a la instancia local de SQL Server.
3. Abrir el archivo SQL que se encuentra en la carpeta Script del repositorio.
4. Revisar que el script corresponda a la base de datos KingTechnologyDB.
5. Ejecutar el script para crear la base de datos, las tablas y los datos de prueba.
6. En el Explorador de objetos de SSMS, actualizar la carpeta Bases de datos y comprobar que aparezca KingTechnologyDB con las tablas Categorias y Productos.
   
9. Configuración de la conexión con SQL Server
La conexión se configura en el archivo Conexion.cs, ubicado en la carpeta Datos del proyecto.

Para ejecutar la aplicación en otra computadora, se debe revisar la cadena de conexión y ajustar el nombre del servidor o de la instancia de SQL Server. El nombre de la base de datos debe mantenerse como KingTechnologyDB, salvo que también se cambie en el proyecto.

10. Instrucciones para ejecutar el sistema
    
1. Descargar o clonar el repositorio desde GitHub.
2. Abrir la carpeta Interfaz_KING_TECH y localizar el archivo de solución (.sln) de Visual Studio.
3. Abrir la solución en Visual Studio.
4. Confirmar que la base de datos KingTechnologyDB ya fue creada y que la cadena de conexión de Conexion.cs apunta a la instancia local correcta.
5. En Visual Studio, compilar la solución.
6. Ejecutar el proyecto con F5 o con el botón de inicio.
7. En el menú principal, seleccionar Gestión de categorías o Gestión de productos para utilizar cada módulo.

11. Uso de inteligencia artificial generativa

Durante el desarrollo del proyecto KING TECHNOLOGY se utilizo herramientas de inteligencia artificial generativa y fueronChat gtp y Claude, principalmente como apoyo para resolver dudas, entender conceptos y facilitarme el aprendizaje de diferentes temas, Estas herramientas fueron de ayuda en el uso de C#, Windows Forms y Visual Studio, especialmente para comprender la conexión entre la aplicación y SQL Server, realizar operaciones con la base de datos y trabajar con los controles y eventos de los formularios. También sirvieron como orientación para organizar las carpetas y clases del proyecto, aplicar la programación por capas y aprender a utilizar Git y GitHub para guardar y administrar los avances. Además, se utilizaron para interpretar errores, conocer posibles soluciones y comprender funciones y procedimientos que no se dominaban por completo. Las recomendaciones y ejemplos obtenidos fueron revisados, adaptados y probados durante el desarrollo del sistema. La inteligencia artificial se utilizó como herramienta de consulta y aprendizaje para reforzar los conocimientos adquiridos durante el curso, manteniendo la responsabilidad de comprender el funcionamiento del código y poder explicar el sistema durante la defensa.

12. Autoría y alcance
Este proyecto fue desarrollado como parte de la evaluación del curso Programación II. Su propósito es poner en práctica los contenidos del curso mediante una aplicación de escritorio que utiliza C#, Windows Forms, programación orientada a objetos, programación por capas y SQL Server.


