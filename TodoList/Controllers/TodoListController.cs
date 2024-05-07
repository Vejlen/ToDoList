using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.Models.Dto;
using TodoList.Services.Interfaces;

namespace TodoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoListController : Controller
    {
        private ITodoListService _todoListService;

        public TodoListController(ITodoListService todoListService)
        {
            this._todoListService = todoListService;
        }

        [HttpGet(Name = "GetTodoList")]
        public IEnumerable<TodoEntry> Get()
        {
            return this._todoListService.GetTodoList();
        }

        [HttpGet("{id}", Name = "GetTodoEntry")]
        public TodoEntry GetSingle(int id)
        {
            return _todoListService.GetTodoEntry(id);
        }

        [HttpPost(Name = "AddTodoEntry")]
        public void Add(TodoEntryDto entry)
        {
            this._todoListService.AddEntry(entry);
        }

        [HttpPut(Name = "UpdateTodoEntry")]
        public void Update(TodoEntryDto entry)
        {
            this._todoListService.UpdateEntry(entry);
        }

        [HttpDelete(Name = "DeleteTodoEntry")]
        public void Delete(int id)
        {
            this._todoListService.DeleteEntry(id);
        }
    }
}
