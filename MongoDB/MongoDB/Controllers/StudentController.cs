using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Repositories;
using MongoDB.Model;
using MongoDB.Bson;

namespace MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            var id = await _studentRepository.Create(student);
            return new JsonResult(id.ToString());
        }
        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var Student = await _studentRepository.Get(ObjectId.Parse(id));
            return new JsonResult(Student);
        }
        [HttpGet("getbyName/{Name}")]
        public async Task<IActionResult>GetByName(string Name)
        {
            var Student = await _studentRepository.GetByName(Name);
            return new JsonResult(Student);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Student student)
        {
            var Student = await _studentRepository.Update(ObjectId.Parse(id), student);
            return new JsonResult(Student);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Student = await _studentRepository.Delete(ObjectId.Parse(id));
            return new JsonResult(Student);
        }
        [HttpGet("Fetch")]
        public async Task<IActionResult> GetAll()
        {
            var Student = await _studentRepository.GetAll();
            return new JsonResult(Student);
        }
    }
}
