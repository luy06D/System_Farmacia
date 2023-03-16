using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITIES;
using DAL;

namespace BOL
{
    public class Empresa
    {
        DBAccess acceso = new DBAccess();


        public void registrarEmpresa(Eempresa eempresa)
        {
            SqlCommand command = new SqlCommand("SPU_EMPRESA_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();

            command.Parameters.AddWithValue("@nombre", eempresa.nombre);
            command.Parameters.AddWithValue("@ruc", eempresa.ruc);

            command.ExecuteNonQuery();
            acceso.desconectar();
        }


        public DataTable getdataEmpresa()
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_EMPRESAS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            data.Load(command.ExecuteReader());

            acceso.desconectar();
            return data;
        }



    }
}
