internal class Program
{
    private static void Main(string[] args)
    {
        //int[] nums;
        //double[] otherNums = new double[5];

        //string[] availablePets = { "cat", "dog", "fish" };
        //string[] unavailablePets = { "bird", "rabbit", "hamster", "gerbil" };



        //var fishIndex = 2;
        //var birdIndex = 0;

        ////availablePets.Append("Gappi");

        //Console.WriteLine(availablePets.Contains("dog"));
        //Console.WriteLine(Array.IndexOf(availablePets, "dog"));

        //Console.ReadLine();
        //string pet1 = availablePets[fishIndex];

        //string pet2 = unavailablePets[birdIndex];

        //availablePets[fishIndex] = pet2;

        //unavailablePets[birdIndex]= pet1;




        //for (int i = 0; i < availablePets.Length; i++)
        //{
        //    Console.WriteLine(availablePets[i]);
        //}

        //Console.WriteLine();

        //foreach (var x in unavailablePets)
        //{
        //    Console.WriteLine(x);
        //}

        //Console.WriteLine();

        //Array.ForEach(availablePets, Console.WriteLine);
        //Console.WriteLine();

        //Array.ForEach(unavailablePets, Console.WriteLine);

        //Console.ReadLine();

        int[] t1 = { 5, 3, 2, 5, 7, 0, 1 };
        int[] t2 = { -2, -1, -3, 4, 8, 0 };
        int[] t3 = { -20, -10, 3, 9, -8 };

        Console.WriteLine(MaximumProduct(t1));
        Console.WriteLine(MaximumProduct(t2));
        Console.WriteLine(MaximumProduct(t3));

        Console.ReadLine();
    }

    public static int MaximumProduct(int[] arr)
    {
        int length = arr.Length;
        int max = Int32.MinValue;


        if(length < 2)
        {
            Console.WriteLine("Array has only one value");
            return max;
        }

        for (int i = 0; i < length; i++)
        {

            for (int j = i+1 ; j < length; j++)
            {
                if (arr[i] * arr[j] > max)
                {
                    max = arr[i] * arr[j];
                }
            }
        }
        return max;
    }
}