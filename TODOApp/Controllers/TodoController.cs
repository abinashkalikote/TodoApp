using Microsoft.AspNetCore.Mvc;
using TODOApp.Data;
using TODOApp.Models;
using TODOApp.Services.Interfaces;

namespace TODOApp.Controllers
{
    public class TodoController : Controller
    {
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public ITodoService _todoService { get; }

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

            var data = Database.Todos;

            return RedirectToAction("Index");
        }
    }
}
