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
            var list = Databases.Subjects.Where(s => s.Teacher.Id == teacherId).ToList<Subject>();
            return list;
        }

        public Subject GetSubjectUnderTeacher(int teacherId, string subjectId)
        {
            Subject subject = null;
            var list = Databases.Subjects.Where(s => s.Teacher.Id == teacherId).ToList<Subject>();
            foreach(var sub in list)
            {
                if (sub.Id == subjectId)
                    subject = sub;
            }
            return subject;
        }

        public Teacher_IdAndName GetTeacherById(int teacherId)
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
            return new Teacher_IdAndName() { id = teacher.Id, name = teacher.Name };
        }

        public TeacherAttendanceReport GetTeacherReportById(int teacherId)
        {
            Teacher teacher = Databases.Teachers.Find(t => t.Id == teacherId);
            return teacher.ViewReport();
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
