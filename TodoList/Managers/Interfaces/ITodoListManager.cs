using TodoList.Models;

namespace TodoList.Managers.Interfaces
{
    public interface ITodoListManager
    {
        public IEnumerable<TodoEntry> GetAll();
        public TodoEntry Get(int id);
        public void Add(TodoEntry data);
        public void Update(TodoEntry data);
        public void Delete(int id);
    }
}
