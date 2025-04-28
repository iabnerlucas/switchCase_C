class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe a nota: ");
        char nota = char.Parse(Console.ReadLine());

        switch (nota)
        {
            case 'A':
                Console.WriteLine("Excelente");
                break;

            case 'B':
                Console.WriteLine("Bom");
                break;

            case 'C':
                Console.WriteLine("Regular");
                break;

            case 'D':
                Console.WriteLine("Ruim");
                break;

            case 'E':
                Console.WriteLine("Péssimo");
                break;

            default:
                Console.WriteLine("Inesixtente");
                break;
        }
    }
}
