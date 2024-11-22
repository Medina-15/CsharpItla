namespace sumarnumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumarnumeros();
        }

        private static void sumarnumeros()
        {
            Console.WriteLine("Estre programa obtiene 10 numeros y luego suma los ultimos 5 que fueron ingresados");

            // Declaranro variables

            double suma = 0;
            double numero = 0;
            int ieraciones = 10;
            string valor = string.Empty;

            // Recolentando los datos

            for (int i = 1; i <= ieraciones; i++)
            {
                Console.WriteLine($"Escriba el digito numero: {i}");
                valor = Console.ReadLine();

                if (!double.TryParse(valor, out numero))
                {
                    Console.WriteLine("Digite un numero valido");
                }

                // Si el pasan 5 iteraciones empezar a sumar los numeros restantes

                if (i >= 6)
                {
                    suma += numero;
                }

            }

            Console.WriteLine($"El resultado de la suma de los ultimos 5 numeros es: {suma}");

        }


    }
}
