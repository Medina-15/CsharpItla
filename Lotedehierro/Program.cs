namespace Lotedehierro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcularlote();
        }

        static void Calcularlote()
        {
            Console.WriteLine("A este programa se le agrega una cantidad de hierro cada uno con su longitud y se cuenta los que tengan una longitud de 1.20 a 1.30");

            // Declarando variables

            double min = 1.20;
            double max = 1.30;
            double longitud = 0;
            int numerodDaciertos= 0;
            int fueraderango = 0;
            int iteraciones = 0;
            int index = 1;
            string Value= string.Empty;

            
            try
            {
                Console.WriteLine("Ingrese el numero de piezas que va a ingresar:");
                Value = Console.ReadLine();

                // Controlando errores

                if (!int.TryParse(Value, out iteraciones))
                {
                    Console.WriteLine("La cantidad de numeros es requerida");
                    return;
                }

                if (iteraciones < 0)
                {
                    Console.WriteLine("El valor debe ser un numero positivo");
                    return;
                }

                // Extrayendo los datos requeridos

                while (index <= iteraciones)
                {
                    Console.WriteLine($"Ingrese la longitud de la pieza numero {index}");
                    Value = Console.ReadLine();

                    if (!double.TryParse(Value, out longitud))
                    {
                        Console.WriteLine("Introduzca una longitud valida");
                        continue;
                    }

                    if (longitud >= min && longitud <= max)
                    {
                        numerodDaciertos++;
                    }

                    else
                    {
                        fueraderango++;
                    }

                    index++;

                }

                // Resultado

                Console.WriteLine($"El numero de piezas con una longitud dentro del rango requerido son {numerodDaciertos} y los que estan fuera de rango son {fueraderango}");



            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error encontrado, verifique los datos ingresados {ex.Message}");
            }
        }
    }
}
