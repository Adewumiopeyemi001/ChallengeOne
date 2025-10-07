namespace ChallengeOne
{
    public class StudentScore
    {
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int Score { get; set; }

    }
    public class Student
    {
        public string Name { get; set; }
        public string MatricNumber { get; set; }
    }
    public enum GradeUnit
    {
        A = 5,
        B = 4,
        C = 3,
        D = 2,
        E = 1,
        F = 0
    }
    public enum Remark
    {
        Excellent,
        VeryGood,
        Good,
        Fair,
        Pass,
        Fail

    }
  
    public static class ProcessingStudentScores
    {
        private static GradeUnit GetGrade(int score)
        {
            if (score >= 70)
                return GradeUnit.A;
            else if (score >= 60)
                return GradeUnit.B;
            else if (score >= 50)
                return GradeUnit.C;
            else if (score >= 45)
                return GradeUnit.D;
            else if (score >= 40)
                return GradeUnit.E;
            else
                return GradeUnit.F;
        }
        // Method to assign student score to a remark
        private static Remark GetRemark(int score)
        {
            if (score >= 70)
                return Remark.Excellent;
            else if (score >= 60)
                return Remark.VeryGood;
            else if (score >= 50)
                return Remark.Good;
            else if (score >= 45)
                return Remark.Fair;
            else if (score >= 40)
                return Remark.Pass;
            else
                return Remark.Fail;
        }

        private static int CalculateWeightPoint(int courseUnit, int score)
        {
            var gradePoint = GetGrade(score);
            var gradePointName = GetGrade(score).GetType().Name;
            var gradePointName0 = GetGrade(score).GetType().Attributes;
            var gradePointName1 = GetGrade(score).ToString();
            var gradePointName2 = GetGrade(score).GetHashCode();
            var gradePointName3 = GetGrade(score).GetTypeCode();

            var weightPoint = (int)gradePoint * courseUnit;
            return weightPoint;
        }
     
        private static int CalculateTotalWeightPoint(List<StudentScore> courses)
        {
            int totalWeightPoint = 0;

            foreach (var item in courses)
            {
                totalWeightPoint += CalculateWeightPoint(item.CourseUnit, item.Score);
            }
            return totalWeightPoint;
        }

        private static int CalculateTotalUnit(List<StudentScore> scores)
        {
            var totalGradeUnit = 0;

            foreach (var item in scores)
            {
                totalGradeUnit += item.CourseUnit;
            }
            return totalGradeUnit;
        }

        private static double CalculateGPA(List<StudentScore> scores)
        {
            int totalWeightPoint = CalculateTotalWeightPoint(scores);
            int totalUnitPoint = CalculateTotalUnit(scores);

            if (totalUnitPoint == 0) return 0.0;
            return totalWeightPoint / totalUnitPoint;
        }

        public static string DisplayCourse(StudentScore course)
        {
            var grade = GetGrade(course.Score);
            var remark = GetRemark(course.Score);
            var weightPoint = CalculateWeightPoint(course.CourseUnit, course.Score);

            return $"Course: {course.CourseCode}, Unit: {course.CourseUnit}, " +
                   $"Score: {course.Score}, Grade: {grade}, Weight Point: {weightPoint}, Remark: {remark}";
        }

        public static string DisplayResult(List<StudentScore> scores)
        {
            var gpa = CalculateGPA(scores);
            var message = $"Your gpa is : {gpa}";
            return message;
        }

    }
}
