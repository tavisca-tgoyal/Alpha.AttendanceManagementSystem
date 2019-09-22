using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.AttendanceManagementSystem.Services;
using Alpha.AttendanceManagementSystem.Services.DataTypes;
using Alpha.AttendanceManagementSystem.Services.TeacherServices;
using AMS.MiddleLayer.DataTypes;
using AMS.MiddleLayer.Personna;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alpha.AttendanceManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _ITeacherService;
        public TeacherController(ITeacherService TeacherService)
        {
            _ITeacherService = TeacherService;
        }


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_ITeacherService.GetAllTeachers());
        }

        //api/teacher/id
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return _ITeacherService.GetTeacherById(id);
        }

        //api/teacher/id/report?teacher=true
        [HttpGet]
        public TeacherAttendanceReport Get(int teacherId, [FromQuery] bool teacher = true)
        {
            return _ITeacherService.GetTeacherReportById(teacherId);
        }

        
        //[HttpPost("{teacherId}/{subject}/{subjectId}/{takeattendance}")]
        //public void Post(int subjectId, int subjectId)
        //{
            
        //}
        
    }
}