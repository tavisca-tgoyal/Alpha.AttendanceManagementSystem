using AMS.MiddleLayer.Database;
using AMS.MiddleLayer.Personna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.AttendanceManagementSystem.Services
{
    public class Service:Iservice
    {
       
        public void AddTeacher(Teacher t)
        {
            Databases.Teachers.Add(t);
        }
        public List<Teacher> GetTeacherList()
        {
            return Databases.Teachers;
        }
        public List<Student> FetchStudentList()
        {
            return Databases.Students;
        }

        public int GetAttendanceReport()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentList()
        {
            return Databases.Students;
        }

        public Student GetStudentByid(int id)
        {
            var _student = Databases.Students.Find(x => x.Id == id);
            if (_student != null)
            {
                return _student;
            }
            else
                return null;
        }

        public Teacher GetTeacherByid(int id)
        {
            var _teacher = Databases.Teachers.Find(x => x.Id == id);
            if (_teacher != null)
                return _teacher;
            else
                return null;
        }
    }
}
