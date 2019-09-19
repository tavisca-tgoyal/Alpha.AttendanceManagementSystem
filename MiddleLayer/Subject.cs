using AMS.MiddleLayer.Personna;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.MiddleLayer
{
    public class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public object GetEnrolledStudents()
        {
            return new NotImplementedException();
        }

    }
}
