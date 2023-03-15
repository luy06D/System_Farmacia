using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DAL;

namespace BOL {
    public class Productos {
        DBAccess acceso = new DBAccess();

        public void registrarProductos (
            int idlaboratorio, int idcategoria, string nombreproducto, string descripcion,
            string cantidad, string precio, string fechaproduccion, string fechavencimiento,
            string numlote, string recetamedica, string barcode) {
            SqlCommand command = new SqlCommand("spu_productos_registrar", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();

            command.Parameters.AddWithValue("@idlaboratorio", idlaboratorio);
            command.Parameters.AddWithValue("@idcategoria", idcategoria);
            command.Parameters.AddWithValue("@nombreproducto", nombreproducto);
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@fechaproduccion", fechaproduccion);
            command.Parameters.AddWithValue("@fechavencimiento", fechaproduccion);
            command.Parameters.AddWithValue("@numlote", numlote);
            command.Parameters.AddWithValue("@recetamedica", recetamedica);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        //Método para obtener los datos del producto mediante barcod
        public DataTable buscarBarCode(string barcode) {
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

        public DataTable listarProductos() {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_LISTAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            acceso.desconectar();
            return data;
        }

    }
}
