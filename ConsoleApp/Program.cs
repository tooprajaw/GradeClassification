using GradeIdentification;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(50.0);
            Print(60.0);
            Print(70.0);
            Print(80.0);
            Print(90.0);
            Print(100.0);
            Print(59.9999999d);
            Print(69.9999999d);
            Print(79.9999999d);
            Print(89.9999999d);
            Console.ReadLine();
        }

        static void Print(double point)
        {
            Grade grade = new Grade();
            Console.WriteLine($"number = {point}, grade = {grade.IdentifyGradeByPoint(point)}");
        }
    }
}