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


        public DataTable getdataPersona()
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_PERSONAS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            data.Load(command.ExecuteReader());

            acceso.desconectar();                   
            return data;
        }



        public void registrarPersonas(Epersonas epersonas)
        {
            SqlCommand command = new SqlCommand("SPU_PERSONAS_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();

            
            command.Parameters.AddWithValue("@apellidos", epersonas.apellidos);
            command.Parameters.AddWithValue("@nombres", epersonas.nombres);
            command.Parameters.AddWithValue("@dni", epersonas.dni);
            command.Parameters.AddWithValue("@telefono", epersonas.telefono);

            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public DataTable listarPersonas()
        {
            DataTable data = new DataTable();
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_PERSONAS_LISTAR", acceso.getConexion());
            adapter.Fill(data);
            acceso.desconectar();
            return data;

        }

    }
}
