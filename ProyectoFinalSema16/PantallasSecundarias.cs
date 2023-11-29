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
            string texto = "--------------------------------------------------\n" +
                           "|| Gestionar Almacenes - Mi Tiendita ||\n" +
                           "--------------------------------------------------\n" +
                           "|| 1. Agregar Almacén ||\n" +
                           "|| 2. Eliminar Almacén ||\n" +
                           "|| 3. Mostrar Almacenes ||\n" +
                           "|| 4. Volver al Menú Principal ||\n" +
                           "--------------------------------------------------\n";
            Console.Write(texto);
            return Operaciones.getEntero("Seleccione una opción: ", texto);

            
        }
        //funcion de gestionar almacenes
        public static int AgregarExtraerProductos()
        {

            return 0;

        }

    }
}
