using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen1
{
    class Vehiculos:Tipo
    {
        protected static int[] codigos = new int[5];
        protected static String [] marcas = new String[5];
        protected static double [] costos = new double[5];  
        protected static string [] modelos = new string[5];
        public Automovil auto = new Automovil();
        public Motocicleta moto = new Motocicleta();
        public Dron dron = new Dron();
        public Vendedores vendedores = new Vendedores(); 


        public Vehiculos v;

        private int i = 0;
        public Vehiculos(){ }
        public Vehiculos(int codigo, string marca, double costo, string modelo )
        {
           
                
            
        }

        public void agregarVehiculo(int codigo, string marca, double costo, string modelo) {
            //v = new Vehiculos(codigo, marca, costo, modelo);
            if (i < 5)
            {
                codigos[i] = codigo;
                marcas[i] = marca;
                costos[i] = costo;
                modelos[i] = modelo;
                i++;
            }
            else
            {
                Console.WriteLine("arreglos llenos ");
                Console.ReadLine();
            }

        }

        public void modificarVehiculo(int codigo) {
            if (existeVehiculo(codigo) == false)
                Console.WriteLine("Vehiculo no existe");
            else
            {
                for (int i = 0; i < codigos.Length; i++)
                {
                    if (codigos[i] == codigo)
                    {
                        System.Console.WriteLine("Digite nuevo codigo");
                        codigos[i] = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Digite nueva marca");
                        marcas[i] = Console.ReadLine();
                        System.Console.WriteLine("Digite nuevo costo");
                        costos[i] = Convert.ToDouble(Console.ReadLine());
                        System.Console.WriteLine("Digite nuevo modelo");
                        modelos[i] = Console.ReadLine();
                    }
                }
            }
        }

        public void consultarVehiculos(int codigo)
        {
            if (existeVehiculo(codigo) == false)
                Console.WriteLine("Vehiculo no existe");
            else
            {
                for (int i = 0; i < codigos.Length; i++)
                {
                    if (codigos[i] == codigo)
                    {
                        Console.WriteLine("Codigo: " + codigos[i] + "\n");
                        Console.WriteLine("Marca: " + marcas[i] + "\n");
                        Console.WriteLine("Costos: " + costos[i] + "\n");
                        Console.WriteLine("Modelo: " + modelos[i] + "\n");

                        Console.ReadLine();
                    }
                }
            }
        }


        public Boolean existeVehiculo(int codigo)
        {
            bool existe = false;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == codigo)
                {
                    existe = true;  
                }
            }

            return existe;

        }

        public void listadoVehiculos() {
            for (int i = 0; i < codigos.Length; i++)
            {
                
                    Console.WriteLine("Codigo: " + codigos[i] + "\n");
                    Console.WriteLine("Marca: " + marcas[i] + "\n");
                    Console.WriteLine("Costos: " + costos[i] + "\n");
                    Console.WriteLine("Modelo: " + modelos[i] + "\n");
                    Console.WriteLine("---------------------------- \n");
                    Console.ReadLine();
                
            }
        }

        public void asignarTipo(int id)
        {
            
            Console.WriteLine("automovil");
            Console.WriteLine("motocicleta");
            Console.WriteLine("dron");
            System.Console.WriteLine("Digite una opcion");
            string opcion = Console.ReadLine();
            if (opcion.Equals("automovil"))
            {
                
                auto.Tipo_Vehiculo();


            }

            else if (opcion.Equals("motocicleta"))
            {
                
                moto.Tipo_Vehiculo();



            }

            else
            { 
                dron.Tipo_Vehiculo();
            }


        }

        public void asignarVendedor(string id)
        {
            Console.WriteLine("El vendedor es: " + vendedores.nombreVendedor(id));
            Console.ReadLine();

        }




        public void facturar()

        {
            System.Console.WriteLine("Digite codigo vehiculo");
            int id = Convert.ToInt32(Console.ReadLine());
            if (existeVehiculo(id) == true)
            {
                asignarTipo(id);
                System.Console.WriteLine("Digite codigo vendedor");
                string idv = Console.ReadLine();
                if (vendedores.devolverVendedor(idv) == false)
                {
                    Console.WriteLine("No se encuentra vendedor");
                    Console.ReadLine();
                }
                else
                {
                    asignarVendedor(idv);
                    double cst = 0;
                    double total = 0;
                    string marca = "";
                    for (int i = 0; i < codigos.Length; i++)
                    {
                        if (codigos[i] == id)
                        {
                            System.Console.WriteLine("Digite cuantos autos");
                            double unidad = Convert.ToDouble(Console.ReadLine());
                            total = unidad * costos[i];
                            cst = costos[i];
                            marca = marcas[i];
                        }
                    }

                    Console.WriteLine("Marca: " + marca);
                    Console.WriteLine("Costo: " + cst);
                    Console.WriteLine("Total: " + total);

                }
            }
            else
            {
                Console.WriteLine("No existe vehiculo");
            }

        }

    }
}
