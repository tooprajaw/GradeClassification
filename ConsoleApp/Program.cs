using GradeIdentification;
using GradeIdentification.Calculation;
using GradeIdentification.Grading;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeScope scope = new GradeScope
            {
                MinPoint = 0,
                MaxPoint = 100,
                GradeRuleList = new List<GradeRule> {
                    new GradeRule
                    {
                        MinPoint = 0,
                        Result = "F"
                    },
                    new GradeRule
                    {
                        MinPoint = 50,
                        Result = "D"
                    },
                    new GradeRule
                    {
                        MinPoint = 60,
                        Result = "C"
                    },
                    new GradeRule
                    {
                        MinPoint = 70,
                        Result = "B"
                    },
                    new GradeRule
                    {
                        MinPoint = 80,
                        Result = "A"
                    },
                }
            };

            /*
            Print2(0, rules.IdentifyGradeByPoint(0));
            Print2(100, rules.IdentifyGradeByPoint(100));
            Print2(55, rules.IdentifyGradeByPoint(55));
            Print2(66, rules.IdentifyGradeByPoint(66));
            Print2(77, rules.IdentifyGradeByPoint(77));
            Print2(88, rules.IdentifyGradeByPoint(88));
            Print2(49.99999d, rules.IdentifyGradeByPoint(49.99999d));
            Print2(59.99999d, rules.IdentifyGradeByPoint(59.99999d));
            Print2(69.99999d, rules.IdentifyGradeByPoint(69.99999d));
            Print2(79.99999d, rules.IdentifyGradeByPoint(79.99999d));
            */
            GradeCalculation calculation = new GradeCalculation();
            Print(calculation, scope, 100);
            Print(calculation, scope, 49.99999d);
            Print(calculation, scope, 59.99999d);
            Print(calculation, scope, 69.99999d);
            Print(calculation, scope, 79.99999d);
            Console.ReadLine();
        }

        /*
        static void Print(double point)
        {
            Grade grade = new Grade();
            Console.WriteLine($"number = {point}, grade = {grade.IdentifyGradeByPoint(point)}");
        }

        static void Print2(double point, string result)
        {
            Grade grade = new Grade();
            Console.WriteLine($"number = {point}, grade = {result}");
        }
        */

        static void Print(GradeCalculation calculation, GradeScope scope, double point)
        {
            Console.WriteLine($"Point = {point}, grade = {calculation.IdentifyGradeByPoint(scope, point)}");
        }
    }
}