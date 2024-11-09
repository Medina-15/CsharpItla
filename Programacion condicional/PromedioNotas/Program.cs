namespace PromedioNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            promedioDnotas();
        }

        private static void promedioDnotas()
        {
            Console.WriteLine("A este programa se le entregan 3 notas y si el promedio es mayor a 7 califican al alumno como promovido");

            // Declarando variables

            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double promedio = 0;

            // Recoleccion de datos

            Console.WriteLine("Digite la primera nota");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la tercera nota");
            nota3 = Convert.ToDouble(Console.ReadLine());

            // Operacion

            promedio = (nota1 + nota2 + nota3) / 3;

            // Condicion

            if (promedio >= 7)
            {
                Console.WriteLine($"El estudiante ha sido promovido con un promedio de: {promedio}");
            }

            else
            {
                Console.WriteLine($"El estudiante no ha sido promovido con un promedio de: {promedio}");
            }
        }
    }
}
