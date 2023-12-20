namespace Ejercicio5arrays
{
    class program
    {
        public static void Main(String[] args)
        {

            Random random = new Random();
            Console.WriteLine("Eliga el tamaño que quieres que tenga el vector :");
            int tamanioVector = Convert.ToInt32(Console.ReadLine());

            int[] Vnumeros = new int[tamanioVector];

            for (int i = 0; i < tamanioVector; i++)
            {
                int valorRandom = random.Next(1, 100);
                Vnumeros[i] = valorRandom;

            }
            Array.Sort(Vnumeros);
            for (int k = 0; k < tamanioVector; k++)
            {
                Console.WriteLine(Vnumeros[k]);
            }

        }
    }
}
