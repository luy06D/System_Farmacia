using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BOL
{
    public class Ventas
    {
        DBAccess acceso = new DBAccess();

        public DataTable buscarProducto(int idproducto)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idproducto", idproducto);

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            acceso.desconectar();
            return data;
        }

    }
}
