using TODOApp.Data;
using TODOApp.Models;
using TODOApp.Services.Interfaces;

namespace TODOApp.Services
{
    public class TodoService : ITodoService
    {
        public void Create(TodoDto dto)
        {
            dto.Id = Guid.NewGuid();
            Database.Todos.Add(dto);
        }
    }
}
