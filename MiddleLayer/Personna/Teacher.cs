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

        public void MarkAttendance() {

        }

        public object ViewStudentAttendanceReport() {
            return new NotImplementedException();
        }

        public void DeclareEligiblePercentage(double percentage) {
            EligiblePercentage = percentage;
        }
    }
}
