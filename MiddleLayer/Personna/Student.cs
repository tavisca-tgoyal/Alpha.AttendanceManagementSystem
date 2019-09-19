using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.MiddleLayer.Personna
{
    public class Student : Person
    {
        public Student(int id, string name, string email, string pass)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = pass;
        }

        public AttendanceReport ViewAttendanceReport()
        {
            return new AttendanceReport(this);
        }

        public object ViewEligibiityStatus()
        {
            return new NotImplementedException();
        }
    }
}
