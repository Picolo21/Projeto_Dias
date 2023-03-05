internal class Program
{
    private static void Main(string[] args)
    {
        int first_year;
        int last_year;
        int days;

        do
        {
            Console.Clear();
            Console.Write("Informe o 1° ano: ");
            first_year = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2° ano: ");
            last_year = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (first_year > last_year)
            {
                Console.WriteLine("O primeiro ano informado deve ser MENOR ou IGUAL ao segundo ano informado");
                Console.WriteLine();
                Console.WriteLine("Aperte a tecla ENTER para informar novos valores");
                Console.ReadKey();
            }
        } while (first_year > last_year);

        days = (last_year - first_year + 1) * 365;
        int count = first_year;

        do
        {
            if ((count % 4 == 0) && (count % 100 != 0) || (count % 400 == 0))
            {
                days += 1;
            }
            count++;
        } while (count <= last_year);

        Console.WriteLine(days);
    }
}