using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    //clase de pantallas principales
    public class Pantallas
    {
        //funcion de pantalla principal
        public static int pantallaPrincipal()
        {
            string texto = ("==================================================\r\n" +
                "||                                              ||\r\n" +
                "||        Sistema de Inventario \"Mi Tiendita\"   ||\r\n" +
                "||                                              ||\r\n" +
                "==================================================\r\n" +
                "|| 1. Gestionar Productos                       ||\r\n" +
                "|| 2. Gestionar Almacenes                       ||\r\n" +
                "|| 3. Agregar y Extraer Productos               ||\r\n" +
                "|| 4. Salir                                     ||\r\n" +
                "==================================================\r\n");
            Console.Write(texto);

            return Operaciones.getEntero("Seleccione una opción y presione Enter: ", texto);
        }
        //funcion de gestionar productos
        public static int GestionarProductos()
        {
            int opcionProducto = 0;


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
                        PantallasSecundarias.AgregarProducto();
                        break;
                    case 2:
                        PantallasSecundarias.EliminarProducto();
                        break;
                    case 3:
                        PantallasSecundarias.ModificarProducto();
                        break;
                    case 4:
                        PantallasSecundarias.MostrarInventario();
                        break;
                    case 5:
                        opcionProducto = pantallaPrincipal();
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
        public static int GestionarAlmacenes() {
         

            return 0;
        }
        //funcion de gestionar almacenes
        public static int AgregarExtraerProductos() {

            return 0;

        } 
        
    }
}
