using System.Collections.Generic;

namespace GradeIdentification.Calculation
{
    public class GradeScope
    {
        public GradeScope()
        {
            GradeRuleList = new List<GradeRule>();
        }
        public double MinPoint { get; set; }
        public double MaxPoint { get; set; }
        public List<GradeRule> GradeRuleList { get; set; }
    }
}
