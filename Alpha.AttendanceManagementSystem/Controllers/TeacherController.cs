using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.AttendanceManagementSystem.Services;
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
        public ActionResult Get()
        {
            return 
        }
    }
}