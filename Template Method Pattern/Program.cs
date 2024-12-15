using Template_Method_Pattern;

var ReportStudent = new StudentReportGenerator();
var ReportCourse = new CourseReportGenerator();


ReportStudent.GenerateReport();
ReportCourse.GenerateReport();