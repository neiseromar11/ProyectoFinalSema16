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
        public static int AgregarProducto()
        {

            Console.WriteLine("===== Pantalla para Agregar Producto =====\r\n" +
                "--------------------------------------------------\r\n" +
                "Ingrese el nombre del producto:\r\n" +
                "[Usuario ingresa el nombre]\r\n" +
                "Ingrese el precio del producto:\r\n" +
                "[Usuario ingresa el precio]\r\n" +
                "Ingrese la cantidad del producto:\r\n" +
                "[Usuario ingresa la cantidad]\r\n" +
                "--------------------------------------------------\r\n" +
                "Confirmación: Producto agregado exitosamente.\r\n");
            Console.ReadKey();
            return 0;

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
