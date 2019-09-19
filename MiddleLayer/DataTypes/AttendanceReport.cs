using AMS.MiddleLayer.Personna;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.MiddleLayer
{
    public class AttendanceReport
    {
        public int NoOfClassesConducted { get; set; }
        public int NoOfClassesTaken { get; set; }
        public double AttendancePercentage { get; set; }

        public AttendanceReport(Student student)
        {
            
        }
    }
}
