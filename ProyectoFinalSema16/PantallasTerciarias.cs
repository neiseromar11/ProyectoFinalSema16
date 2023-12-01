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
        public static string[] tiendacosas = new string[100];
        public static string[] nombre=new string[100];
        public static float[] precios=new float[100];
        public static float[] cantidad=new float[100];
        public static int contadorP = 0;
        public static int contadorN = 0;
        //Declaramos arreglos
        public static string[] almacenes = new string[100];
        public static string[] productos = new string[100];
        public static int[] cantidadA = new int[100];
        public static int almacenesCont = 0;
        public static int productosCont = 0;
        public static int cantidadCont = 0;

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
                "Seleccione el almacén: \r\n";
            Console.Write(texto);
            //Mostramos todos los almacenes
            for (int i = 0; i < contadorN; i++)
            {
                Console.WriteLine("Almacén " + (i + 1) + ": " + nombre[i]);
            }
            //Guardamos el almacén a buscar
            almacenes[almacenesCont] = Operaciones.getTextoPantalla("> ");
            Console.WriteLine(" ");
            Console.WriteLine("Seleccione el producto a ingresar: ");
            //Mostramos todos los productos ingresados
            for (int i = 0; i < contadorP; i++)
            {
                Console.WriteLine("Producto " + (i + 1) + ": " + tiendacosas[i]);
            }
            //Guardamos el producto que se desea y la cantidad en sus respectivos arreglos en la posición del almacén
            productos[productosCont] = Operaciones.getTextoPantalla("> ");
            Console.WriteLine(" ");
            Console.Write("Coloque la cantidad a ingresar: \n> ");
            cantidadA[cantidadCont] = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------\n" +
                "Confirmación: Producto ingresado en el almacén exitosamente.");
            productosCont++;
            cantidadCont++;
            almacenesCont++;

        }
        public static void ExtraerProducto()
        {
            int posicion = 0;
            string texto = "===== Pantalla para Extraer Producto de Almacén =====\n" +
                "--------------------------------------------------\n" +
                "Seleccione el almacén: ";
            Console.WriteLine(texto);
            //Mostramos todos los almacenes
            for (int i = 0; i < contadorN; i++)
            {
                Console.WriteLine("Almacén " + (i + 1) + ": " + nombre[i]);
            }
            //Guardamos el almacén a buscar
            string almacen = Operaciones.getTextoPantalla("> ");
            Console.WriteLine(" ");
            //Buscamos el almacén y guardamos su posición
            for (int i = 0; i < contadorN; i++)
            {
                if (almacenes[i] == almacen)
                {
                    posicion = i;
                }
            }
            Console.WriteLine("Seleccione el producto a extraer: ");
            //Mostramos todos los productos ingresados
            for (int i = 0; i < contadorP; i++)
            {
                Console.WriteLine("Producto " + (i + 1) + ": " + tiendacosas[i]);
            }
            //Guardamos el producto a extraer y lo modificamos
            Console.Write("> ");
            string productoExtraer = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Ingrese la cantidad a extraer: \n> ");
            int cantidadExtraer = int.Parse(Console.ReadLine());
            cantidadA[posicion] -= cantidadExtraer;
            Console.WriteLine("------------------------------------------------\n" +
                "Confirmación: Producto extraído del almacén exitosamente.");
        }
        public static void VerStock()
        {
            string texto2 = "===== Pantalla para Ver Stock Actual =====\n" +
                "--------------------------------------------------\n"+
                    "Stock Actual en Todos los Almacenes: ";
            Console.WriteLine(texto2);
                for (int i = 0; i < productosCont; i++)
                {
                    Console.WriteLine($"Producto {i + 1}: [{productos[i]}] - Almacén: [{almacenes[i]}] - Cantidad: [{cantidadA[i]}]");
                }
            Console.ReadKey();
            Console.Clear();
        }

    }

}