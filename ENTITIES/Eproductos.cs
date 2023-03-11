using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Eproductos
    {
        public int idproducto { get; set; }
        public Elaboratorios olaboratorio { get; set; }
        public Ecategorias ocategoria { get; set; }
        public string nombreproducto { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public string fechaProduccion { get; set; }
        public string fechaVencimiento { get; set; }
        public string numlote { get; set; }
        public string recetaMedica { get; set; }

    }
}
