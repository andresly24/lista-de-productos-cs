using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Conexiondb
    {

        string conexionpathURL = "Server=DESKTOP-MFBH1RN\\\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;\" + \"TrustServerCertificate=true";
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-MFBH1RN\\SQLEXPRESS;Database=objetos;Trusted_Connection=True;" + "TrustServerCertificate=true");
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed) 
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public string ConexionPathURL
        {
            get { return conexionpathURL; }
        }
    }
}
