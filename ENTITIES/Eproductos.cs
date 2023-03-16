using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Eproductos
    {
        public int idlaboratorio { get; set; }
        public int idcategoria { get; set; }
        public string nombreproducto { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public string fechaproduccion { get; set; }
        public string fechavencimiento { get; set; }
        public string  numlote { get; set; }
        public string recetamedica { get; set; }
        public string barcode { get; set; }

    }
}
