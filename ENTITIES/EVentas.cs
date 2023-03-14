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

        public Eclientes idcliente { get; set; }

        public Eusuarios idusuario { get; set; }

        public Eempresa idempresa { get; set; }

        public string cantidad {get; set;}

        public string tipoComprobante { get; set;}

       

 
    }
}
