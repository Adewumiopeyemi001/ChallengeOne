// See https://aka.ms/new-console-template for more information
using ChallengeOne;
Console.WriteLine("Hello, World!");

bool moreCourses = true;
//string courseCode = "";
//int courseUnit = 0;
//int score = 0;


//var studentScores<List> = new
List<StudentScore> studentScoreList  = new List<StudentScore>(); 


while (moreCourses)
{

    Console.Write("Enter your course code: ");
    string courseCode = Console.ReadLine();

    Console.Write("Enter your course unit: ");
    int courseUnit = int.Parse(Console.ReadLine());

    Console.Write("Enter your course score: ");
    int score = int.Parse(Console.ReadLine());

    var studentScore = new StudentScore() { CourseCode = courseCode, CourseUnit = courseUnit, Score = score };
    studentScoreList.Add(studentScore);

    Console.Write("Do you have more courses to add? Enter Yes or No: ");
    string userResponse = Console.ReadLine();
    Console.Clear();
    if (userResponse == "No")
    {
        moreCourses = false;
        //return false;
    }
};

//int totalCourseUnitRegistered = 0;

//string courseNameAndUnit = "";

//foreach (var item in studentScoreList)
//{
//    var displayResult = ProcessingStudentScores.DisplayResult(studentScoreList);
//    totalCourseUnitRegistered += item.CourseUnit;
//    courseNameAndUnit += $"{item.CourseCode}={item.CourseUnit} unit.  ";
//    Console.WriteLine(displayResult);
//    //Console.WriteLine(ProcessingStudentScores.DisplayCourse(course));


//}

//Console.WriteLine(ProcessingStudentScores.DisplayResult(studentScoreList));





//int totalCourseRegistered = studentScoreList.Count();

foreach (var course in studentScoreList)
{
    Console.WriteLine(ProcessingStudentScores.DisplayCourse(course));
}

var displayResult = ProcessingStudentScores.DisplayResult(studentScoreList);
Console.WriteLine(displayResult);


//Console.WriteLine($"Total course resgistered = {totalCourseRegistered}.\n{courseNameAndUnit}.\nTotal unit registered = {totalCourseUnitRegistered}");
//Console.WriteLine(ProcessingStudentScores.DisplayFinalGPA(studentScoreList));


//int totalCourseUnitRegistered = 0;
//totalCourseUnitRegistered += studentScore.CourseUnit;
//var displayResult = ProcessingStudentScores.DisplayResult(studentScore.CourseUnit, studentScore.Score);

//Console.WriteLine(displayResult);
Console.ReadKey();



//var rec = new StudentRecords();
//var _ = rec.CalculateGrade(34);
