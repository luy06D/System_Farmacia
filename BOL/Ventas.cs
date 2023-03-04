using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using ENTITIES;
using System.Net.Http.Headers;

namespace BOL
{
    public class Ventas
    {
        DBAccess acceso = new DBAccess();


        public DataTable listar()
        {
            return acceso.getDataGrid("", 1);
        }


        public int registrarVentas(EVentas entidad)
        {


            int registrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@nombreProducto", entidad.nombreProducto);
            sqlCommand.Parameters.AddWithValue("@descripcion", entidad.descripcion);
            sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
            sqlCommand.Parameters.AddWithValue("@cantidad", entidad.cantidad);
            sqlCommand.Parameters.AddWithValue("@fechaVencimiento", entidad.fechaVencimiento);
            sqlCommand.Parameters.AddWithValue("@recetaMedica", entidad.recetaMedica);

            acceso.desconectar();

            return registrosAfectados;

        }
    }

  
}
