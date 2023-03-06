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
    public class Ventas{
        DBAccess acceso = new DBAccess();
            public DataTable listar(){
                return acceso.getDataGrid("", 1);
            }

            public int registrarVentas(EVentas entidad){
                int registrosAfectados = 0;
                acceso.conectar();
                SqlCommand sqlCommand = new SqlCommand("", acceso.getConexion());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@nombreProducto", entidad.nombreProducto);
                sqlCommand.Parameters.AddWithValue("@descripcion", entidad.descripcion);
                sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
                sqlCommand.Parameters.AddWithValue("@cantidad", entidad.cantidad);
                sqlCommand.Parameters.AddWithValue("@fechaVencimiento", entidad.fechaVencimiento);
                sqlCommand.Parameters.AddWithValue("@recetaMedica", entidad.recetaMedica);
                acceso.desconectar();
                return registrosAfectados;
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

            public int actualizarProductos(EVentas entidad){
                int actualizarproducto = 0;
                acceso.conectar();
                SqlCommand sqlCommand = new SqlCommand(" ", acceso.getConexion());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@nombreProducto", entidad.nombreProducto);
                sqlCommand.Parameters.AddWithValue("@descripcion", entidad.descripcion);
                sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
                sqlCommand.Parameters.AddWithValue("@cantidad", entidad.cantidad);
                sqlCommand.Parameters.AddWithValue("@fechaVencimiento", entidad.fechaVencimiento);
                acceso.desconectar();
                return actualizarproducto;
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
        }
    }
