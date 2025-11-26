namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack.MyStack(10);

            StringStack.Push("Wert 1");
            StringStack.Push("Wert 2");
            StringStack.Push("Wert 3");

            string value = StringStack.Pop();
            string anotherValue = StringStack.Peak();

            Console.WriteLine($"Value: {value} und another Value: {anotherValue}");
        }
    }
}
