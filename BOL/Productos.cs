using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DAL;
using System.Threading;


namespace BOL {
    public class Productos {
        DBAccess acceso = new DBAccess();
        public void registrarProductos(
            int idlaboratorio, int idcategoria, string nombreproducto, string descripcion,
            string cantidad, string precio, string fechaproduccion, string fechavencimiento,
<<<<<<< HEAD
            string numlote, string recetamedica, string barcode) {
=======
            string numlote, string recetamedica, string barcode)
        {
>>>>>>> 25e2f646142d3dd0c8a37e82f600bdecef752875
            SqlCommand command = new SqlCommand("spu_productos_registrar", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();

            command.Parameters.AddWithValue("@idlaboratorio", idlaboratorio);
            command.Parameters.AddWithValue("@idcategoria", idcategoria);
            command.Parameters.AddWithValue("@nombreproducto", nombreproducto);
<<<<<<< HEAD
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@fechaproduccion", fechaproduccion);
            command.Parameters.AddWithValue("@fechavencimiento", fechaproduccion);
            command.Parameters.AddWithValue("@numlote", numlote);
            command.Parameters.AddWithValue("@recetamedica", recetamedica);
            command.Parameters.AddWithValue("@barcode", barcode);
=======
            command.Parameters.AddWithValue("@descripcion", descripcion );
            command.Parameters.AddWithValue("@cantidad", cantidad );
            command.Parameters.AddWithValue("@precio", precio );
            command.Parameters.AddWithValue("@fechaproduccion", fechaproduccion );
            command.Parameters.AddWithValue("@fechavencimiento", fechaproduccion );
            command.Parameters.AddWithValue("@numlote", numlote );
            command.Parameters.AddWithValue("@recetamedica", recetamedica );
            command.Parameters.AddWithValue("@barcode", barcode );

>>>>>>> 25e2f646142d3dd0c8a37e82f600bdecef752875
            command.ExecuteNonQuery();
            acceso.desconectar();
        } 

<<<<<<< HEAD

        public DataTable buscarBarCode(string barcode) {
=======
        //Método para obtener los datos del producto mediante barcode
        public  DataTable buscarBarCode(string barcode)
        {
>>>>>>> 25e2f646142d3dd0c8a37e82f600bdecef752875
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


        public DataTable listarProductos()
        {
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
