using Microsoft.AspNetCore.Mvc;
using TODOApp.Data;
using TODOApp.Models;
using TODOApp.Repositories.Interfaces;
using TODOApp.Services.Interfaces;

namespace TODOApp.Controllers
{
    public class TodoController : Controller
    {
        public TodoController(
            ITodoService todoService,
            ITodoRepository todoRepository
            )
        {
            _todoService = todoService;
            _todoRepository = todoRepository;
        }

        public ITodoService _todoService { get; }
        public ITodoRepository _todoRepository { get; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TodoVm vm)
        {
            //TodoVm to TodoDto Mapping
            var dto = new TodoDto();
            dto.TaskTitle = vm.TaskTitle;
            dto.Description = vm.Description;

            //Call Create method of Todo Service
            _todoService.Create(dto);

            return RedirectToAction("Index");
        }

        public IActionResult GetTodos()
        {
            var todos = _todoRepository.GetAll();
            return View(todos);
        }
    }
}
