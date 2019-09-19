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

        public object ViewAttendanceReport()
        {
            return new NotImplementedException();
        }

        public object ViewEligibiityStatus()
        {
            return new NotImplementedException();
        }
    }
}
