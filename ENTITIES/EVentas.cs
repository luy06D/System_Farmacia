using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EVentas
    {
        public int idproducto { get; }

        public string nombreProducto { get; set; }

        public string descripcion { get; set; }

        public string precio { get; set; }

        public string cantidad {get; set;}

        public string fechaVencimiento { get; set;}

        public string recetaMedica { get; set;}
    }
}
