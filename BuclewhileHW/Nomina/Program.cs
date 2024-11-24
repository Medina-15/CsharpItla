namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nomina();
        }
        static void nomina()
        {
            Console.WriteLine("Este programa calcula la cantidad de empleados que tienen un salario en un rango de 100$ a 300$ y por encima de 300 con un limite de 500");

            // Declaracion de variables

            int min = 100;
            int mid = 300;
            int max = 500;
            int empleados = 0;
            double totalnomina = 0;
            double sueldo = 0;
            int rango1 = 0;
            int rango2 = 0;
            string valor= string.Empty;
            int index = 1;

            // Recoleccion de datos

            Console.WriteLine("Escribra la cantidad de empleados");
            valor= Console.ReadLine();

            if (!int.TryParse(valor, out empleados))
            {
                Console.WriteLine("Digite un numero entero");
            }

            if (empleados <= 0)
            {
                Console.WriteLine("El valor no puede ser negativo");
            }

            while (empleados >= index)
            {
                Console.WriteLine($"Escriba la el salario del empleado {index}");
                valor = Console.ReadLine();

                if (!double.TryParse(valor, out sueldo))
                {
                    Console.WriteLine("Debe de escribir un numero entero");
                    continue;
                }

                if (sueldo <= max && sueldo > mid)
                {
                    rango1++;
                }

                else if (sueldo >= min && sueldo <= mid)
                {
                    rango2++;
                }

                else
                {
                    Console.WriteLine("Debe ingresar un monto en un rango de 100 a 500");
                    continue;
                }

                totalnomina += sueldo;
                index++;

            }

            Console.WriteLine($"La cantidad de de empleados con un sueldo entre 100 y 300 es: {rango2} y los que tienen un sueldo por encima de 300: {rango1} y la suma total de la nomina es {totalnomina}");
        }
    }
}
