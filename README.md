# Lista de Productos en CSharp 
Lista de productos con el uso de C# .NET v8.0, aplicando el MVC y CRUD

## ChangeLogs
### Version 1.0

- Funciones basicas de **Create, Read, Update y Delete**
- Funciones adicionales como **Descargar** lista en Excel y la **Fecha**

### Version 1.0.1

- Placeholder en los TextBox de **Item y Precio**
- Se elimino el cursor de click en los iconos de **Item y Precio** 
- Se cambio el Size de From y se ajusto el ancho de las columnas
- Se agrego nueva funcion de TablaReset con **Truncate**
- Se agrego un Logo Icon
- Se agrego cambios **ItemtbE y PreciotbE**, cuando se edita se desbloquea el textbox
- Se agrego movimiento al WinForm
- Se agrego el boton de **Minimizar**

## Conexion a SQL SERVER

Se debe cambiar los nombre dependiendo de su SQL SERVER en el archive
*conexiondb.cs*

```csharp
string conexionpathURL = "Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true";
private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true");
```

Cambiar el *DESKTOP-MFBH1RN* por el nombre de su SQL SERVER y *objetos* por el nombre del objeto