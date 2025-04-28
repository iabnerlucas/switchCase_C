class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o dia: ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
            break;

            case 2:
                Console.WriteLine("Segunda");
            break;

            case 3:
                Console.WriteLine("Terça");
            break;

            case 4:
                Console.WriteLine("Quarta");
            break;

            case 5:
                Console.WriteLine("Quinta");
            break;

            case 6:
                Console.WriteLine("Sexta");
            break;

            case 7:
                Console.WriteLine("Sábado");
            break;

            default:
                Console.WriteLine("Dia inesixtente");
            break;  

        }
    }
}