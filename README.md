# Lista de Productos en CSharp 
Lista de productos con el uso de C# .NET v8.0, aplicando el MVC y CRUD.\
Una practica basica de conexion entre SQL SERVER EXPRESS y CSharp con listas de productos para negocios

Es un proyecto de practica por lo cual siempre habra **Errores** y se hara reparaciones de **Bugs** si hace falta.

## ChangeLogs
### Version 1.0

- Funciones basicas de **Create, Read, Update y Delete**
- Funciones adicionales como **Descargar** lista en Excel
- La **Fecha** en label abajo de la lista

### Version 1.0.1

- Placeholder en los TextBox de **Item y Precio**
- Se elimino el cursor de click en los iconos de **Item y Precio** 
- Se cambio el Size de From y se ajusto el ancho de las columnas
- Se agrego nueva funcion de TablaReset con **Truncate**
- Se agrego un Logo Icon
- Se agrego cambios **ItemtbE y PreciotbE**, cuando se edita se desbloquea el textbox
- Se agrego movimiento al WinForm
- Se agrego el boton de **Minimizar**

### Version 2.0

- Nuevo diseño de Interfaz
- Implemento de Menu
- Se agrego el Interfaz de **Comprimir** 
- Se migro el **Form** de Listas de Items a **User Controls**
- Se agrego la funcion de **Comprimir** archivos a carpeta *.zip*

## Conexion a SQL SERVER

Se debe cambiar los nombre dependiendo de su SQL SERVER en el archive
*conexiondb.cs*

```csharp
string conexionpathURL = "Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true";
private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true");
```

Cambiar el *DESKTOP-MFBH1RN* por el nombre de su SQL SERVER y *objetos* por el nombre del objeto

## SQL SERVER EXPRESS

- Se uso **Windows Authentication** como autenticador
- La carpeta DATA se coloca en la ruta de *C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL*, donde se guarda todos los base de datos (Si por alguna razon no es posible guardar el archivo, parar el servicio de SQL SERVER EXPRESS)
- Los archivos de **objetos.sql** y **Solution1.ssmssln** se coloca en la ruta de *C:\Documents\SQL Server Management Studio\* 
