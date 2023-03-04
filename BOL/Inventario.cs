using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Inventario
    {
        DBAccess acceso = new DBAccess();
        public DataTable listarProdcutos()
        {
            return acceso.getDataGrid("spu_empresas_listar", 1);
        }
    }
}
