using _01_EFCore.Entities;
using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace _01_EFCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private TodoDbContext _db;

        public TodoController(TodoDbContext db)
        {
            _db = db;
        }


        [HttpGet("generate-fakedata")]
        public IActionResult GenereteFakeData()
        {
            if (_db.Todos.Any())
                return Ok("Geçici veriler zaten oluşturulmuş.");

            for (int i = 1; i < 21; i++)
            {
                _db.Todos.Add(new Todo
                {
                    Header = TextData.GetSentence(),
                    IsCompleted = BooleanData.GetBoolean(),
                    Description = TextData.GetSentences(2),
                });
            }

            _db.SaveChanges();
            return Ok("ok");
        }


        [HttpGet("list")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Todo>))]
        public IActionResult List()
        {
            return Ok(_db.Todos.ToList());
        }
    }
}
