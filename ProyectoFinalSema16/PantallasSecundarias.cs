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
            int opcionProducto = 0;

            //elewwicht
            do
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

                opcionProducto = Operaciones.getEntero("Seleccione una opción: ", texto);

                Console.Clear();
                switch (opcionProducto)
                {
                    case 1:

                        PantallasTerciarias.AgregarProducto();
                        break;
                    case 2:
                        PantallasTerciarias.EliminarProducto();
                        break;
                    case 3:
                        PantallasTerciarias.ModificarProducto();
                        break;
                    case 4:
                        PantallasTerciarias.MostrarInventario();
                        break;
                    case 5:
                        //Lexi 
                        opcionProducto = PantallaPrincipal.PantallaMain();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

            } while (opcionProducto != 5);

            // Retorna la opción para actualizarla en el método Main
            return opcionProducto;

        }
        //funcion de gestionar almacenes
        public static int GestionarAlmacenes()
        {
            int opcionProducto = 0;
            do
            {
                string texto = "---------------------------------------\n" +
                           "|| Gestionar Almacenes - Mi Tiendita ||\n" +
                           "---------------------------------------\n" +
                           "|| 1. Agregar Almacén                ||\n" +
                           "|| 2. Eliminar Almacén               ||\n" +
                           "|| 3. Mostrar Almacenes              ||\n" +
                           "|| 4. Volver al Menú Principal       ||\n" +
                           "--------------------------------------------------\n";
                Console.Write(texto);
                opcionProducto =Operaciones.getEntero("Seleccione una opción: ", texto);
                
                switch (opcionProducto)
                {
                    case 0:
                        Console.Clear();
                        PantallasSecundarias.GestionarAlmacenes();
                        break;
                    case 1:
                        Console.Clear();
                        PantallasTerciarias.AgregarAlmacen();
                        break;
                    case 2:
                        Console.Clear();
                        PantallasTerciarias.EliminarAlmacen();
                        //aun falta completarlo
                        break;
                    case 3:
                        Console.Clear();
                        //PantallaCodigo.MostrarAlmacenes();
                        break;
                    case 4:
                        Console.Clear();
                        opcionProducto = PantallaPrincipal.PantallaMain();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            } while (opcionProducto != 4);

            return opcionProducto;
        }
        //funcion de gestionar almacenes



        public static int AgregarExtraerProductos()
        {
            int opcionProducto = 0;

            //elewwicht
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
                    case 5: 
                        opcionProducto = PantallaPrincipal.PantallaMain();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

            } while (opcionProducto != 5);

            return opcionProducto;
        }
    }
}
