namespace Practica2CursoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese 10 numeros");
            while (numeros.Count != 10)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numeros.Add(num);
            }
            numeros.Sort();
            Console.Clear();
            Console.WriteLine($"Lista Ordenada:");
            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
