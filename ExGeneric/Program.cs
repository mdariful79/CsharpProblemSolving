using ExGeneric;

ExBubbleSort<decimal> bubbleSort = new ExBubbleSort<decimal>();

var sortedNumbers = bubbleSort.Sort(new decimal[] {3.7m ,5.1m, 2.7m, 9.3m, 1m, 5m, 6m , 3.6m});

foreach(var number in sortedNumbers)
{
    Console.WriteLine(number);
}