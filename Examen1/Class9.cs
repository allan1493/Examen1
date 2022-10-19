using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Vendedor1:Ivendedor1
    {

        public string nombreVendedor { get { return nombreVendedor; } set { nombreVendedor = value; } }
        public Vendedor1()
        {
            this.nombreVendedor = "Allan";

        }

        public void VentasContado() { }

    }

    class Vendedor2:Ivendedor2
    {
        public string nombreVendedor { get { return nombreVendedor; } set { nombreVendedor = value; } }

        public Vendedor2()
        {
            this.nombreVendedor = "Maria";
        }

        public string VentasCredito() { return nombreVendedor; }    
    }
}
