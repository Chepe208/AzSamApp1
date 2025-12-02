using System;

namespace ACT_MI.SubMenus
{
    public class ProcesarStrings{
        public void Procesar()
        {
            int opcion = 0; // Variable para almacenar la selección del usuario

            while (opcion != 4)  // Bucle que mantiene el menú activo hasta que se seleccione la opción de salida
            {
                // Interfaz de usuario del submenú de operaciones con strings
                Console.Clear();
                Console.WriteLine("Submenú Strings");
                Console.WriteLine("1. Concatenar");
                Console.WriteLine("2. Buscar ");
                Console.WriteLine("3. Formato");
                Console.WriteLine("4. Volver");
                Console.Write("Elija una Opcion: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    // Estructura de opciones para el usuario
                    switch (opcion)
                    {
                        case 1:
                            Concatenar();
                            break;

                        case 2:
                            Buscar();
                            break;

                        case 3:
                            Formato();
                            break;

                        case 4:
                            Console.WriteLine("Volviendo al menú principal...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Vuelva a intentarlo.");
                            break;
                    }
                }
                catch
                // excepciones por si no se escribio numeros
                {
                    Console.WriteLine("Tiene que ingresar un número válido.");
                }

                // Pausa para que se puedan ver los resultados
                if (opcion != 4)
                {
                    Console.WriteLine(" Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // Método para concatenar dos cadenas de texto
        private void Concatenar()
        {
            // Se pide y se lee la primera cadena
            Console.Write("Escriba el primer texto: ");
            string texto1 = Console.ReadLine();

            // Se pide y se lee la segunda cadena
            Console.Write("Escriba el segundo texto: ");
            string texto2 = Console.ReadLine();

            // Se concatenan los dos textos con un espacion en medio
            string resultado = texto1 + " " + texto2;

            //Muestra el resultado
            Console.WriteLine($"Texto concatenado: {resultado}");
        }

        // Método para buscar una palabra y analizar cuantas vocales tiene la palabra buscada
        private void Buscar()
        {
            // Entrada de la frase principal
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            // Entrada de la palabra a buscar dentro de la frase
            Console.Write("Ingrese la palabra a buscar: ");
            string palabra = Console.ReadLine();

            // mirmos si existe la palabra en la frase usando Contains()
            if (frase.Contains(palabra))
            {
                Console.WriteLine("La palabra fue encontrada en la frase.");
            }
            else
            {
                Console.WriteLine("La palabra NO se encuentra en la frase.");
            }

            // Convierte la palabra a minúsculas
            string palabraMinus = palabra.ToLower();
            // Contadores individuales para cada vocal
            int a = 0, e = 0, i = 0, o = 0, u = 0;

            // Iteración sobre cada carácter de la palabra para contar vocales
            foreach (char c in palabraMinus)
            {
                switch (c)
                {
                    // Estructura switch para sumar el contador a la vocal que le toca
                    case 'a': a++; break;
                    case 'e': e++; break;
                    case 'i': i++; break;
                    case 'o': o++; break;
                    case 'u': u++; break;
                }
            }
            
            // Cálculo del total de vocales encontradas
            int totalVocales = a + e + i + o + u;
            // Presentación detallada del análisis de vocales
            Console.WriteLine($"\nLa palabra \"{palabra}\" tiene {totalVocales} vocal(es):");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"o = {o}");
            Console.WriteLine($"u = {u}");
        }

        // Método para cambiar el formato de mayúsculas a minúsculas de un texto
        private void Formato()
        {
            // Entrada del texto a formatear
            Console.Write("Ingrese un texto: ");
            string texto = Console.ReadLine();
            // aca se vuelve las palabras a mayusculas usando ToUpper()
            Console.WriteLine("Texto en mayúsculas: " + texto.ToUpper());
            // y aca a minúsculas usando ToLower()
            Console.WriteLine("Texto en minúsculas: " + texto.ToLower());
        }
    }
}

