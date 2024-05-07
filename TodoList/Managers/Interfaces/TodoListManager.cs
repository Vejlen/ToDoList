using TodoList.Models;

namespace TodoList.Managers.Interfaces
{
    public class TodoListManager : ITodoListManager
    {
        private readonly TodoListDbContext _contextFactory;
        public TodoListManager(TodoListDbContext contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public IEnumerable<TodoEntry> GetAll()
        {
            using (var context = _contextFactory)
            {
                return context.TodoList.ToList();
            }
        }

        public TodoEntry Get(int id)
        {
            using (var context = _contextFactory)
            {
                return context.TodoList.Find(id);
            }
        }

        public void Add(TodoEntry data)
        {
            using (var context = _contextFactory)
            {
                context.TodoList.Add(data);
                context.SaveChanges();
            }
        }

        public void Update(TodoEntry data)
        {
            using (var context = _contextFactory)
            {
                context.TodoList.Update(data);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = _contextFactory)
            {
                var entry = context.Find<TodoEntry>(id);
                context.TodoList.Remove(entry);
                context.SaveChanges();
            }
        }
    }
}
