using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        ToDoRepository repository = new ToDoRepository();

        // GET: api/<ToDoController>
        [HttpGet]
        public List<ToDoDto> Get()
        {
            return repository.GetAll();
        }

        // POST api/<ToDoController>
        [HttpPost]
        public int Post([FromBody] ToDoDto toDoDto)
        {
            return repository.Create(toDoDto);
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToDoDto toDoDto)
        {
            repository.Update(id, toDoDto);
        }
    }
}
