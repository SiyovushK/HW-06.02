class Program
{
    static void Main (string[] args)
    {

        /* Task A */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     if (i%2 == 0)
        //     {
        //         System.Console.Write(numbers[i] + " ");
        //     }
        // }


        /* Task B */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

        // foreach (var item in numbers)
        // {
        //     if (item%2 == 0)
        //     {
        //         System.Console.Write(item + " ");
        //     }
        // }


        /* Task C */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);
        // int cnt = 0;
        // foreach (var item in numbers)
        // {
        //     if (item >= 0)
        //     {
        //         cnt++;
        //     }
        // }
        // System.Console.WriteLine(cnt);


        /* Task D */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);
        // int cnt = 0;
        // for (int i = 0; i < numbers.Length-1; i++)
        // {
        //     if (numbers[i] < numbers[i+1])
        //     {
        //         cnt++;
        //     }
        // }
        // System.Console.WriteLine(cnt);


        /* Task E */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);
        // int cnt = 0;
        // for (int i = 0; i < numbers.Length-1; i++)
        // {
        //     if (numbers[i] > 0 && numbers[i+1] > 0 || numbers[i] < 0 && numbers[i+1] < 0)
        //     {
        //         cnt++;
        //     }
        // }
        // if (cnt > 0)
        // {
        //     System.Console.WriteLine("YES");
        // }
        // else
        // {
        //     System.Console.WriteLine("NO");
        // }


        /* Task F */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);
        // int cnt = 0;
        // for (int i = 1; i < numbers.Length-1; i++)
        // {
        //     if (numbers[i-1] < numbers[i] && numbers[i] > numbers[i+1])
        //     {
        //         cnt++;
        //     }
        // }
        // System.Console.WriteLine(cnt);


        /* Task G */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

        // int start = 0;
        // int end = numbers.Length - 1;
        
        // while (start < end)
        // {
        //     int temp = numbers[start];
        //     numbers[start] = numbers[end];
        //     numbers[end] = temp;

        //     start++;
        //     end--;
        // }

        // foreach (int num in numbers)
        // {
        //     Console.Write(num + " ");
        // }


        /* Task H */
        // System.Console.WriteLine("Enter numbers in a row with space between them: ");
        // string input = Console.ReadLine();
        // int[] numbers = Array.ConvertAll(input.Split(), int.Parse);
        
        // for (int i = 0; i < numbers.Length-1; i+=2)
        // {
        //     int temp = numbers[i];
        //     numbers[i] = numbers[i+1];
        //     numbers[i+1] = temp;
        // }
        // foreach (var item in numbers)
        // {
        //     System.Console.Write(item + " ");
        // }


        /* Task I */
        System.Console.WriteLine("Enter numbers in a row with space between them: ");
        string input = Console.ReadLine();
        int[] numbers = Array.ConvertAll(input.Split(), int.Parse);
        
        System.Console.Write(numbers[numbers.Length-1] + " ");
        for (int i = 0; i < numbers.Length-1; i++)
        {
            System.Console.Write(numbers[i] + " ");
        }



    }
}