class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe os dois números que serão usados: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o número que representa a operação desejada: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão \n 5 - Resto da Divisão ");
        int operacao = int.Parse(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                Console.WriteLine(num1 + " + " + num2 + " = " +  (num1 + num2));
            break;

            case 2:
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            break;

            case 3:
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            break;

            case 4:
                if(num2 == 0)
                {
                    Console.WriteLine("Divisão por 0, tente novamente!");
                }
                else
                {
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                }
                
            break;

            case 5:
                Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
            break;

            default: 
                Console.WriteLine("Operação Inesixtente");
            break;
        }
    }
}
