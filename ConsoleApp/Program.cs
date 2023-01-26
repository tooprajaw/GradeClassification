using GradeIdentification;
using GradeIdentification.Calculation;
using GradeIdentification.GradeRules;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print(50.0);
            //Print(60.0);
            //Print(70.0);
            //Print(80.0);
            //Print(90.0);
            //Print(100.0);
            //Print(59.9999999d);
            //Print(69.9999999d);
            //Print(79.9999999d);
            //Print(89.9999999d);

            GradeScope rules = new GradeScope
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

            rules.SetPointRangeAndScope(new List<GradeRange> {
                new GradeRange
                {
                    MinPoint = 0,
                    MaxPoint = 60,
                    Result = "F"
                },
                new GradeRange
                {
                    MinPoint = 60,
                    MaxPoint = 70,
                    Result = "D"
                },
                new GradeRange
                {
                    MinPoint = 70,
                    MaxPoint = 80,
                    Result = "C"
                },
                new GradeRange
                {
                    MinPoint = 70,
                    MaxPoint = 80,
                    Result = "B"
                },
                new GradeRange
                {
                    MinPoint = 80,
                    MaxPoint = 100,
                    Result = "A"
                },
            }, 0, 100);
            */
            Console.ReadLine();
        }

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
    }
}