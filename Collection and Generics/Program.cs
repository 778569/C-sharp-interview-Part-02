internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums;
        double[] otherNums = new double[5];

        string[] availablePets = { "cat", "dog", "fish" };
        string[] unavailablePets = { "bird", "rabbit", "hamster", "gerbil" };

        for (int i = 0; i < availablePets.Length; i++)
        {
            Console.WriteLine(availablePets[i]);
        }

        Console.WriteLine();

        foreach (var x in unavailablePets)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine();

        Array.ForEach(availablePets, Console.WriteLine);
        Console.WriteLine();

        Array.ForEach(unavailablePets, Console.WriteLine);

        Console.ReadLine();
    }
}