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
    public class TeacherController : ControllerBase
    {
        private readonly Iservice _service;
        public TeacherController(Iservice service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Teacher> Get()
        {
            return _service.GetTeacherList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return _service.GetTeacherByid(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Teacher t)
        {
            _service.AddTeacher(t);
           

        }

       
    }
}