using Microsoft.AspNetCore.Mvc;
using StudentControl.Infrastructure;
using StudentControl.Domain;
using StudentControl.Infrastructure.Repository;
using StudentControl.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentControl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Context context;
        private readonly StudentRepository studentRepository;

        public StudentController(Context context)
        {
            this.context = context;
            studentRepository = new StudentRepository(context);
        }
        //AutoMapper
        //DTO C#
        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await studentRepository.GetAllAsync();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
