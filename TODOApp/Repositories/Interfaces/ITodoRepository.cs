using TODOApp.Models;

namespace TODOApp.Repositories.Interfaces
{
    public interface ITodoRepository
    {
        List<TodoDto> GetAll();
    }
}
