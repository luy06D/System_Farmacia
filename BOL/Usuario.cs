using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Input;

namespace BOL
{
    public class Usuario
    {
        DBAccess acceso = new DBAccess();
        public DataTable iniciarSesion(string nombreUsuario ,string claveacceso)
        {
            DataTable dataTable = new DataTable();
            acceso.conectar();
            SqlCommand command = new SqlCommand( "" ,acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombreusuario", nombreUsuario);
            command.Parameters.AddWithValue("@claveacceso", claveacceso);

            dataTable.Load(command.ExecuteReader());

            acceso.desconectar();

            return dataTable;
        }

    }
}
