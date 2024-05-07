using TodoList.Managers.Interfaces;
using TodoList.Models;
using TodoList.Models.Dto;
using TodoList.Services.Interfaces;

namespace TodoList.Services
{
    public class TodoListService : ITodoListService
    {
        public readonly ITodoListManager todoListManager;
        public TodoListService(ITodoListManager todoListManager)
        {
            this.todoListManager = todoListManager;
        }

        public IEnumerable<TodoEntry> GetTodoList()
        {
            return this.todoListManager.GetAll();
        }

        public TodoEntry GetTodoEntry(int id)
        {
            return this.todoListManager.Get(id);
        }

        public void AddEntry(TodoEntryDto entry)
        {
            this.todoListManager.Add(new TodoEntry
            {
                Title = entry.Title,
                Description = entry.Description,
                ExpirationDate = entry.ExpirationDate
            });
        }

        public void UpdateEntry(TodoEntryDto entry)
        {
            this.todoListManager.Update(new TodoEntry
            {
                Title = entry.Title,
                Description = entry.Description,
                ExpirationDate = entry.ExpirationDate
            });
        }

        public void DeleteEntry(int id)
        {
            this.todoListManager.Delete(id);
        }
    }
}
