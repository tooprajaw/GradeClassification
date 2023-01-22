using Xunit.Abstractions;

namespace GradeIdentification
{
    public class BaseTest
    {
        public readonly ITestOutputHelper _output;
        public BaseTest(ITestOutputHelper output)
        {
            _output = output;
        }
    }
}
