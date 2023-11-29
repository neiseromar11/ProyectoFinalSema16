using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    //Pantallas secundarias
    public class PantallasSecundarias
    {
        public static string[] nombre=new string[100];
        public static float[] precios=new float[100];
        public static float[] cantidad=new float[100];
        public static int contador = 0;
        public static int AgregarProducto()
        {

            string texto = ("===== Pantalla para Agregar Producto =====\r\n" +
                "--------------------------------------------------\r\n");
            Console.Write(texto);
            string nombreProducto=Operaciones.getTextoPantalla("Ingrese el nombre del producto:\r\n");
            float precioProducto = Operaciones.getDecimal("Ingrese el precio del producto:\r\n");
            float cantidadProducto = Operaciones.getDecimal("Ingrese la cantidad del producto:\r\n");
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
                return Pantallas.GestionarProductos();
            
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
                "--------------------------------------------------\r\n" +
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
                "...\r\n");

            return 0;

        }


    }
}
