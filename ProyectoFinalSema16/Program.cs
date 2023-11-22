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
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                
                Console.Clear();
                //switch para las funciones
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.GestionarProductos();
                        break;
                    case 2:
                        opcion = Pantallas.GestionarAlmacenes();
                        break;
                    case 3:
                        opcion = Pantallas.AgregarExtraerProductos();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.pantallaPrincipal();
                        break;


                }

            } while (opcion != 4);

        }
    }
}
