namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt listInt = new ListInt();
            listInt.Add(2);
            listInt.Add(2);
            listInt.Add(3);
            listInt.All();
        }
    }
}