namespace Examen1
{
    class Menu
    {

        public static void MenuDesplegado() {
            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Vehículos");
                    Console.WriteLine("2. Ventas");
                    Console.WriteLine("3. Reportes");

                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            
                            subMenuVehiculos();
                            break;

                        case 2:
                            ventas();
                            
                            break;

                        case 3:
                            reportes(); 
                            break;
                        case 4:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }

        public static void subMenuVehiculos() {
            bool salir = false;
            Vehiculos vh = new Vehiculos();
            int cd;
            string mar, mdl;
            double cst;
            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Agregar");
                    Console.WriteLine("2. Modificar");
                    Console.WriteLine("3. Consultar");
                    Console.WriteLine("4. Menu Principal");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            System.Console.WriteLine("Digite nuevo codigo");
                            cd = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("Digite nueva marca");
                            mar = Console.ReadLine();
                            System.Console.WriteLine("Digite nuevo costo");
                            cst = Convert.ToDouble(Console.ReadLine());
                            System.Console.WriteLine("Digite nuevo modelo");
                            mdl = Console.ReadLine();
                            
                            vh.agregarVehiculo(cd, mar, cst, mdl);

                            break;

                        case 2:
                            System.Console.WriteLine("Digite codigo");
                            cd = Convert.ToInt32(Console.ReadLine());
                            vh.modificarVehiculo(cd);

                            break;

                        case 3:
                            System.Console.WriteLine("Digite  codigo");
                            cd = Convert.ToInt32(Console.ReadLine());
                            vh.consultarVehiculos(cd);
                            break;
                        case 4:
                            Menu.MenuDesplegado();
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }

        public static void ventas()
        {
            Vehiculos vh = new Vehiculos();
            vh.facturar();
            MenuDesplegado();

        }

        public static void reportes() {
            bool salir = false;
            Tipo tipo = new Tipo();
            Vendedores vnd = new Vendedores();  
            Vehiculos vh = new Vehiculos(); 
            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Listado Vendedores");
                    Console.WriteLine("2. Tipos de Vehiculos");
                    Console.WriteLine("3. Vehiculos Ingresados");

                    Console.WriteLine("4. Menu Principal");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            vnd.listadoVendedores();
                            break;

                        case 2:
                            tipo.Listado_Vehiculos();
                           // Console.WriteLine("Has elegido la opción 2");
                            break;

                        case 3:
                            vh.listadoVehiculos();
                            break;
                        case 4:
                           
                            MenuDesplegado();
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
        public static void Main(string[] args)
        {

            MenuDesplegado();


        }

    }
}