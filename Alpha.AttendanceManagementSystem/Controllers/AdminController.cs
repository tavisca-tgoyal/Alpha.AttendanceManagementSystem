using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.AttendanceManagementSystem.Services;
using AMS.MiddleLayer.Database;
using AMS.MiddleLayer.Personna;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alpha.AttendanceManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
            private readonly Iservice _services;
            public AdminController(Iservice services)
            {
                _services = services;
            }
            [HttpGet()]
            public Iservice Get()
            {
            return _services;
         }
          
            // GET api/values
            [HttpGet("students")]
            public List<Student> Getstudents()
            {
                return _services.GetStudentList();
            }

            // GET api/values/5
            [HttpGet("students/{id}")]
            public Student GetStudentsbyid(int id)
            {
                return _services.GetStudentByid(id);
            }

            // POST api/values
            [HttpPost("students/}")]
            public void Post([FromBody] Student t)
            {

            var present = Databases.Students.Find(X => X.Id == t.Id);
            if (present == null)
            {
                Databases.Students.Add(t);
            }
            else
                return;
            }

            // PUT api/values/5
            [HttpPut("students/ {id}")]
            public void Put(int id, [FromBody] Student student)
            {
            var present = Databases.Students.Find(X => X.Id == id);
            if (present != null)
            {
                int ind = Databases.Students.FindIndex(X => X.Id == student.Id);
                Databases.Students.RemoveAt(ind);
                Databases.Students.Add(student);
            }
            else
                Databases.Students.Add(student);

            }
        
            // DELETE api/values/5
            [HttpDelete("students/{id}")]
            public void Delete(int id)
            {
            var present = Databases.Students.Find(X => X.Id == id);
            if (present == null)
            {
                int ind = Databases.Students.FindIndex(x => x.Id == id);
                Databases.Students.RemoveAt(ind);
            }
            else
                return;
            }
        
    } 
}