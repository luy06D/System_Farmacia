using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EVentas
    {
        public int idventa { get; }

        public Eclientes ocliente { get; set; }

        public Eusuarios ousuario { get; set; }

        public Eempresa oempresa { get; set; }

        public string cantidad {get; set;}

        public string tipoComprobante { get; set;}

        public List<Edetalle_venta> odetalle_venta { get; set; }

 
    }
}
