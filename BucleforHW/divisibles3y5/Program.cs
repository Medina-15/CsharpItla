namespace divisibles3y5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            divisibles();
        }

        private static void divisibles()
        {
            Console.WriteLine("Este programa cuenta los numeros que son divisibles por 3 y 5 en un conjunto de 10 numeros");

            // Declarando variables

            int numero = 0;
            int divisibles = 0;
            int iteraciones = 10;
            string valor = string.Empty;

            try
            {
                for (int i = 1; i <= iteraciones; i++)
                {
                    Console.WriteLine($"Escriba el digito numero: {i}");
                    valor = Console.ReadLine();

                    
                    
                    if (!int.TryParse(valor, out numero))
                    {
                        Console.WriteLine("Debe ingresar un numero entero");
                    }

                    if (numero < 0)
                    {
                        Console.WriteLine("El numero no puede ser negativo");
                    }

                    if (numero % 3 == 0 && numero % 5 == 0)
                    {
                        divisibles++;
                    }

                }

                Console.WriteLine($"La cantidad de numeros divisibles por 3 o por 5 son {divisibles}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado, intente de nuevo {ex.Message}");
            } 
        }
    }
}
