using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.AttendanceManagementSystem.Services;
using Alpha.AttendanceManagementSystem.Services.DataTypes;
using Alpha.AttendanceManagementSystem.Services.TeacherServices;
using AMS.MiddleLayer;
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

        //api/teacher
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_ITeacherService.GetAllTeachers());
        }

        //api/teacher/id
        [HttpGet("{id}")]
        public Teacher_IdAndName Get(int id)
        {
            return _ITeacherService.GetTeacherById(id);
        }

        //api/teacher/id/report?teacher=true&student=false ///doesn't seems like working as expected
        [HttpGet]
        [Route("{teacherId}/report")]
        public ActionResult Get(int teacherId, [FromQuery] bool teacher = true, [FromQuery] bool student = false)
        {
            if (teacher == true)
                return Ok(_ITeacherService.GetTeacherReportById(teacherId));
            else
                return Ok(_ITeacherService.GetStudentReport());
        }


        //printing all the subjects under a particular teacher
        //api/teacher/id/subject
        [HttpGet]
        [Route("{teacherId}/subject")]
        public ActionResult Get(int teacherId,int var)
        {
            return Ok(_ITeacherService.GetSubjectsUnderTeacher(teacherId));
        }

        //printing  the subject under a particular teacher by subject id
        //api/teacher/id/subject/id
        [HttpGet]
        [Route("{teacherId}/subject/{subjectId}")]
        public ActionResult Get(int teacherId,string subjectId)
        {
            return Ok(_ITeacherService.GetSubjectUnderTeacher(teacherId,subjectId));
        }

        //api/teacher/id/subject/id/takeattendance
        [HttpPost]
        [Route("{teacherId}/subject/{subjectId}/takeattendance")]
        public void Post(int teacherId,string subjectId)
        {
           _ITeacherService.MarkAttendance(subjectId);
        }


    }
}