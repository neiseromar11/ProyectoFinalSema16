using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    public class PantallaPrincipal
    {
        public static int PantallaMain()
        {
            do
            {
                Console.Clear();
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
                int opciones = int.Parse(Console.ReadLine());
                if (opciones == 1)
                {
                    Console.Clear();
                    PantallasSecundarias.GestionarProductos();
                }
                if (opciones == 2)
                {
                    Console.Clear();
                    PantallasSecundarias.GestionarAlmacenes();

                }
                if (opciones == 3)
                {
                    Console.Clear();
                    PantallasSecundarias.AgregarExtraerProductos();
                }
                return Operaciones.getEntero("Seleccione una opción y presione Enter: ", texto);


            }while (true);
            
        }
    }
}
