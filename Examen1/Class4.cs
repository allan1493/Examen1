using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Tipo
    {
        List<string> vehiculos = new List<string>(){
    "Motocicleta",
    "Automovil",
    "Dron"
};

        protected void Tipo_Vehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de de vehículos ");
            Console.ReadLine();
        }

        public void Listado_Vehiculos()
        {
            for (int i = 0; i < vehiculos.Count; i++)
            {
                Console.WriteLine(vehiculos[i]);
            }
            Console.ReadLine();
        }

        public Boolean Tipo_Existe(String tipo)
        {
            bool existe = false;
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if(vehiculos.ElementAt(i).Equals(tipo))
                    existe = true;
                
            }

            return existe;
        }

        //public string 
    }
}
