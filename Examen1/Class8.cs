using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Vendedores
    {
        Dictionary<string, string> VendedoresDict;
        public Vendedores()
        {
            VendedoresDict = new Dictionary<string, string>();
            VendedoresDict.Add("001", "Allan");
            VendedoresDict.Add("002", "Maria");
        }

        public void listadoVendedores()
        {
            foreach (KeyValuePair<string, string> user in VendedoresDict)
            {
                Console.WriteLine("Codigo: "
                    +user.Key + "  Mombre:" + user.Value + " \n");
            }
        }

        public string nombreVendedor(string codigo)
        {
            string nombre = "";
            foreach (KeyValuePair<string, string> user in VendedoresDict)
            {
                if (user.Key.Equals(codigo))
                    nombre = user.Value;
            }
            return nombre;
        }

        public Boolean devolverVendedor(string codigo)
        {
            bool resultado = false;
            foreach (KeyValuePair<string, string> user in VendedoresDict)
            {
                if (user.Key.Equals(codigo))   
                    resultado = true;
            }
            return resultado;
        }



    }
}
