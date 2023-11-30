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
            string texto = "===== Pantalla para Eliminar Producto =====\r\n" +
                    "--------------------------------------------------\r\n";
            Console.Write(texto);

            string valorEliminar = Operaciones.getTextoPantalla("Ingrese el nombre del producto a eliminar:\r\n");
            int posicion = 0;
            
            for (int i = 0; i < contador; i++)
            {
                if (nombre[i] == valorEliminar)
                {
                    posicion = i;               
                }
            }

            for (int i = posicion; i < contador; i++)
            {
                nombre[i] = nombre[i + 1];
                precios[i] = precios[i + 1];
                cantidad[i] = cantidad[i + 1];
            }
            contador--;

            string texto2 = "--------------------------------------------------\r\n" +
                "Confirmación: Producto eliminado exitosamente.\r\n";
            Console.Write(texto2);

            Console.ReadKey();
            Console.Clear();
            return PantallasSecundarias.GestionarProductos();
        }

        public static int ModificarProducto()
        {
            string texto = "===== Pantalla para Modificar Producto =====\r\n" +
                "--------------------------------------------------\r\n";
            Console.Write(texto);

            string nombreProducto = Operaciones.getTextoPantalla("Ingrese el nombre del producto a modificar:\r\n");

            int posicionEncontrada = -1;
            for (int i = 0; i < contador; i++)
            {
                if (nombreProducto == nombre[i])
                {
                    posicionEncontrada = i;
                }
            }

            if (posicionEncontrada > -1)
            {
                float nuevoPrecio = Operaciones.getDecimal("Ingrese el nuevo precio:\r\n");
                precios[posicionEncontrada] = nuevoPrecio;
            }
            if (posicionEncontrada > -1)
            {
                float nuevaCantidad = Operaciones.getDecimal("Ingrese la nueva cantidad:\r\n");
                cantidad[posicionEncontrada] = nuevaCantidad;
            }
            else
            {
                Console.WriteLine("No se ha encontrado el producto");
            }

            string texto2 = "--------------------------------------------------\r\n" +
                "Confirmación: Producto modificado exitosamente.\r\n";
            Console.Write(texto2);

            Console.ReadKey();
            Console.Clear();
            return PantallasSecundarias.GestionarProductos();
        }

        public static int MostrarInventario()
        {
            string texto = "===== Pantalla para Mostrar Inventario =====\r\n" +
                "--------------------------------------------------\r\n" +
            "Inventario Actual:\r\n";
            Console.Write(texto);

            if (contador == 0)
            {
                Console.WriteLine("No existen productos");
            }

            int i;

            for (i = 0; i < contador; i++)
            {
                Console.WriteLine("Producto" + (i + 1) + ":" + "[" + nombre[i] + "]\t" + " - " + "$" + "Precio:" + "[" + precios[i] + "]\t" + " - " + "Cantidad:" + "[" + cantidad[i] + "]\t");

            }

            string texto2 = "...\r\n";
            Console.Write(texto2);


            Console.ReadKey();
            Console.Clear();
            return PantallasSecundarias.GestionarProductos();
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
            int indice = 0;
            if (indice >= 0 && indice < contador)
            {
                for (int i = indice; i < contador - 1; i++)
                {
                    nombre[i] = nombre[i + 1];
                }
                contador--;
            }
        }





    }
}
