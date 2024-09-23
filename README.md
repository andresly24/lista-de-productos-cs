# lista-de-productos-cs
Lista de productos con el uso de C# .NET v8.0, aplicando el MVC y CRUD

## ChangeLogs
### Version 1.0

- Funciones basicas de **Create, Read, Update y Delete**
- Funciones adicionales como **Descargar** lista en Excel y la **Fecha**

## Conexion a SQL SERVER

Se debe cambiar los nombre dependiendo de su SQL SERVER en el archive
*conexiondb.cs*

```csharp
string conexionpathURL = "Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true";
private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true");
```

Cambiar el *DESKTOP-MFBH1RN* por el nombre de su SQL SERVER y *objetos* por el nombre del objeto
