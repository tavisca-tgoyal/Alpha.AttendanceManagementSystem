using AMS.MiddleLayer.Personna;
using AMS.MiddleLayer.Database;
using System;
using System.Collections.Generic;
using System.Text;
using AMS.MiddleLayer.DataTypes;


namespace AMS.MiddleLayer
{
    public class StudentAttendanceReport : IAttendanceReport
    {
        public int NoOfClassesAttended = 0;

        public StudentAttendanceReport(Student student)
        {
            foreach (var subject in Databases.Subjects)
            {
                var dictOfAttendence = subject.GetEnrolledStudents();
                if(dictOfAttendence.ContainsKey(student.Id))
                {
                    NoOfClassesAttended += dictOfAttendence[student.Id];
                    NoOfClassesTaken += subject.TotalAttendance;
                }
            }
            AttendancePercentage = (Double)decimal.Divide(NoOfClassesAttended, NoOfClassesTaken);
        }
    }
}
