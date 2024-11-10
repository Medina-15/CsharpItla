namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculocondicional();
        }

        private static void Calculocondicional()
        {
            Console.WriteLine("Este programa pide dos numeros, si el primero es mas grande se le realiza una suma y resta, de lo contrario mostrara su producto y cociente. ");

            // Declarando variables

            double num1 = 0;
            double num2 = 0;
            double suma = 0;
            double resta = 0;
            double cociente = 0;
            double producto = 0;

            // recoleccion de datos

            Console.WriteLine("Digite el primer numero");
            num1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Desarrollo de las condiciones y operaciones

            if (num1 >= num2)
            {
                suma = num1 + num2;
                resta = num1 - num2;
                Console.WriteLine($"La suma de los numeros es igual a {suma} y la resta es igual a {resta}");
            }

            else
            {
                cociente = num1 / num2;
                producto = num1 * num2;
                Console.WriteLine($"El cociente de los numeros es igual a {cociente} y el producto es igual a {producto}");

            }
        }
    }
}
