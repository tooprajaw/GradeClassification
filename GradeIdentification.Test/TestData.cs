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
                decimal point;
                point = 100.00001m;
                yield return new object[] { point };
                point = 101m;
                yield return new object[] { point };
                point = -0.000001m;
                yield return new object[] { point };
                point = -1m;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeF
        {
            get
            {
                decimal point;
                point = 0m;
                yield return new object[] { point };
                point = 0.00001m;
                yield return new object[] { point };
                point = 59.99999999m;
                yield return new object[] { point };
                point = 59m;
                yield return new object[] { point };
                point = 30m;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeD
        {
            get
            {
                decimal point;
                point = 60m;
                yield return new object[] { point };
                point = 60.00001m;
                yield return new object[] { point };
                point = 69.99999999m;
                yield return new object[] { point };
                point = 69m;
                yield return new object[] { point };
                point = 65m;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeC
        {
            get
            {
                decimal point;
                point = 70m;
                yield return new object[] { point };
                point = 70.00001m;
                yield return new object[] { point };
                point = 79.99999999m;
                yield return new object[] { point };
                point = 79m;
                yield return new object[] { point };
                point = 75m;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeB
        {
            get
            {
                decimal point;
                point = 80m;
                yield return new object[] { point };
                point = 80.00001m;
                yield return new object[] { point };
                point = 89.99999999m;
                yield return new object[] { point };
                point = 89m;
                yield return new object[] { point };
                point = 85m;
                yield return new object[] { point };
            }
        }
        public static IEnumerable<object[]> ShouldBeA
        {
            get
            {
                decimal point;
                point = 90m;
                yield return new object[] { point };
                point = 90.00001m;
                yield return new object[] { point };
                point = 99.99999999m;
                yield return new object[] { point };
                point = 99m;
                yield return new object[] { point };
                point = 95m;
                yield return new object[] { point };
                point = 100m;
                yield return new object[] { point };
            }
        }
    }
}
