using AMS.MiddleLayer.Personna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.AttendanceManagementSystem.Services
{
    public interface Iservice
    {
        List<Student> GetStudentList();
        List<Teacher> GetTeacherList();
        Student GetStudentByid(int id);
        Teacher GetTeacherByid(int id);
        
        int GetAttendanceReport();
        void AddTeacher(Teacher t);
    }
}
