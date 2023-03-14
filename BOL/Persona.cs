using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using ENTITIES;

namespace BOL
{
    public class Persona
    {


        DBAccess acceso = new DBAccess();

        public void registrarClientes(Epersonas eclientes)
        {
            SqlCommand command = new SqlCommand("SPU_CLIENTE_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();


            command.Parameters.AddWithValue("@apellidos", eclientes.apellidos);
            command.Parameters.AddWithValue("@nombres", eclientes.nombres);
            command.Parameters.AddWithValue("@dni", eclientes.dni);

            command.ExecuteNonQuery();
            acceso.desconectar();


        }

     
    }
}
