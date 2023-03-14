using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Input;
using ENTITIES;

namespace BOL
{
    public class Usuario
    {
        public static string eusuario;
        DBAccess acceso = new DBAccess();
        public DataTable iniciarSesion(Eusuarios eusuarios)
        {
            DataTable dataTable = new DataTable();
            acceso.conectar();
            SqlCommand command = new SqlCommand("spu_usuarios_login", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nomusuarios", eusuarios.nomusuarios);

            dataTable.Load(command.ExecuteReader());

            acceso.desconectar();

            return dataTable;
        }

        

    }
}
