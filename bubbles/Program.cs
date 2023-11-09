class Program
{
    public static void Main(string[] args)
    {
        Collatz();
    }
    

    public static void Collatz()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("***WHOLE OR NOT WHOLE***");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Enter a positive Integer:");

        string? numI = Console.ReadLine();
        int numbersMax = 0;
        List<int> numbersGenerated = new List<int>();

        if (int.TryParse(numI, out int number) && number > 0)
        {

            Console.WriteLine($" Going through the number --- {number} --- :");
            do
            {

                numbersGenerated.Add(number);

                if (number > numbersMax)
                {
                    numbersMax = number;
                }

                if (number % 2 == 0)
                {

                    number /= 2;
                }
                else
                {

                    number = number * 3 + 1;

                }

                Console.WriteLine(number);

            } while (number != 1);

            Bubbles(numbersGenerated);

         
        }
        else
        {
            Console.WriteLine("It is not a positive integer.");
        }

        Console.WriteLine($"The max number is:  {numbersMax}");
    }


    public static void Bubbles(List<int> listDesorden)
    {
        for (int bubbles = 0; bubbles < listDesorden.Count - 1; bubbles++)
        {
            for (int vaso = 0; vaso < listDesorden.Count - 1 - bubbles; vaso++)
            {
                if (listDesorden[vaso] > listDesorden[vaso + 1])
                {
                    
                    listDesorden[vaso] = listDesorden[vaso] + listDesorden[vaso + 1];
                    listDesorden[vaso + 1] = listDesorden[vaso] - listDesorden[vaso + 1];
                    listDesorden[vaso] = listDesorden[vaso] - listDesorden[vaso + 1];
                }
            }
        }
    

            Console.WriteLine("numbers ordenated");

            foreach (int numbers in listDesorden)
            {

                Console.WriteLine(numbers);
            }   
    }
    

}   

