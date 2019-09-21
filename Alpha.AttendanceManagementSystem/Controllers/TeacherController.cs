using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.AttendanceManagementSystem.Services;
using Alpha.AttendanceManagementSystem.Services.DataTypes;
using Alpha.AttendanceManagementSystem.Services.TeacherServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alpha.AttendanceManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _ITeacherService ;
        public TeacherController(ITeacherService TeacherService)
        {
            _ITeacherService = TeacherService;
        }
        [HttpGet]
        public List<Teacher_IdAndName> Get()
        {
            return _ITeacherService.GetAllTeachers();
        }
    }
}