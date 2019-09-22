using System;
using System.Collections.Generic;
using System.Text;
using AMS.MiddleLayer.Database;
using AMS.MiddleLayer.DataTypes;

namespace AMS.MiddleLayer.Personna
{
    public class Teacher:Person
    {
        public double EligiblePercentage { get; set; }
        public Teacher(int id, string name, string email, string pass)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = pass;
        }

        public void MarkAttendance(Subject subject)
        {
            var studentList = subject.GetEnrolledStudents();
            foreach (var student in studentList.Keys)
            {
                studentList[student] += 1;
            }
            subject.TotalClassesTaken += 1;
        }

        public List<StudentAttendanceReport> ViewStudentAttendanceReport() {

            List<StudentAttendanceReport> studentAttendanceList = new List<StudentAttendanceReport>();
            foreach(var item in Databases.Students)
                studentAttendanceList.Add(new StudentAttendanceReport(item));
            return studentAttendanceList;
        }

        public void DeclareEligiblePercentage(double percentage) {
            EligiblePercentage = percentage;
        }

        public TeacherAttendanceReport ViewReport()
        {
            return new TeacherAttendanceReport(this);   
        }
    }
}
