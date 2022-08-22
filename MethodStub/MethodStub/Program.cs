using System;

public class MethodStubs
{
    // method1 case for converting milli meters to meters
    public static void ShowMeters(int numMillimeters)
    {
        Console.WriteLine(numMillimeters / (double)1000);
    }

    // method2 that takes two integers and displays their sum.
    public static void ShowSum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    // method3 that takes five doubles and returns their average.
    public static double Average(double n1, double n2, double n3, double n4, double n5)
    {
        double avg = (n1 + n2 + n3 + n4 + n5) / 5;
        return avg;
    }

    // method4 that returns the sum of two randomly generated integers.
    public static double RandomSum()
    {
        Random random = new Random();
        int num1 = random.Next(10, 50);
        int num2 = random.Next(10, 50);
        return num1 + num2;
    }

    // method5 that takes three integers and returns true if their sum is divisible by 3, false otherwise.
    public static bool IsDivisibleBy3(int n1, int n2, int n3)
    {
        int sum = n1 + n2 + n3;
        return sum % 3 == 0;
    }

    // method6 that takes two strings and displays the string that has fewer characters.
    public static void FindSmallestString(string s1, string s2)
    {
        if (s1.Length < s2.Length)
        {
            Console.WriteLine(s1);
        }
        else
        {
            Console.WriteLine(s2);
        }
    }

    // method7 that takes an array of doubles and returns the largest value in the array.
    public static int FindMaxElement(int[] arr)
    {
        // Initialize maximum element
        int max = arr[0];

        // Traverse array elements from second and
        // compare every element with current max
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    // method8 that generates and returns an array of fifty integer values.
    public static int[] FindArray()
    {
        // declare array
        int[] arr = new int[50];
        Random random = new Random();

        // Traverse array elements from second and
        // compare every element with current max
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(10, 50);
        }

        return arr;
    }

    // method9 that takes two bool variables and returns true if they have the same value, false otherwise.
    public static bool CheckBools(bool b1, bool b2)
    {
        if (b1 == true && b2 == true)
        {
            return true;
        }
        else if (b1 == false && b2 == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // method10 that takes an int and a double and returns their product.
    public static double FindMult(int num1, double num2)
    {
        return num1 * num2;
    }

    // method11 that takes a two-dimensional array of integers and returns the average of the entries.
    public static double Find2DAverage(int[,] arr)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
                count++;
            }
        }

        return sum / count;
    }

    public static void Main()
    {
        // Millimeters to meters
        ShowMeters(645);

        // Two ints and displays Sum
        ShowSum(15, 25);

        // Five Doubles and Returns an Average
        Console.WriteLine(Average(85.2, 94.3, 36.2, 52.0, 34.4));

        // Sum of two random ints
        Console.WriteLine(RandomSum());

        // Is sum of 3 divisible by 3
        Console.WriteLine(IsDivisibleBy3(11, 11, 11));

        // Find shortest string
        FindSmallestString("shrtstrng", "longstring");

        // Find largest double
        int[] arr = { 11, 313, 54, 99, 9999 };
        Console.WriteLine(FindMaxElement(arr));

        // Generate an array of fifty integers.
        int[] newArray = FindArray();
        foreach (var item in newArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // True if identical values
        Console.WriteLine(CheckBools(false, false));

        // Multiply an int times a double
        Console.WriteLine(FindMult(12, 19.5));

        // Average a 2D array.
        int[,] arr2D = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
        Console.WriteLine(Find2DAverage(arr2D));
    }
}