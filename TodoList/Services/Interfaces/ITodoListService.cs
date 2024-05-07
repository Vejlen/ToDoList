using TodoList.Models;
using TodoList.Models.Dto;

namespace TodoList.Services.Interfaces
{
    public interface ITodoListService
    {
        public IEnumerable<TodoEntry> GetTodoList();
        public TodoEntry GetTodoEntry(int id);
        public void AddEntry(TodoEntryDto entry);
        public void UpdateEntry(TodoEntryDto entry);
        public void DeleteEntry(int id);
    }
}
