using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeIdentification
{
    public class TestData
    {
        public static IEnumerable<object[]> ShouldThrowException
        {
            get
            {
                double point;
                point = 100.00001d;
                yield return new object[] { point };
                point = 101;
                yield return new object[] { point };
                point = -0.000001d;
                yield return new object[] { point };
                point = -1;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeF
        {
            get
            {
                double point;
                point = 0;
                yield return new object[] { point };
                point = 0.00001d;
                yield return new object[] { point };
                point = 59.99999999d;
                yield return new object[] { point };
                point = 59;
                yield return new object[] { point };
                point = 30;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeD
        {
            get
            {
                double point;
                point = 60;
                yield return new object[] { point };
                point = 60.00001d;
                yield return new object[] { point };
                point = 69.99999999d;
                yield return new object[] { point };
                point = 69;
                yield return new object[] { point };
                point = 65;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeC
        {
            get
            {
                double point;
                point = 70;
                yield return new object[] { point };
                point = 70.00001d;
                yield return new object[] { point };
                point = 79.99999999d;
                yield return new object[] { point };
                point = 79;
                yield return new object[] { point };
                point = 75;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeB
        {
            get
            {
                double point;
                point = 80;
                yield return new object[] { point };
                point = 80.00001d;
                yield return new object[] { point };
                point = 89.99999999d;
                yield return new object[] { point };
                point = 89;
                yield return new object[] { point };
                point = 85;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeA
        {
            get
            {
                double point;
                point = 90;
                yield return new object[] { point };
                point = 90.00001d;
                yield return new object[] { point };
                point = 99.99999999d;
                yield return new object[] { point };
                point = 99;
                yield return new object[] { point };
                point = 95;
                yield return new object[] { point };
                point = 100;
                yield return new object[] { point };
            }
        }
    }
}
