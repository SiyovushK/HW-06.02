/* Task A */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int cnt = 0;
// while (true)
// {
//     int number = int.Parse(Console.ReadLine());
//     if (number == 0)
//     {
//         System.Console.WriteLine(cnt);
//         break;
//     }
//     cnt++;
// }


/* Task B */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int cnt = 0;
// while (true)
// {
//     int number = int.Parse(Console.ReadLine());
//     if (number == 0)
//     {
//         System.Console.WriteLine("Sum of numbers: " + cnt);
//         break;
//     }
//     cnt += number;
// }


/* Task C */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// double cnt = 0, sum = 0;
// double result = 0;
// while (true)
// {
//     double number = double.Parse(Console.ReadLine());
//     sum += number;
//     if (number == 0)
//     {
//         System.Console.WriteLine(result);
//         break;
//     }
//     cnt ++;
//     result = sum/cnt;
// }


/* Task D */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int even = 0;
// while (true)
// {
//     double number = double.Parse(Console.ReadLine());
//     if (number == 0)
//     {
//         System.Console.Write($"Quantity of even numbers: {even}");
//         break;
//     }
//     if (number%2 == 0)
//     {
//         even++;
//     }
// }


/* Task E */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int max = -1;
// while (true)
// {
//     int number = int.Parse(Console.ReadLine());
//     if (number == 0)
//     {
//         System.Console.Write($"Largest number is: {max}");
//         break;
//     }
//     if (number > max)
//     {
//         max = number;
//     }
// }


/* Task F */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int number = int.Parse(Console.ReadLine());
// int cnt = 0;
// while (true)
// {
//     int num = int.Parse(Console.ReadLine());
//     int next = number;
//     if (num == 0)
//     {
//         System.Console.Write($"Sum of numbers bigger then previous: {cnt}");
//         break;
//     }
//     if (num > number)
//     {
//         cnt++;
//     }
//     else
//     {
//         number = num;
//     }
// }


/* Task G and H */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int largest = -1, secondLargest = -1;
// while (true)
// {
//     int number = int.Parse(Console.ReadLine());

//     if (number == 0)
//     {
//         System.Console.WriteLine("Second largest number: " + secondLargest);
//         break;
//     }

//     if (number > largest)
//     {
//         secondLargest = largest;
//         largest = number;
//     }
//     else if (number > secondLargest && number != largest)
//     {
//         secondLargest = number;
//     }
// }


/* Task I */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int number = int.Parse(Console.ReadLine());
// int max = number;
// int cnt = 1;
// while (true)
// {
//     int num = int.Parse(Console.ReadLine());
//     if (num == 0)
//     {
//         System.Console.Write($"Quantity of elements equal to largest: {cnt}");
//         break;
//     }
//     if (max == num)
//     {
//         cnt++;
//     }
//     else if (num > max)
//     {
//         max = num;
//         cnt = 1;
//     }
// }


/* Task J */
// System.Console.WriteLine("Enter numbers, press 0 twise to finish.");
// int sum = 0;
// int previous = -1;
// while (true)
// {
//     int num = int.Parse(Console.ReadLine());
//     if (previous == 0 && num == 0)
//     {
//         System.Console.Write($"Sum of elements: {sum}");
//         break;
//     }
//     sum += num;
//     previous = num;
// }


/* Task K */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int sum = 1;
// int previous = -1;
// while (true)
// {
//     int num = int.Parse(Console.ReadLine());
//     if (num == 0)
//     {
//         System.Console.Write($"Quantity of equal back to back numbers: {sum}");
//         break;
//     }
//     if (num == previous)
//     {
//         sum++;
//     }
//     previous = num;
// }


/* Task L */
// System.Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int maxLength = 1;
// int currentLength = 1;
// int? prev = null;
// bool isIncreasing = false;
// bool isDecreasing = false;

// while (true)
// {
//     int current = int.Parse(Console.ReadLine());

//     if (current == 0){
//         break;
//     }

//     if (prev == null)
//     {
//         prev = current;
//         continue;
//     }

//     if (current > prev)
//     {
//         if (isDecreasing)
//         {
//             maxLength = Math.Max(maxLength, currentLength);
//             currentLength = 1;
//             isDecreasing = false;
//         }

//         isIncreasing = true;
//         currentLength++;
//     }
    
//     else if (current < prev)
//     {
//         if (isIncreasing)
//         {
//             maxLength = Math.Max(maxLength, currentLength);
//             currentLength = 1;
//             isIncreasing = false;
//         }

//         isDecreasing = true;
//         currentLength++;
//     }
//     else
//     {
//         maxLength = Math.Max(maxLength, currentLength);
//         currentLength = 1;
//         isIncreasing = false;
//         isDecreasing = false;
//     }

//     prev = current;
// }

// maxLength = Math.Max(maxLength, currentLength);
// Console.WriteLine("Max length of monotone fragment: " + maxLength);


/* Task M */
// Console.WriteLine("Enter numbers, press 0 if you want to finish.");
// int cnt = 0, next = 0;
// int prev = int.Parse(Console.ReadLine());
// int current = int.Parse(Console.ReadLine());

// if (prev == 0) return;

// while (current != 0)
// {
//     next = int.Parse(Console.ReadLine());

//     if (current > prev && current > next)
//     {
//         cnt++;
//     }

//     prev = current;
//     current = next;
// }

// Console.WriteLine("Quantity of local maximums: " + cnt);