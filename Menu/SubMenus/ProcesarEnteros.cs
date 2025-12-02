using System;

namespace ACT_MI.SubMenus
{
    public class ProcesarEnteros
    {
        public void Procesar()
        {
            int opcion = 0;// Aquí guardamos lo que el usuario quiere hacer

            // Esto es un bucle que no para hasta que se seleccione la opcion de salir
            while (opcion != 6)
            {
                 // Mostramos el menú
                Console.WriteLine("MENU ENTERO");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Otra");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");

                try // Se pone esto por si se trata de escribir algo diferente
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    //Dependes de lo que se elija, se hacen diferentes cosas
                    switch (opcion)
                    {
                        case 1:
                            Sumar();
                            break;
                        case 2:
                            Restar();
                            break;
                        case 3:
                            Multiplicar();
                            break;
                        case 4:
                            Dividir();
                            break;
                        case 5:
                            Otra();
                            break;
                        case 6:
                            Console.WriteLine("Volviendo..");
                            break;
                        default:
                            // Si elegiste un número que no está en el menú
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException) // Si se escribio letras en lugar de números
                {
                    Console.WriteLine("Error: Debe ingresar un numero valido.");
                }
                catch (Exception ex) // Si pasó algo raro que no esperábamos
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }
            }
        }

        //operación de suma
        private void Sumar()
        {
            Console.WriteLine("SUMA");
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // Primero número
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); // Segundo número
            
            int resultado = num1 + num2; // lo juntamos
            // Vista de la operación completa
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
        }
        //operación  de resta
        private void Restar()
        {
            Console.WriteLine("RESTA");
            // Minuendo
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Sustraendo
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            //Calculo de la diferencia
            int resultado = num1 - num2;
            // Vista de la operación completa
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
        }

        // operación de multiplicación
        private void Multiplicar()
        {
            Console.WriteLine("MULTIPLICACIÓN");
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // Cálculo del producto
            int resultado = num1 * num2;
            // Vista de la multiplicación
            Console.WriteLine($"Resultado: {num1} × {num2} = {resultado}");
        }

        // operación de división
        private void Dividir()
        {
            Console.WriteLine("DIVISIÓN");
            try
            {
                //Dividiendo
                Console.Write("Ingrese el dividendo: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                //Divisor
                Console.Write("Ingrese el divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                // no se puede dividir por cero
                if (divisor == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    return;
                }

                int resultado = dividendo / divisor;
                // Resultado en consola
                Console.WriteLine($"Resultado: {dividendo} ÷ {divisor} = {resultado}");
            }
            // Captura específica de excepción por división entre cero
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: División entre cero no permitida.");
            }
        }

        // Otras operaciones adicionales de un solo entero
        private void Otra()
        {
            Console.WriteLine("OTRAS OPERACIONES");
            // Entrada del valor
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            // Valor absoluto (magnitud sin signo)
            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            // potencia de exponente 2
            Console.WriteLine($"Elevado al cuadrado: {numero * numero}");
            // Operador ternario para representación booleana textual
            Console.WriteLine($"¿Es par?: {(numero % 2 == 0 ? "Sí" : "No")}");
            // positivo o negativo incluyendo cero
            Console.WriteLine($"¿Es positivo?: {(numero >= 0 ? "Sí" : "No")}");
        }
    }
}