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

        public int  idcliente { get; set; }

        public int idusuario { get; set; }

        public int idempresa { get; set; }

        public string cantidad {get; set;}

        public char tipoComprobante { get; set;}

       

 
    }
}
