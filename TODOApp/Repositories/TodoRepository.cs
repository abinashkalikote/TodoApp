using TODOApp.Data;
using TODOApp.Models;
using TODOApp.Repositories.Interfaces;

namespace TODOApp.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public List<TodoDto> GetAll()
        {
            var todos = Database.Todos.ToList();
            return todos;
        }
    }
}
