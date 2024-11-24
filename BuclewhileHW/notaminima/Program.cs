namespace notaminima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            notaminima();
        }

        private static void notaminima()
        {
            Console.WriteLine("Este programa recibe x cantidad de calificaciones y cuenta las que las que son iguales a la nota minima que es 7 y a las que estan por debajo de esta");

            // Declarando variables

            int calificaciones = 0;
            int min = 7;
            int notasminimas = 0;
            int notasreprobadas = 0;
            double nota = 0;
            int index = 1;
            string valor = string.Empty;

            // Recoleccion de datos

            Console.WriteLine("Escriba la cantidad de datos");
            valor = Console.ReadLine();

            if (!int.TryParse(valor, out calificaciones))
            {
                Console.WriteLine("Debe ingresar un numero entero");
            }

            if (calificaciones <= 0)
            {
                Console.WriteLine("El valor no puede ser igual a 0 o un numero negativo");
            }

            // Recolectando las calificaciones

            while (index <= calificaciones)
            {
                Console.WriteLine($"Digite la nota {index} ");
                valor= Console.ReadLine();

                if (!double.TryParse(valor, out nota))
                {
                    Console.WriteLine("Debe ingresar un valor valido, intente de nuevo");
                    continue;
                }

                if (nota == min)
                {
                    notasminimas++;
                }

                else if (nota < min)
                {
                    notasreprobadas++;
                }

                index++;
            }

            Console.WriteLine($"La cantidad de notas minimas son: {notasminimas} y las reprobadas son {notasreprobadas}");


        }
    }
}
