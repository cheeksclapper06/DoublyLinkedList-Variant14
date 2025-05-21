namespace DoubleLinkedList
{
    public class Program
    {
        public static void Main()
        {
            var testList = new DoublyLinkedListDouble();

            testList.AddElementToStart(20);
            testList.AddElementToStart(35);
            testList.AddElementToStart(40);
            testList.AddElementToStart(-85);
            testList.AddElementToStart(-100);
            testList.AddElementToStart(500);
            testList.AddElementToStart(28);
            testList.AddElementToStart(-28);

            DoublyLinkedListDouble.PrintList(testList, "Added elements to start");

            Console.WriteLine($"The first positive element = {testList.FindFirstPositiveElement()}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            var avg = testList.FindMeanValue();
            Console.WriteLine($"Average value = {avg}");

            var max = testList.FindMaxValue();
            Console.WriteLine($"Maximum value = {max}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Number of values bigger than the average = {testList.FindNumberElementsBiggerMeanValue()}");
            var valuesBiggerMeanValue = testList.GetElementsBiggerMeanValue();
            Console.WriteLine($"Values bigger than the average: {string.Join(", ", valuesBiggerMeanValue)}");

            testList.RemoveBeforeMaxValue();
            DoublyLinkedListDouble.PrintList(testList, "List after removing elements before max value");
        }
    }
}