using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITIES;
using System.Web;
using System.Net.Http.Headers;

namespace BOL{
    public class Ventas
    {
       
        DBAccess acceso = new DBAccess();
        

            public DataTable listar(){
                return acceso.getDataGrid("", 1);
            }

            public void registrarVentas(EVentas eVentas, Edetalle_venta eDetalle)
            {
                SqlCommand sqlCommand = new SqlCommand("SPU_REGISTRAR_VENTA", acceso.getConexion());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                acceso.conectar();

                sqlCommand.Parameters.AddWithValue("@idcliente", eVentas.idcliente);
                sqlCommand.Parameters.AddWithValue("@idusuario", eVentas.idusuario);
                sqlCommand.Parameters.AddWithValue("@idempresa", eVentas.idempresa);
                sqlCommand.Parameters.AddWithValue("@tipocomprobante", eVentas.tipoComprobante);
                sqlCommand.Parameters.AddWithValue("@idventa", eDetalle.idventa);
                sqlCommand.Parameters.AddWithValue("@idproducto", eDetalle.idproducto);
                sqlCommand.Parameters.AddWithValue("@cantidad", eDetalle.cantidad);
                sqlCommand.Parameters.AddWithValue("@unidad",eDetalle.unidad);
                sqlCommand.Parameters.AddWithValue("@precioventa",eDetalle.precioVenta);

                sqlCommand.ExecuteNonQuery();
                acceso.desconectar();

            
            }

            public DataTable buscarPersona(string dni)
            {
                DataTable data = new DataTable();
                SqlCommand command = new SqlCommand("SPU_PERSONAS_BUSCAR", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@dni", dni);

                acceso.conectar();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                acceso.desconectar();

                return data;
            }

            public DataTable buscarEmpresa(string ruc)
            {
                DataTable data = new DataTable();
                SqlCommand command = new SqlCommand("SPU_EMPRESAS_BUSCAR", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ruc", ruc);

                acceso.conectar();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                acceso.desconectar();

                return data;

            }
            
           


    }
}
