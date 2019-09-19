using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.MiddleLayer.DataTypes
{
    public interface IAttendanceReport
    {
        int NoOfClassesTaken { get; set; }
        double AttendancePercentage { get; set; }
    }
}
