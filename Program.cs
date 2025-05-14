public class Program
{
    private static void Main(string[] args)
    {
        double rate = 25964.48;
        Console.Write("United States Dollar: ");
        bool isValid = double.TryParse(Console.ReadLine(), out double USD);
        if (!isValid)
        {
            Console.WriteLine("Dữ liệu nhập không đúng.");
            return;
        }
        double VND = USD * rate;
        Console.Write("Vietnamese dong: " + VND);
    }
}