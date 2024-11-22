namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculartriangulos();
        }

        static void Calculartriangulos()
        {
            Console.WriteLine("Este programa calcula el area de los triangulos dadas sus dimensiones y luego cuenta a los que excedan un area de 15cm");

            // Declaracion de variables

            int triangulos = 0;

            double Base = 0;
            double altura= 0;
            double area = 0;
            double excluidos = 0;
            string valor= string.Empty;

            // Recogiendo las dimensiones del triangulo

            
            try
            {
                Console.WriteLine("Escriba la cantidad de triangulos que quiere añadir");
                valor = Console.ReadLine();

                // Validando que los datos sean correctos

                if (!int.TryParse(valor, out triangulos))
                {
                    Console.WriteLine("Debe de agregar un numero entero");
                }

                if (triangulos < 0)
                {
                    Console.WriteLine("El valor no puede ser negativo");
                }

                for (int i = 1; i < triangulos; i++)
                {
                    Console.WriteLine($"Escriba la base del triangulo {i}");
                    valor = Console.ReadLine();

                    if (!double.TryParse(valor, out Base))
                    {
                        Console.WriteLine("El valor ingresado es incorrecto, intente de nuevo");
                    }

                    Console.WriteLine($"Escriba la altura del triangulo {i}");
                    valor = Console.ReadLine();

                    if (!double.TryParse(valor, out altura)) ;

                    Console.WriteLine("El dato ingresado no es correcto");

                    // Operacion para encontrar el area
                    
                    area = (0.5 * Base * altura);

                    // Identificando los triangulos con un area mayor a 15cm

                    if (area > 15)
                    {
                        excluidos++;
                    }

                }

                Console.WriteLine($"La cantidad de triangulos que exceden los 15 centimetros son: {excluidos}");
            }

            catch ( Exception ex)
            {
                Console.WriteLine ($"Error encontrado al ingresar los datos, intente de nuevo {ex.Message}");
            }



        }


    }
}
