using Microsoft.AspNetCore.Mvc;

namespace TarefaWeb.Controllers
{
    public class TarefaController: Controller
    {
        public IActionResult Index()
        {
            // retornar um .cshtml com o mesmo nome do método
            // return Views/Tarefa/Index.cshtml
            return View();
        }
    }
}