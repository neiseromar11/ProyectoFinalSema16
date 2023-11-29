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
                //switch para las funciones
                switch (opcion)
                {
                    case 1:
                        opcion = PantallasSecundarias.GestionarProductos();
                        break;
                    case 2:
                        opcion = PantallasSecundarias.GestionarAlmacenes();
                        break;
                    case 3:
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
