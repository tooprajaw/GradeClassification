﻿using GradeIdentification.Calculation;
using GradeIdentification.DTO.Input.Grade;
using GradeIdentification.DTO.Output.Grade;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeIdentification.Grading
{
    public class GradeCalculation
    {
        //private GradeScope _scope;

        public GradeCalculation()
        {
        }

        //public GradeCalculation(GradeScope scope)
        //{
        //    _scope = scope ?? throw new ArgumentNullException(nameof(scope));
        //}

        public string IdentifyGradeByPoint(GradeScope scope, double point)
        {
            ValidateScope(scope);
            if (!IsPointValid(scope, point))
            {
                throw new Exception("Point must be in range.");
            }

            var result = scope.GradeRuleList.OrderBy(e => e.MinPoint).LastOrDefault(e => e.MinPoint <= point);
            return result?.Result ?? throw new Exception("Cannot identify grade.");
        }

        public List<StudentWithGrade> IdentifyGradeForStudentList(List<StudentWithPoint> studentList, GradeScope scope)
        {
            if (!studentList?.Any() ?? false)
            {
                throw new ArgumentNullException(nameof(studentList));
            }
            return studentList.Select(e => new StudentWithGrade
            {
                StudentId = e.StudentId,
                Result = IdentifyGradeByPoint(scope, e.Point)
            }).ToList();
        }

        internal void ValidateScope(GradeScope scope)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (scope.MinPoint == scope.MaxPoint)
            {
                throw new Exception("Minimum point must be less than maximum point.");
            }
            //if (scope.GradeRuleList == null || !scope.GradeRuleList.Any())
            //{
            //    throw new Exception("Please specify");
            //}
            if (!scope.GradeRuleList?.Any() ?? false)
            {
                throw new Exception("Please specify grade rule");
            }
            if (scope.GradeRuleList.Any(e => e.MinPoint < scope.MinPoint || e.MinPoint > scope.MaxPoint))
            {
                throw new Exception("Minimum point for grade rule must be in range of possible minimum point and pobsible maximum point.");
            }
        }

        internal bool IsPointValid(GradeScope scope, double point) => point >= scope.MinPoint && point <= scope.MaxPoint;
    }
}
