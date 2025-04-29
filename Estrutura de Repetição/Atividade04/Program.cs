class Program
{
    static void Main()
    {

        int contador = 2;

        Console.WriteLine("Informe um número");
        int num = int.Parse(Console.ReadLine());

        while (contador <= num)
        {
            Console.WriteLine(contador);
            contador += 2;

        }
    }
