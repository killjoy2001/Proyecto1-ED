using System;

namespace Proyecto1
{
    internal class Ejercicio3
    {
        string[] proveedor = new string[5];
        string[] ciudad = new string[5];
        int[] articulos = new int[5];

        byte menu;
        public void Menu()
        {
            Console.WriteLine("Ingrese la acción que desea hacer:\r\n 1. Consultar información de proveedor" +
                "\r\n 2. Actualizar cuidad de proveedor \r\n 3. Actualizar cantidad de artículos \r\n 4. Agregar proveedor nuevo" +
                "\r\n 5. Remover proveedor \r\n 6. Consultar todos los datos");
            menu = byte.Parse(Console.ReadLine());
            if (menu > 5) {
                RecorrerArreglos();
            } else if (menu > 4)
            {
                EliminarProveedor();
            } else if (menu > 3)
            {
                AgregarProveedor();
            } else if (menu > 2)
            {
                ActualizarCalculo();
            } else if (menu > 1)
            {
                ActualizarCiudad();
            } else { UbicarInfo(); }

            Console.Clear();
        }

        // a) concultar info relacionada a proveedor ingresado
        public void UbicarInfo()
        {
            Console.WriteLine("Ingrese proveedor");
            string consultaProveedor = Console.ReadLine().ToUpper();

            for (int i = 0; i < 5; i++)
            {
                if (consultaProveedor == proveedor[i].ToUpper())
                {
                    Console.WriteLine("El proveedor " + proveedor[i] + " se ubica en la cuidad " + ciudad[i] + " y ofrece " + articulos[i] + " articulos.");
                }
            }
            VolverMenu();
        }

        // b) actualizar ciudad del proveedor ingresado
        public void ActualizarCiudad()
        {
            Console.WriteLine("Ingrese proveedor al que desea ");
            string consultaProveedor = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la nueva cuidad");
            string actualizarCuidad = Console.ReadLine().ToUpper();
            for (int i = 0; i < 5; i++)
            {
                if (consultaProveedor == proveedor[i].ToUpper())
                {
                    ciudad[i] = actualizarCuidad.ToUpper();
                }
            }
            VolverMenu();
        }

        // c) restar/sumar articulos del proveedor ingresado
        public void ActualizarCalculo()
        {
            
            int montoArticulo;
            Console.WriteLine("Ingrese la acción que desea hacer:\r\n 1. Sumar artículos a proveedor \r\n 2. Restar artículos a proveedor");
            menu = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese proveedor al que desea ");
            string consultaProveedor = Console.ReadLine().ToUpper();

            for (int i = 0; i < 5; i++)
            {
                if (consultaProveedor == proveedor[i].ToUpper())
                {
                    if (menu == 2)
                    {
                        Console.WriteLine("Ingrese la cantidad que desea restar");
                        montoArticulo = int.Parse(Console.ReadLine());
                        articulos[i] = articulos[i] - montoArticulo;

                        Console.WriteLine("Cantidad de artículos actualizado a " + articulos[i]);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la cantidad que desea sumar");
                        montoArticulo = int.Parse(Console.ReadLine());
                        ciudad[i] = ciudad[i] + montoArticulo;

                        Console.WriteLine("Cantidad de artículos actualizado a "+articulos[i]);
                    }
                }
            }
            VolverMenu();
        }
        // pendientes ** ya se llamaron desde el menú **
        public void AgregarProveedor()
        {


            VolverMenu();
        }

        public void EliminarProveedor()
        {


            VolverMenu();
        }

        public void RecorrerArreglos()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(proveedor[i].ToUpper()+ "\r\n Ciudad: " + ciudad[i]+ "\r\nCantidad de artículos: " + articulos[i]);
            }
            Console.ReadLine();
            VolverMenu();
        }

        // método para volver al menú
        public void VolverMenu()
        {
            Console.WriteLine("¿Desea volver al menú principal? \r\n 1. Sí \r\n 2. No");
            menu = byte.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Menu();
            }
        }
    }
} 
