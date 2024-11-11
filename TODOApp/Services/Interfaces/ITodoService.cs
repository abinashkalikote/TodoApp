using TODOApp.Models;

namespace TODOApp.Services.Interfaces
{
    public interface ITodoService
    {
        void Create(TodoDto dto);
    }
}
