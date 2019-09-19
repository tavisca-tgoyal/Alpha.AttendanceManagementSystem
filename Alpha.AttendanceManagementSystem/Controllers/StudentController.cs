using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.AttendanceManagementSystem.Services;
using AMS.MiddleLayer.Personna;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alpha.AttendanceManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        
           private readonly Iservice _service;
            public StudentController(Iservice service)
            {
                _service = service;
            }

            // GET api/Student
            [HttpGet]
            public List<Student> Get()
            {
                return _service.GetStudentList();
            }

            // GET api/Student/5
            [HttpGet("{id}")]
            public Student Get(int id)
            {
                return _service.GetStudentByid(id);
            }

          
            

            

         
    }
}