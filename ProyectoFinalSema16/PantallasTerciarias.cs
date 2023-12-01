using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSema16
{
    //Pantallas Tercearias  
    public class PantallasTerciarias
    {
        
        public static string[] tiendacosas = new string[1000];//Arreglo para los productos
        public static string[] nombre=new string[1000];//Arreglo para los almacenes
        public static float[] precios=new float[1000];
        public static float[] cantidad=new float[1000];
        public static int contadorP = 0;//Contador para los productos
        public static int contadorN = 0;//Contador para los almacenes
        //Declaramos un arreglo matricial para colocar las cantidades según los almacenes (filas) y los productos
        //(columnas)
        public static int[,] cantidadA = new int[1000, 1000];

        /********************************************************************************************************************/
        /*   
            GESTIONAR PRODUCTO
         */
        /********************************************************************************************************************/
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
            if (contadorP == 300)
            {
                Console.WriteLine("La lista ya esta llena");

            }
            else
            {
                tiendacosas[contadorP] = nombreProducto;
                precios[contadorP] = precioProducto;
                cantidad[contadorP] = cantidadProducto;
                contadorP++;


                string texto2 = ("--------------------------------------------------\r\n" +
                    "Confirmación: Producto agregado exitosamente.\r\n");
                Console.Write(texto2);
            }
                Console.ReadKey();
                Console.Clear();
                return PantallasSecundarias.GestionarProductos();
        }

        /********************************************************************************************************************/
        //eliminar producto
        /********************************************************************************************************************/
        public static int EliminarProducto()
        {
            string texto = "===== Pantalla para Eliminar Producto =====\r\n" +
                    "--------------------------------------------------\r\n";
            Console.Write(texto);

            string valorEliminar = Operaciones.getTextoPantalla("Ingrese el nombre del producto a eliminar:\r\n");
            int posicion = 0;
            
            for (int i = 0; i < contadorP; i++)
            {
                if (tiendacosas[i] == valorEliminar)
                {
                    posicion = i;               
                }
            }

            for (int i = posicion; i < contadorP; i++)
            {
                tiendacosas[i] = tiendacosas[i + 1];
                precios[i] = precios[i + 1];
                cantidad[i] = cantidad[i + 1];
            }
            contadorP--;

            string texto2 = "--------------------------------------------------\r\n" +
                "Confirmación: Producto eliminado exitosamente.\r\n";
            Console.Write(texto2);

            Console.ReadKey();
            Console.Clear();
            return PantallasSecundarias.GestionarProductos();
        }

        /********************************************************************************************************************/
        //modificar producto
        /********************************************************************************************************************/
        public static int ModificarProducto()
        {
            string texto = "===== Pantalla para Modificar Producto =====\r\n" +
                "--------------------------------------------------\r\n";
            Console.Write(texto);

            string nombreProducto = Operaciones.getTextoPantalla("Ingrese el nombre del producto a modificar:\r\n");

            int posicionEncontrada = -1;
            for (int i = 0; i < contadorP; i++)
            {
                if (nombreProducto == tiendacosas[i])
                {
                    posicionEncontrada = i;
                }
            }

            if (posicionEncontrada > -1)
            {
                float nuevoPrecio = Operaciones.getDecimal("Ingrese el nuevo precio:\r\n");
                precios[posicionEncontrada] = nuevoPrecio;
                float nuevaCantidad = Operaciones.getDecimal("Ingrese la nueva cantidad:\r\n");
                cantidad[posicionEncontrada] = nuevaCantidad;

                string texto1 = "--------------------------------------------------\r\n" +
                "Confirmación: Producto modificado exitosamente.\r\n";
                Console.Write(texto1);
            }
            else
            {
                Console.WriteLine("No se ha encontrado el producto");
            }
            Console.ReadKey();
            Console.Clear();
            return PantallasSecundarias.GestionarProductos();
        }

        /********************************************************************************************************************/
        // mostrar producto
        /********************************************************************************************************************/
        public static int MostrarInventario()
        {
            string texto = "===== Pantalla para Mostrar Inventario =====\r\n" +
                "--------------------------------------------------\r\n" +
            "Inventario Actual:\r\n";
            Console.Write(texto);

            if (contadorP == 0)
            {
                Console.WriteLine("No existen productos");
            }

            int i;

            for (i = 0; i < contadorP; i++)
            {
                Console.WriteLine("Producto" + (i + 1) + ":" + "[" + tiendacosas[i] +"]\t"+ " - " + "$" + "Precio:" + "[" + precios[i] + "]\t" + " - " + "Cantidad:" + "[" + cantidad[i] + "]\t");

            }

            string texto2 = "...\r\n";
            Console.Write(texto2);


            Console.ReadKey();
            Console.Clear();
            return PantallasSecundarias.GestionarProductos();
        }
        /********************************************************************************************************************/
        /*
          GESTIONAR ALMACEN
        */
        /********************************************************************************************************************/

        //agregar almacen

        /********************************************************************************************************************/
        public static void AgregarAlmacen()
        {
            string texto = "===== Pantalla para Agregar Almacén =====\r\n" +
                        "--------------------------------------------------\r\n";
            Console.Write(texto);

            string nombreRegistrado = Operaciones.getTextoPantalla("Ingrese el nombre del nuevo almacén: \n" + ">");

            nombre[contadorN] = nombreRegistrado;
            contadorN++;

            string texto2 = "--------------------------------------------------\r\n" +
                            "Confirmación: Almacén agregado exitosamente.\r\n";
            Console.Write(texto2);

            Console.ReadKey();
            Console.Clear();
        }

        /********************************************************************************************************************/
        //Eliminar almacen
        /********************************************************************************************************************/

        public static void EliminarAlmacen()
        {
            string texto = "===== Pantalla para Eliminar Almacén =====\r\n" +
                        "--------------------------------------------------\r\n";
            Console.Write(texto);

            Console.Write("Ingrese el nombre del almacén a eliminar: ");
            string nombreEliminar = Console.ReadLine();

            int indice = -1;
            for (int i = 0; i < contadorN; i++)
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

            contadorN--;

            string texto2 = "--------------------------------------------------\r\n" +
                            "Confirmación: Almacén eliminado exitosamente.\r\n";
            Console.Write(texto2);

            Console.ReadKey();
            Console.Clear();
        }

        /********************************************************************************************************************/
        //mostrar almacenes
        /********************************************************************************************************************/
        public static void MostrarAlmacenes()
        {
            string texto = "===== Pantalla para Mostrar Almacenes =====\r\n" +
                        "--------------------------------------------------\r\n";
            Console.Write(texto);
            for (int i = 0; i < contadorN; i++)
            {
                Console.WriteLine("Almacén " + (i + 1) + ": " + nombre[i]);

            }
            string texto2 = "--------------------------------------------------\r\n";
            Console.Write(texto2);
            Console.ReadKey();
            Console.Clear();
        }

        /********************************************************************************************************************/
        /*
            AGREGAR Y EXTRAER PRODUCTOS
         */
        /********************************************************************************************************************/
        public static void IngresarProducto()
        {

            string texto = "===== Pantalla para Ingresar Producto en Almacén =====\r\n" +
                "------------------------------------------------\r\n" +
                "Seleccione la opción del almacén: \r\n";
            Console.Write(texto);
            //Mostramos todos los almacenes disponibles
            for (int i = 0; i < contadorN; i++)
            {
                Console.WriteLine((i + 1) + ": " + nombre[i]);
            }
            //Guardamos el almacén a buscar
            int fila = Operaciones.getEntero("> ", texto);
            //Restamos 1 a la fila para que no afecte la posición de cada almacén
            fila -= 1;
            Console.WriteLine(" ");
            Console.WriteLine("Seleccione la opción del producto a ingresar: ");
            //Mostramos todos los productos ingresados
            for (int i = 0; i < contadorP; i++)
            {
                Console.WriteLine((i + 1) + ": " + tiendacosas[i]);
            }
            //Guardamos el producto que se desea y la cantidad en sus respectivos arreglos en la posición del almacén
            int columna = Operaciones.getEntero("> ", texto);
            //Restamos 1 a la columna para que no afecte la posición de cada producto
            columna -= 1;
            Console.WriteLine(" ");
            //Ingresamos la cantidad de productos según las filas (almacenes) y columnas (productos)
            Console.Write("Coloque la cantidad a ingresar: \n> ");
            cantidadA[fila, columna] = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------\n" +
                "Confirmación: Producto ingresado en el almacén exitosamente.");
            Console.ReadKey();

        }
        public static void ExtraerProducto()
        {

            int[] posicionP = new int[1000];
            int posicionPCont = 0;
            string texto = "===== Pantalla para Extraer Producto de Almacén =====\n" +
                "--------------------------------------------------\n" +
                "Seleccione la opción del almacén: ";
            Console.WriteLine(texto);
            //Mostramos todos los almacenes
            for (int i = 0; i < contadorN; i++)
            {
                Console.WriteLine((i + 1) + ": " + nombre[i]);
            }
            //Guardamos la posición del almacén a buscar
            int almacen = Operaciones.getEntero("> ", texto);
            //Restamos 1 al almacén para que no afecte la posición original en la fila de la matriz
            almacen -= 1;
            Console.WriteLine(" ");
            string texto2 = ("Seleccione la opción del producto a extraer: ");
            Console.WriteLine(texto2);
            //Guardamos las posiciones de los productos ingresados
            for (int i = 0; i < contadorP; i++)
            {
                if (cantidadA[almacen, i] != 0)
                {
                    posicionP[posicionPCont] = i;
                    posicionPCont++;
                }
            }
            //Bucle para mostrar los productos en el almacén seleccionado
            for (int i = 0; i < posicionPCont; i++)
            {
                    Console.WriteLine((i + 1) + ": " + tiendacosas[posicionP[i]]);
            }
            //Guardamos la ubicación en las columnas del producto a extraer
            int productoExtraer = Operaciones.getEntero("> ", texto2);
            //Restamos 1 a la posición del producto para que no afecte la ubicación original
            productoExtraer -= 1;
            Console.WriteLine(" ");
            string texto3 = ("Ingrese la cantidad a extraer en enteros: ");
            Console.WriteLine(texto3);
            int cantidadExtraer = Operaciones.getEntero("> ", texto3);
            //Restamos la cantidad que había anteriormente con la cantidad a extraer para obtener la cantidad actualizada
            if (cantidadA[almacen, productoExtraer] != 0)
            {
                cantidadA[almacen, productoExtraer] -= cantidadExtraer;
                Console.WriteLine("------------------------------------------------\n" +
                "Confirmación: Producto extraído del almacén exitosamente.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n¡Error! El producto no existe en el almacén");
                Console.ReadKey();
                return;
            }

        }
        public static void VerStock()
        {

            string texto2 = "===== Pantalla para Ver Stock Actual =====\n" +
                "--------------------------------------------------\n"+
                    "Stock Actual en Todos los Almacenes: ";
            Console.WriteLine(texto2);
            //Formamos un bucle que recorra filas y columnas para mostrar todos los productos, almacenes y cantidades correspondientes
                for (int i = 0; i < contadorN; i++)
                {
                for (int j = 0; j < contadorP; j++)
                {
                    Console.WriteLine($"Almacén: [{nombre[i]}] - Producto {j + 1}: [{tiendacosas[j]}] - Cantidad: [{cantidadA[i, j]}]");
                }
                }
            Console.ReadKey();
            Console.Clear();

        }

    }

}