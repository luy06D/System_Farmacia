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
using System.Diagnostics;

namespace BOL
{
    public class Ventas
    {
       
        DBAccess acceso = new DBAccess();
        

            public DataTable listar(){
                return acceso.getDataGrid("", 1);
            }

            public int registrarVentas(EVentas eventas)
            {
                SqlCommand command = new SqlCommand("SPU_REGISTRAR_VENTA", acceso.getConexion());
                int idobtenido;

                acceso.conectar();

                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    //Construimos en parametro OUTPUT
                    SqlParameter idventa = new SqlParameter();
                    idventa.ParameterName = "@idventa";
                    idventa.DbType = DbType.Int32;
                    idventa.Direction = ParameterDirection.Output;

                    //Pasamos el parametro de salida
                    command.Parameters.Add(idventa);

                    //Pasamos el parametro de entrada
                    command.Parameters.AddWithValue("@idcliente", eventas.idcliente);
                  //  command.Parameters.AddWithValue("@idusuario", eventas.idusuario);
                  //  command.Parameters.AddWithValue("@idempresa", eventas.idempresa);
                    command.Parameters.AddWithValue("@tipocomprobante", eventas.tipoComprobante);

                    command.ExecuteNonQuery();

                    //Retornamos el id generado convirtiendolo a entero
                    idobtenido = Convert.ToInt32(idventa.Value);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    idobtenido= -1 ;
                }
                finally
                {
                    acceso.desconectar();
                }
          
                return idobtenido;

            }

        public bool registrarDetalleV(Edetalle_venta edetalle)
        {

            bool guardadoCorrectamente = false;
            SqlCommand command = new SqlCommand("SPU_REGISTRAR_DETVENTA", acceso.getConexion());
            acceso.conectar();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idventa", edetalle.idventa);
                command.Parameters.AddWithValue("@idproducto", edetalle.idproducto);
                command.Parameters.AddWithValue("@cantidad", edetalle.cantidad);
                command.Parameters.AddWithValue("@unidad", edetalle.cantidad);
                command.Parameters.AddWithValue("@precioventa", edetalle.precioVenta);

                if (command.ExecuteNonQuery() > 0)
                {
                    guardadoCorrectamente = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                guardadoCorrectamente = false;
            }
            finally
            {
                acceso.desconectar();
            }

            return guardadoCorrectamente;



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
