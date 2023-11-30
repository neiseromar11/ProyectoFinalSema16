using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    public class PantallasSecundarias
    {
        //funcion de gestionar productos
        public static int GestionarProductos()
        {
                string texto = ("--------------------------------------------------\r\n" +
                    "||       Gestionar Productos - Mi Tiendita      ||\r\n" +
                    "--------------------------------------------------\r\n" +
                    "|| 1. Agregar Producto                          ||\r\n" +
                    "|| 2. Eliminar Producto                         ||\r\n" +
                    "|| 3. Modificar Producto                        ||\r\n" +
                    "|| 4. Mostrar Inventario                        ||\r\n" +
                    "|| 5. Volver al Menú Principal                  ||\r\n" +
                    "--------------------------------------------------\r\n");
                Console.Write(texto);
            int opciongestion = int.Parse(Console.ReadLine());

            if (opciongestion == 1)
            {
                Console.Clear();
                PantallasTerciarias.AgregarProducto();
                return GestionarProductos();
            }
            if (opciongestion == 2)
            {
                Console.Clear();
                PantallasTerciarias.EliminarProducto();
                return GestionarProductos();
            }
            if (opciongestion == 3)
            {
                Console.Clear();
                PantallasTerciarias.ModificarProducto();
                return GestionarProductos();
            }
            if (opciongestion == 4)
            {
                Console.Clear() ;
                PantallasTerciarias.MostrarInventario();
            }
            if (opciongestion == 5)
            {
                Console.Clear();
                PantallaPrincipal.PantallaMain();
            }
            return opciongestion;


        }
        //funcion de gestionar almacenes
        public static int GestionarAlmacenes()
        {
               Console.Clear();
                string texto = "---------------------------------------\n" +
                           "|| Gestionar Almacenes - Mi Tiendita ||\n" +
                           "---------------------------------------\n" +
                           "|| 1. Agregar Almacén                ||\n" +
                           "|| 2. Eliminar Almacén               ||\n" +
                           "|| 3. Mostrar Almacenes              ||\n" +
                           "|| 4. Volver al Menú Principal       ||\n" +
                           "--------------------------------------------------\n";
                Console.Write(texto);

                 int opcion =int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Clear ();
                PantallasTerciarias.AgregarAlmacen();
                return GestionarAlmacenes();
            }
             if (opcion == 2)
             {
                Console.Clear ();
                PantallasTerciarias.EliminarAlmacen();
                return GestionarAlmacenes();
            }
             if (opcion == 3)
             {
                Console.Clear () ;
                PantallasTerciarias.MostrarAlmacenes();
                return GestionarAlmacenes();
            }
             if (opcion == 4)
             {
                Console.Clear() ;
                PantallaPrincipal.PantallaMain();
             }
            return opcion;    
             
        }
        //funcion de gestionar almacenes
        public static int AgregarExtraerProductos()
        {
            int opcionProducto = 0;

            do
            {
                string texto1 = "--------------------------------------------------\n" +
            "||  Agregar y Extraer Productos - Mi Tiendita   ||\n" +
            "--------------------------------------------------\n" +
            "|| 1. Ingresar Producto en Almacén              ||\n" +
            "|| 2. Extraer Producto de Almacén               ||\n" +
            "|| 3. Ver Stock Actual                          ||\n" +
            "|| 4. Volver al Menú Principal                  ||\n" +
            "--------------------------------------------------\n";
                Console.Write(texto1);

                opcionProducto = Operaciones.getEntero("Seleccione una opción: ", texto1);

                Console.Clear();
                switch (opcionProducto)
                {
                    //Delegado asigna las variables del switch
                    case 1:
                        //PantallasTerciarias.IngresarProducto();
                        break;
                    case 2:
                        //PantallasTerciarias.ExtraerProducto();
                        break;
                    case 3:
                        //PantallasTerciarias.VerStock();
                        break;
                    case 4: 
                    default:
                        if (opcionProducto != 4)
                        {
                            Console.WriteLine("¡Error! Por favor, seleccione una opción valida.");
                            Console.ReadKey(); 
                            opcionProducto = 4; 
                        }
                        break;
                }
            } while (opcionProducto != 4);
            return 0;
        }
    }
}
