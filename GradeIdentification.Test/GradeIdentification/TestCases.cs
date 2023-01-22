using Xunit.Abstractions;

namespace GradeIdentification
{
    public class TestCases : BaseTest
    {
        private Grade _grade;
        public TestCases(ITestOutputHelper output) : base(output)
        {
            _grade = new Grade();
        }
        [Theory]
        [MemberData(nameof(TestData.ShouldThrowException), MemberType = typeof(TestData))]
        public void PointOutOfScope_ShouldThrowException(double point)
        {
            Action act = () => _grade.ValidatePointInRange(point);
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
        [Theory]
        [MemberData(nameof(TestData.ShouldBeF), MemberType = typeof(TestData))]
        public void PointLessThanSixty_ShouldBeF(double point)
        {
            string result = _grade.IdentifyGradeByPoint(point);
            result.Should().Be("F");
        }
        [Theory]
        [MemberData(nameof(TestData.ShouldBeD), MemberType = typeof(TestData))]
        public void PointLessThanSeventy_ShouldBeD(double point)
        {
            string result = _grade.IdentifyGradeByPoint(point);
            result.Should().Be("D");
        }
        [Theory]
        [MemberData(nameof(TestData.ShouldBeC), MemberType = typeof(TestData))]
        public void PointLessThanEighty_ShouldBeC(double point)
        {
            string result = _grade.IdentifyGradeByPoint(point);
            result.Should().Be("C");
        }
        [Theory]
        [MemberData(nameof(TestData.ShouldBeB), MemberType = typeof(TestData))]
        public void PointLessThanNinety_ShouldBeB(double point)
        {
            string result = _grade.IdentifyGradeByPoint(point);
            result.Should().Be("B");
        }
        [Theory]
        [MemberData(nameof(TestData.ShouldBeA), MemberType = typeof(TestData))]
        public void PointMoreThanOrEqualNinety_ShouldBeA(double point)
        {
            string result = _grade.IdentifyGradeByPoint(point);
            result.Should().Be("A");
        }
    }
}
