using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GradeIdentification.Test")]
namespace GradeIdentification
{
    public class Grade
    {
        public string IdentifyGradeByPoint(double point)
        {
            ValidatePointInRange(point);
            if (point >= 0 && point < 60)
            {
                return "F";
            }
            if (point >= 60 && point < 70)
            {
                return "D";
            }
            if (point >= 70 && point < 80)
            {
                return "C";
            }
            if (point >= 80 && point < 90)
            {
                return "B";
            }
            return "A";
        }

        internal void ValidatePointInRange(double point)
        {
            if (point < 0 || point > 100)
            {
                throw new ArgumentOutOfRangeException("Point must be between 0 and 100.");
            }
        }
    }
}