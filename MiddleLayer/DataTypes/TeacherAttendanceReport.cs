using System;
using System.Collections.Generic;
using System.Text;
using AMS.MiddleLayer.Database;
using AMS.MiddleLayer.Personna;
using AMS.MiddleLayer;

namespace AMS.MiddleLayer.DataTypes
    
{
    public class TeacherAttendanceReport:IAttendanceReport
    {
        
        public TeacherAttendanceReport(Teacher teacher)
        {
            foreach(var subject in Databases.Subjects)
            {
                if(teacher.Id == subject.Teacher.Id)
                {
                    
                }
            }
        }
    }
}
