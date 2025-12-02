using System;
using ACT_MI.SubMenus;

namespace ACT_MI
{
    public class Menus
    {
        // declaracion de las variables de los procesadores
        private ProcesarEnteros _procesarEnteros; // Procesador de operaciones con enteros
        private ProcesarStrings _procesarStrings; // Procesador de operaciones con strings
        private ProcesarArreglos _procesarArreglos; // Procesador de operaciones con arreglos

        // Constructor de la clase Menus
        public Menus()
        {
            // Creación de instancias de cada procesador
            _procesarEnteros = new ProcesarEnteros();
            _procesarStrings = new ProcesarStrings();
            _procesarArreglos = new ProcesarArreglos();
        }

        public void Menu()
        {
            int option = 0; // Variable que sirve para tener lo que selecciono el usuario

            // Bucle que sigue sin que pare hasta que se elija salir
            while (option != 4)
            {
                Console.WriteLine("Ingrese una opcion del menu:");
                Console.WriteLine("1: Enteros");
                Console.WriteLine("2: Strings");
                Console.WriteLine("3: Arreglos");
                Console.WriteLine("4: Me voy");
                try
                {
                    // Lectura y conversión de la entrada del usuario a entero
                    option = Convert.ToInt32(Console.ReadLine());
                    // Estructura para mandar al submenu que le corresponde
                    switch (option)
                    {
                        case 1:
                            {
                                // Si se selecciona activa el procesador de operaciones con enteros
                                _procesarEnteros.Procesar();
                                break;
                            }
                        case 2:
                            {
                                // lo mismo con el procesador de operaciones con strings
                                _procesarStrings.Procesar();
                                break;
                            }
                        case 3:
                            {
                                // por ultimo lo mismo con el procesador de operaciones con arreglos
                                _procesarArreglos.Procesar();
                                break;
                            }
                        case 4:
                            {
                                // mensaje para salir del bucle
                                Console.WriteLine("Me fui");
                                break;
                            }
                        default:
                            {
                                // Para opciones que estan fuera del rango
                                Console.WriteLine("Intente con una opción del menú válida.");
                                break;
                            }
                    }
                }
                catch (Exception e) // Captura cualquier excepción en la conversión
                {
                    // por si se escribe otra cosa que no sea un numero
                    Console.WriteLine("El tipo ingresado no es valido.");
                    continue; 
                }
            }
        }
    }
}