﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeClassification
{
    public class Grade
    {
        public string ClassifyGradeByPoint(decimal point)
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
            if (point >= 90)
            {
                return "A";
            }
            return string.Empty;
        }

        public void ValidatePointInRange(decimal point)
        {
            if (point < 0 || point > 100)
            {
                throw new ArgumentOutOfRangeException("Point must be between 0 and 100.");
            }
        }
    }
}
