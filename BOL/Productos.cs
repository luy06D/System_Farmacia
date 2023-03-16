using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DAL;
using ENTITIES;
namespace BOL
{


    public class Productos
    {

        DBAccess acceso = new DBAccess();

        public DataTable ListarProductos()
        {
            DataTable resultado = new DataTable();
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_PRODUCTOS_LISTAR", acceso.getConexion());
            adapter.Fill(resultado);
            acceso.desconectar();
            return resultado;
        }

        public void registrarProductos(Eproductos eproductos)
        {
            
            SqlCommand command = new SqlCommand("SPU_REGISTRAR_PRODUCTOS", acceso.getConexion());
            acceso.conectar();

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idlaboratorio",eproductos.idlaboratorio); 
            command.Parameters.AddWithValue("@idcategoria", eproductos.idcategoria );         
            command.Parameters.AddWithValue("@nombreproducto", eproductos.nombreproducto);
            command.Parameters.AddWithValue("@descripcion", eproductos.descripcion );
            command.Parameters.AddWithValue("@precio", eproductos.precio );
            command.Parameters.AddWithValue("@cantidad", eproductos.cantidad );
            command.Parameters.AddWithValue("@fechaproduccion", eproductos.fechaproduccion );
            command.Parameters.AddWithValue("@fechavencimiento", eproductos.fechavencimiento); 
            command.Parameters.AddWithValue("@numlote", eproductos.numlote );
            command.Parameters.AddWithValue("@recetamedica", eproductos.recetamedica );
            command.Parameters.AddWithValue("@barcode", eproductos.barcode );

            command.ExecuteNonQuery();
            acceso.desconectar();
        }


        //Método para obtener los datos del producto mediante barcodeS
        public  DataTable buscarBarCode(string barcode)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("SPU_BARCODE_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@barcode", barcode);

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            acceso.desconectar();
            return data;

        }


        public DataTable getdataProducto()
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_LISTARVENTA", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            data.Load(command.ExecuteReader());

            acceso.desconectar();
            return data;
        }


    }
}
