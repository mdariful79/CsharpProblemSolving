using System.Linq;

// Data source (in-memory collection)
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

// LINQ Method Syntax: filter and sort numbers greater than 3
var result = numbers.Where(n => n > 3).OrderBy(n => n);

// Query execution
foreach (var number in result)
{
    Console.WriteLine(number);
}
Console.WriteLine("Second Execution");
int[] nums = { 1, 2, 3, 4, 5 };
var res = nums.Where(m => m%2==1).OrderByDescending(m => m);
foreach (var num in res)
{
    Console.WriteLine(num);
}
