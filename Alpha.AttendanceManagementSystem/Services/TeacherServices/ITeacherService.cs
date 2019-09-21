using System.Collections.Generic;
using Alpha.AttendanceManagementSystem.Services.DataTypes;
using AMS.MiddleLayer;
using AMS.MiddleLayer.DataTypes;
using AMS.MiddleLayer.Personna;

namespace Alpha.AttendanceManagementSystem.Services.TeacherServices
{
    public interface ITeacherService
    {
        List<Teacher_IdAndName> GetAllTeachers();

        Teacher GetTeacherById(int teacherId);

        TeacherAttendanceReport GetTeacherReportById(int teacherId);

        void MarkAttendance(string subjectId);

        List<Subject> GetSubjectsUnderTeacher(int teacherId);

        List<StudentAttendanceReport> GetStudentReport();

        void SetEligibilityPercentage(int teacherId, double value);
    }
}