// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

// // 1.
// static void PrintList(List<string> MyList)
// {
//     {
//         for (int i = 0; i < MyList.Count; i++)
//         {
//             Console.WriteLine(MyList[i]);
//         }
//     }
// }
// List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
// PrintList(TestStringList);


// // 2.
// static void SumOfNumbers(List<int> IntList)
//     {
//     // Your code here
//     var sum = 0;
//     foreach(var num in IntList)
//     {
//         sum += num;
//     }
//     Console.WriteLine(sum);
//     }
// List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// SumOfNumbers(TestIntList);

// 3.
static int FindMax(List<int> IntList)
{
    int largest = int.MinValue;
    foreach (int number in IntList)
    {
        if (number > largest)
        {
            largest = number;
        }
    }
    return largest;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);
int max = FindMax(TestIntList2); // Will Call the method and store the results
Console.WriteLine("The largest value is: " + max); // Print the results

// 4.
static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredList = new List<int>();
    foreach (int number in IntList)
    {
        squaredList.Add(number * number);
    }
    return squaredList; // Return the squared list Values
}

List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 }; // You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> squaredList = SquareValues(TestIntList3); // Will Call the method and store the results
Console.WriteLine("Squared values: " + string.Join(", ", squaredList)); // Print the results

//5.
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}

int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
int[] resultArray = NonNegatives(TestIntArray); // Will Call the method and store the results
Console.WriteLine("Non-negative values: " + string.Join(", ", resultArray)); // Print the results


//6.
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
}
{
    Dictionary<string, string> TestDict = new Dictionary<string, string>();
    TestDict.Add("HeroName", "Iron Man");
    TestDict.Add("RealName", "Tony Stark");
    TestDict.Add("Powers", "Money and intelligence");
    PrintDictionary(TestDict);
}


//7.

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}
{
    Dictionary<string, string> TestDict = new Dictionary<string, string>();
    TestDict.Add("HeroName", "Iron Man");
    TestDict.Add("RealName", "Tony Stark");
    TestDict.Add("Powers", "Money and intelligence");

    {
        // This should print true
        Console.WriteLine(FindKey(TestDict, "RealName"));
        // This should print false
        Console.WriteLine(FindKey(TestDict, "Name"));
    }
}

//8.

List<string> name = new List<string>() { "Julie", "Harold", "James", "Monica" };
List<int> number = new List<int>() { 6, 12, 7, 10 };
Dictionary<string, int> mydictionary = GenerateDictionary(name, number);
foreach (var entry in mydictionary)
{
    Console.WriteLine($"{entry.Key} and {entry.Value}");
}

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        dictionary[Names[i]] = Numbers[i];
    }
    return dictionary;
}
