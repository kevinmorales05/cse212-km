using System.Runtime.InteropServices;

public static class ArrayClass
{

    public static void Run()
    {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',',  RotateListRight(numbers, 1))}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', RotateListRight(numbers, 5))}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', RotateListRight(numbers, 3))}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', RotateListRight(numbers, 9))}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
  
    private static double[] MultiplesOf(double number, int length)
    {
        double[] multiplesArray = [];
        int counter = 0;
        double start = 0;
        //1. Define if the number is positive or negative
        if (number < 0)
        {
            start = number;
        }
        //2. Start the loop to evaluate all of the numbers to 
        while (counter < length)
        {
            //3. omit the number 0
            if (start % number == 0)
            {
                if (start != 0)
                {
                    //4. Increse the counter because we just want the determined quantity of multiples
                    counter++;
                    //5. Create a new array with one more space
                    double[] newArray = new double[multiplesArray.Length + 1];
                    //6. Copy the array
                    Array.Copy(multiplesArray, newArray, multiplesArray.Length);
                    //7. Add the new element to the array
                    newArray[multiplesArray.Length] = start;
                    //8. Update the array
                    multiplesArray = newArray;
                }
            }
            if (number < 0)
            {
                //9. If the number is negative decrease 0.5
                start = start - 0.5;
            }
            else
            {
                //10. If the number is positive increase 0.5
                start = start + 0.5;
            }

        }

        //11. Return the new array
        return multiplesArray; // replace this return statement with your own
    }

    private static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //1. Get the index of the first element to move
        int indexOfTheFirstElement = data.Count - amount;
        //2. Create new list
        List<int> newList = new List<int>();
        //3. Add the last elements to the begginning of the list
        for (int i = indexOfTheFirstElement; i < data.Count; i++)
        {
            newList.Add(data[i]);
        }
        //4. Add the other elements to the list
        for (int j = 0; j < indexOfTheFirstElement; j++)
        {
            newList.Add(data[j]);
        }
        //5. Return the list
        return newList;
    }


}