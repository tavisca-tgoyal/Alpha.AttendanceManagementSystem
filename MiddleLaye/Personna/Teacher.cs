using System;
using System.Collections.Generic;
using System.Text;

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
            subject.TotalAttendance += 1;
        }

        public object ViewStudentAttendanceReport() {
            return new NotImplementedException();
        }

        public void DeclareEligiblePercentage(double percentage) {
            EligiblePercentage = percentage;
        }

        public Teache ViewReport()
        {

        }
    }
}
