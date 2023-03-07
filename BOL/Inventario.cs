using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Inventario
    {
        DBAccess acceso = new DBAccess();
        public DataTable listarProductos()
        {
            return acceso.getDataGrid("SPU_PRODUCTOS_LISTAR", 1);
        }

        public DataTable listarInventario()
        {
            DataTable dataTable = new DataTable();
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_COMPRAS_LISTAR", acceso.getConexion());
            adapter.Fill(dataTable);
            acceso.desconectar();
            return dataTable;
        }



        public void editarInventario(int idpersona, string cantidad)
        {
            SqlCommand command = new SqlCommand("SPU_INVENTARIO_ACTUALIZAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("@idpersona", idpersona);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.ExecuteNonQuery();
            acceso.desconectar();
        }
    }
}
