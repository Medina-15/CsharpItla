namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testcondition();
        }

        private static void testcondition()
        {
            Console.WriteLine("Este programa recibe la cantidad de preguntas de un test y la cantidad de aciertos de un estudiante, luego le asigna un nivel dependiendo el porcentaje de aciertos.");

            // Declarando variables

            double preguntas = 0;
            double aciertos = 0;
            double porcentajeaciertos = 0;

            // Recolectando datos

            Console.WriteLine("Escriba la cantidad de preguntas del test");
            preguntas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba la cantidad de preguntas correctas");
            aciertos = Convert.ToDouble(Console.ReadLine());

            // Operacion para hallar el porcentaje

            porcentajeaciertos = aciertos * 100 / preguntas;

            // Condiciones para asignar un nivel

            if (aciertos > preguntas)
            {
                Console.WriteLine("El numero de aciertos no puede ser mayor que el numero de preguntas, intente de nuevo");
            }

            else if (porcentajeaciertos >= 90)
            {
                Console.WriteLine($"El estudiante obtuvo el maximo nivel en el test con un porcentaje de {porcentajeaciertos}%");
            }
            
            else if (porcentajeaciertos >= 75) 
            {
                Console.WriteLine($"El estudiante obtuvo un nivel medio en el test con un porcentaje de {porcentajeaciertos}%");
            }
            
            else if (porcentajeaciertos >= 50)
            {
                Console.WriteLine($"El estudiante obtuvo un nivel regular en el test con un porcentaje de {porcentajeaciertos}%");
            }
            
            else
            {
                Console.WriteLine($"El estudiante esta fuera de nivel en el test con un porcentaje de {porcentajeaciertos}%");
            }
            

            
        }
    }
}
