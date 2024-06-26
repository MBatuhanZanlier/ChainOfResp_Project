using ChainOfResp_Project.ChainOfResponsibility;
using ChainOfResp_Project.DAL;
using ChainOfResp_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResp_Project.Controllers
{
    public class DefaultController : Controller
    { 
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employe treasurer = new Treasurey(_context); 
            Employe managerAssistant= new ManagerAsistant(_context); 
            Employe manager= new Manager(_context); 
            Employe areaDirector= new AreaDirector(_context); 
            treasurer.SetNextApprover(managerAssistant); 
            managerAssistant.SetNextApprover(manager); 
            manager.SetNextApprover(areaDirector);
            treasurer.ProcessRequest(model);  
            return View();
        }

    }
}
