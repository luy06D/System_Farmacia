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

            public void registrarVentas(EVentas eVentas , DataTable detalleVenta)
            {
                SqlCommand sqlCommand = new SqlCommand("SPU_VENTA_REGISTRAR", acceso.getConexion());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                acceso.conectar();

                sqlCommand.Parameters.AddWithValue("@idcliente", eVentas.ocliente);
                sqlCommand.Parameters.AddWithValue("@idusuario", eVentas.ousuario);
                sqlCommand.Parameters.AddWithValue("@idempresa", eVentas.oempresa);
                sqlCommand.Parameters.AddWithValue("@tipocomprobante", eVentas.tipoComprobante);
                sqlCommand.Parameters.AddWithValue("@detalleVenta", detalleVenta);

                sqlCommand.ExecuteNonQuery();
                acceso.desconectar();


            }












            
            public DataTable buscarProducto(int idproducto){
                DataTable data = new DataTable();
                SqlCommand command = new SqlCommand(" ", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idproducto", idproducto);
                acceso.conectar();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                acceso.desconectar();
                return data;
            }

    
            public int eliminarProductos(int idproducto){
                int eliminarProductos = 1;
                acceso.conectar();
                SqlCommand sqlCommand = new SqlCommand(" ", acceso.getConexion());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@idproducto", idproducto);
                acceso.desconectar();
                return eliminarProductos;
            }

            public DataTable buscarPersona(int dni)
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
