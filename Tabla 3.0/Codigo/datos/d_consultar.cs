using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace datos
{
    public class D_consultar
    {
        private Conexiondb conexion = new Conexiondb();

        SqlDataReader leer;
        
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();          
            comando.CommandText = "MostrarItems";
            comando.CommandType = CommandType.StoredProcedure;
            using (var leer = comando.ExecuteReader())
            {
                tabla.Load(leer);
            }
            
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string item, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarItems";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@item",item);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int id,string item, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarItems";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@item", item);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarItems";
            comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@iditem", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void ResetTable()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ResetTable";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Descargar()
        {
            string conexionpath = conexion.ConexionPathURL;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "lista_de_productos.xlsx");
            var query = "SELECT * FROM objetos";

            try
            {
                using (SqlConnection conexion2 = new SqlConnection(conexionpath))
                {
                    conexion2.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion2);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable datatabla = new DataTable();
                    adapter.Fill(datatabla);

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Info");
                        worksheet.Cell(1, 1).InsertTable(datatabla);
                        workbook.SaveAs(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
