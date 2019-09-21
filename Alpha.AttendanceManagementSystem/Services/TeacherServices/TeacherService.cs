using Alpha.AttendanceManagementSystem.Services.DataTypes;
using AMS.MiddleLayer;
using AMS.MiddleLayer.Database;
using AMS.MiddleLayer.DataTypes;
using AMS.MiddleLayer.Personna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.AttendanceManagementSystem.Services.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        public List<Teacher_IdAndName> GetAllTeachers()
        {
            var teacher_IdAndName = new List<Teacher_IdAndName>();
            foreach(var teacher in Databases.Teachers)
            {
                teacher_IdAndName.Add(new Teacher_IdAndName() { id = teacher.Id, name = teacher.Name });
            }
            return teacher_IdAndName;
        }

        public List<StudentAttendanceReport> GetStudentReport()
        {
            return Databases.Teachers[0].ViewStudentAttendanceReport();
        }

        public List<Subject> GetSubjectsUnderTeacher(int teacherId)
        {
            var subjectListUnderTeacher = new List<Subject>();
            foreach (var subject in Databases.Subjects)
            {
                if (subject.Teacher.Id == teacherId)
                    subjectListUnderTeacher.Add(subject);
            }
            return subjectListUnderTeacher;
        }

        public Teacher GetTeacherById(int teacherId)
        {
            Teacher teacher = null;
            foreach (var t in Databases.Teachers)
            {
                if (t.Id == teacherId)
                {
                    teacher = t;
                    break;
                }
            }
            return teacher;
        }

        public TeacherAttendanceReport GetTeacherReportById(int teacherId)
        {
            var teacher = Databases.Teachers.Where((t) => t.Id == teacherId).ToList<Teacher>();
            return new TeacherAttendanceReport(teacher[0]);
        }

        public void MarkAttendance(string subjectId)
        {
            Subject subject = Databases.Subjects.Find(sub => sub.Id == subjectId);
            Teacher teacher = subject.Teacher;
            teacher.MarkAttendance(subject);
        }

        public void SetEligibilityPercentage(int teacherId, double value)
        {
            Teacher teacher = Databases.Teachers.Find(t => t.Id == teacherId);
            teacher.EligiblePercentage = value;
        }
    }
}
