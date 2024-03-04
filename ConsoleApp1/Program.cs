class Program
{
    static int[] RandomNumber()
    {
        int[] output = new int[6];
        int index = 0;

        // 1부터 45까지 중복없이 랜덤으로. 6개 출력.
        while (index < 6)
        {
            int randomValue = new Random().Next(1, 45);

            if(output.Contains(randomValue))
            {
                continue;
            }

            output[index] = randomValue;
            index++;
        }

        return output;
    }

    static void Main()
    {
        int[] result = RandomNumber();
        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}