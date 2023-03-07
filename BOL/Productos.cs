using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DAL;

namespace BOL
{



    public class Productos
    {

        DBAccess acceso = new DBAccess();

        public void registrarProductos(
            int idlaboratorio, int idcategoria, string nombreproducto, string descripcion,
            string cantidad, string precio, string fechaproduccion, string fechavencimiento,
            string numlote, string recetamedica)
        {
            SqlCommand command = new SqlCommand("",acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();

            command.Parameters.AddWithValue("@idlaboratorio", idlaboratorio);
            command.Parameters.AddWithValue("@idcategoria", idcategoria );
            command.Parameters.AddWithValue("@nombreproducto", nombreproducto);
            command.Parameters.AddWithValue("@descripcion", descripcion );
            command.Parameters.AddWithValue("@cantidad", cantidad );
            command.Parameters.AddWithValue("@precio", precio );
            command.Parameters.AddWithValue("@fechaproduccion", fechaproduccion );
            command.Parameters.AddWithValue("@fechavencimiento", fechaproduccion );
            command.Parameters.AddWithValue("@numlote", numlote );
            command.Parameters.AddWithValue("@recetamedica", recetamedica );

            command.ExecuteNonQuery();
            acceso.desconectar();
        }
        

    }
}
