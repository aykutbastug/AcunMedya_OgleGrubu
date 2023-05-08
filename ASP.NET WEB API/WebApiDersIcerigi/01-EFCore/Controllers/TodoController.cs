using _01_EFCore.Entities;
using _01_EFCore.Models;
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
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Todo>))]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<TodoResponse>))]
        public IActionResult List()
        {
            //return Ok(_db.Todos.ToList());


            //1.Map etme yöntemi
            //List<Todo> list = _db.Todos.ToList();
            //List<TodoResponse> result = new List<TodoResponse>();

            //foreach (Todo item in list)
            //{
            //    result.Add(new TodoResponse { 
            //        Id = item.Id,
            //        Description = item.Description,
            //        Header = item.Header,
            //        IsCompleted = item.IsCompleted
            //    });
            //}

            //return Ok(result);


            //2.Yöntem
            List<TodoResponse> result = _db.Todos.Select(t => new TodoResponse
            {
                Description = t.Description,
                Header = t.Header,
                Id = t.Id,
                IsCompleted = t.IsCompleted
            }).ToList();

            return Ok(result);


            //AUTOMAPPER araştırılacak

        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TodoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult Create([FromBody] TodoCreateModel model)
        {
            //if (ModelState.IsValid)
            //{
            Todo todo = new Todo
            {
                Description = model.Description,
                Header = model.Header,
                IsCompleted = false
            };

            _db.Todos.Add(todo);
            int affectedRows = _db.SaveChanges();
            if (affectedRows > 0)
            {
                TodoResponse result = new TodoResponse
                {
                    Id = todo.Id,
                    Description = todo.Description,
                    Header = todo.Header,
                    IsCompleted = todo.IsCompleted
                };

                return Created(string.Empty, result);
            }
            else
            {
                return BadRequest("Kayıt yapılamadı");
            }
            //}
            //else
            //{
            //    return BadRequest(ModelState);
            //}

        }



        [HttpPut("edit/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TodoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
        public IActionResult Update([FromRoute] int id, [FromBody] TodoUpdateModel model)
        {
            Todo todo = _db.Todos.Find(id);

            if (todo == null)
                return NotFound("Kayıt bulunamadı");


            todo.Description = model.Description;
            todo.Header = model.Header;
            todo.IsCompleted = model.IsCompleted;

            int affectedRows = _db.SaveChanges();
            if (affectedRows > 0)
            {
                TodoResponse result = new TodoResponse
                {
                    Id = todo.Id,
                    Description = todo.Description,
                    Header = todo.Header,
                    IsCompleted = todo.IsCompleted
                };

                return Ok(result);
            }
            else
            {
                return BadRequest("Güncelleme yapılamadı");
            }
        }


        [HttpGet("getbyid/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TodoResponse))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
        public IActionResult GetById([FromRoute] int id)
        {
            Todo todo = _db.Todos.Find(id);

            if (todo == null)
                return NotFound("Kayıt bulunamadı.");


            TodoResponse response = new TodoResponse
            {
                Id = todo.Id,
                Description = todo.Description,
                Header = todo.Header,
                IsCompleted = todo.IsCompleted
            };

            return Ok(response);
        }


        [HttpPatch("change-state/{id}/{isCompleted}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TodoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
        public IActionResult UpdateIsCompleted([FromRoute] int id, [FromRoute] bool isCompleted)
        {
            Todo todo = _db.Todos.Find(id);

            if (todo == null)
                return NotFound("Kayıt bulunamadı.");

            todo.IsCompleted = isCompleted;
            int affectedRows = _db.SaveChanges();
            if (affectedRows > 0)
            {
                TodoResponse todoResponse = new TodoResponse
                {
                    Description = todo.Description,
                    Header = todo.Header,
                    IsCompleted = todo.IsCompleted,
                    Id = id
                };

                return Ok(todoResponse);
            }
            else
                return BadRequest("Kayıt güncellenemedi.");

        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
        public IActionResult Delete([FromRoute] int id)
        {
            Todo todo = _db.Todos.Find(id);

            if (todo == null)
                return NotFound("Kayıt bulunamadı.");

            _db.Todos.Remove(todo);
            int affectedRows = _db.SaveChanges();
            if (affectedRows > 0)
                return Ok("Kayıt Silindi.");
            else
                return BadRequest("Kayıt silinemedi.");
        }


        [HttpDelete("delete-all")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(string))]
        public IActionResult DeleteAll()
        {
            List<Todo> todos = _db.Todos.ToList();

            if (todos == null)
                return NotFound("Kayıt bulunamadı.");

            foreach (var item in todos)
            {
                _db.Todos.Remove(item); 
            }
            int affectedRows = _db.SaveChanges();
            if (affectedRows > 0)
                return Ok("Kayıtlar Silindi.");
            else
                return BadRequest("Kayıtlar silinemedi.");
        }
    }
}
