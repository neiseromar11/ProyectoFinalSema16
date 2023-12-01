using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    internal class Program
    {
        //Pagina principal
        static void Main(string[] args)
        {
            int opcion = PantallaPrincipal.PantallaMain();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                       //Funcion Gestionar Productos
                        opcion = PantallasSecundarias.GestionarProductos();
                        break;
                    case 2:

                        //Funcion Gestionar Almacenes
                        opcion = PantallasSecundarias.GestionarAlmacenes();
                        break;
                    case 3:

                        //Funcion Extraer Productos
                        opcion = PantallasSecundarias.AgregarExtraerProductos();
                        break;
                    case 0:
                    default:
                        opcion = PantallaPrincipal.PantallaMain();
                        break;
                }

            } while (opcion != 4);

        }
    }
}
