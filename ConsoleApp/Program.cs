using GradeIdentification;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(50.0m);
            Print(60.0m);
            Print(70.0m);
            Print(80.0m);
            Print(90.0m);
            Print(100.0m);
            Print(59.9999999m);
            Print(69.9999999m);
            Print(79.9999999m);
            Print(89.9999999m);
            Console.ReadLine();
        }

        static void Print(decimal point)
        {
            Grade grade = new Grade();
            Console.WriteLine($"number = {point}, grade = {grade.IdentifyGradeByPoint(point)}");
        }
    }
}