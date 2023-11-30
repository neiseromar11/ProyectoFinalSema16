using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    //Pantallas secundarias
    public class PantallasTerciarias
    {
        public static string[] nombre=new string[100];
        public static float[] precios=new float[100];
        public static float[] cantidad=new float[100];
        public static int contador = 0;
        public static int AgregarProducto()
        {
            //agregar productos
            string texto = ("===== Pantalla para Agregar Producto =====\r\n" +
                "--------------------------------------------------\r\n");
            Console.Write(texto);

            string nombreProducto=Operaciones.getTextoPantalla("Ingrese el nombre del producto:\r\n");
            float precioProducto = Operaciones.getDecimal("Ingrese el precio del producto:\r\n");
            float cantidadProducto = Operaciones.getDecimal("Ingrese la cantidad del producto:\r\n");

            //Condicional
            if (contador == 300)
            {
                Console.WriteLine("La lista ya esta llena");

            }
            else
            {
                nombre[contador] = nombreProducto;
                precios[contador] = precioProducto;
                cantidad[contador] = cantidadProducto;
                contador++;


                string texto2 = ("--------------------------------------------------\r\n" +
                    "Confirmación: Producto agregado exitosamente.\r\n");
                Console.Write(texto2);
            }
                Console.ReadKey();
                Console.Clear();
                return PantallasSecundarias.GestionarProductos();
        }

        public static int EliminarProducto()
        {
            Console.WriteLine("===== Pantalla para Eliminar Producto =====\r\n" +
                "--------------------------------------------------\r\n" +
                "Ingrese el nombre del producto a eliminar:\r\n" +
                "[Usuario ingresa el nombre]\r\n" +
                "--------------------------------------------------\r\n" +
                "Confirmación: Producto eliminado exitosamente.\r\n");
            return 0;
        }

        public static int ModificarProducto()
        {
            Console.WriteLine("===== Pantalla para Modificar Producto =====\r\n" +
                "--------------------------------------------------\r\n" +
                "Ingrese el nombre del producto a modificar:\r\n" +
                "[Usuario ingresa el nombre]\r\n" +
                "Ingrese el nuevo precio:\r\n" +
                "[Usuario ingresa el nuevo precio]\r\n" +
                "Ingrese la nueva cantidad:\r\n" +
                "[Usuario ingresa la nueva cantidad]\r\n" +
                "--------------------------------------------------" +
                "Confirmación: Producto modificado exitosamente.\r\n");
            return 0;
        }

        public static int MostrarInventario()
        {
            Console.WriteLine("===== Pantalla para Mostrar Inventario =====\r\n" +
                "--------------------------------------------------\r\n" +
                "Inventario Actual:\r\n" +
                "Producto 1: [Nombre] - Precio: $[Precio] - Cantidad: [Cantidad]\r\n" +
                "Producto 2: [Nombre] - Precio: $[Precio] - Cantidad: [Cantidad]\r\n" +
                "....\r\n");
            return 0;
        }
        public static void AgregarAlmacen()
        {
            string texto = "===== Pantalla para Agregar Almacén =====\r\n" +
                        "--------------------------------------------------\r\n";
            Console.Write(texto);

            string nombreRegistrado = Operaciones.getTextoPantalla("Ingrese el nombre del nuevo almacén: \n" + ">");

            nombre[contador] = nombreRegistrado;
            contador++;

            string texto2 = "--------------------------------------------------\r\n" +
                            "Confirmación: Almacén agregado exitosamente.\r\n";
            Console.Write(texto2);

            Console.ReadKey();
            Console.Clear();
        }
        public static void EliminarAlmacen()
        {
            string texto = "===== Pantalla para Eliminar Almacén =====\r\n" +
                        "--------------------------------------------------\r\n";
            Console.Write(texto);

            Console.Write("Ingrese el nombre del almacén a eliminar: ");
            string nombreEliminar = Console.ReadLine();

            int indice = -1;
            for (int i = 0; i < contador; i++)
            {
                if (nombre[i] == nombreEliminar)
                {
                    indice = i;
                    break;
                }
            }
            string[] nuevo = new string[nombre.Length - 1];

            for (int i = 0; i < indice; i++)
            {
                nuevo[i] = nombre[i];
            }

            for (int i = indice; i < nuevo.Length; i++)
            {
                nuevo[i] = nombre[i + 1];
            }

            nombre = nuevo;

            contador--;

            Console.WriteLine("Almacén '" + nombreEliminar + "' eliminado exitosamente.");

            Console.WriteLine("El nuevo arreglo es: ");
            for (int i = 0; i < contador; i++)
            {
                Console.Write(nombre[i] + " | ");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarAlmacenes()
        {
            string texto = "===== Pantalla para Mostrar Almacenes =====\r\n" +
                        "--------------------------------------------------\r\n";
            Console.Write(texto);
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Almacén " + (i + 1) + ": " + nombre[i]);

            }
            string texto2 = "--------------------------------------------------\r\n";
            Console.Write(texto2);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
