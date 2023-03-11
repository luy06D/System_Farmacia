using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Edetalle_venta
    {

        public int iddetalleVenta { get; set; }
        public Eproductos oproducto{ get; set; }
        public int cantidad { get; set; }
        public string unidad { get; set; }
        public decimal precioVenta { get; set; }
    }
}
