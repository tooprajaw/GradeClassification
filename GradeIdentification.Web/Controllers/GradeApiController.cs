using GradeIdentification.Calculation;
using GradeIdentification.DTO.Input.Grade;
using GradeIdentification.GradeRules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradeIdentification.Web.Controllers
{
    [Route("api/grade")]
    [ApiController]
    public class GradeApiController : ControllerBase
    {
        [HttpPost]
        [Route("Calculate")]
        public IActionResult Calculate(List<StudentWithPoint> studentList)
        {
            GradeCalculation calculation = new GradeCalculation();
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

            return Ok(calculation.IdentifyGradeForStudentList(studentList, scope));
        }
    }
}
