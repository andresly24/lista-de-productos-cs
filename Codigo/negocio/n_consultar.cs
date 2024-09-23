using datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_consultar
    {
        private D_consultar objetos = new D_consultar();

        public DataTable mostrarp()
        {
            DataTable tabla = new DataTable();
            tabla = objetos.Mostrar();
            return tabla;
        }

        public void insertarp (string item, string precio) 
        {
            objetos.Insertar(item,Convert.ToDouble(precio));
        }
        public void editarp(string id,string item, string precio)
        {
            objetos.Editar(Convert.ToInt32(id),item, Convert.ToDouble(precio));
        }

        public void eliminarp(string id) 
        {
            objetos.Eliminar(Convert.ToInt32(id));
        }

        public void descargarp()
        {
            objetos.Descargar();
        }
    }
}
