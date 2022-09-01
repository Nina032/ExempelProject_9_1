using ExempelProject.Data;
using ExempelProject.Services;
using ExempelProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExempelProject.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService mailService;
        private readonly IExempelRepository repository;

        public AppController(IMailService mailService, IExempelRepository repository)
        {
            this.mailService = mailService;
            this.repository = repository;
        }
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                mailService.SendMessage("nina@kicanovic.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent!";
            }
            return View();
        }
        
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
        public IActionResult Shop()
        {
            var results = repository.GetAllProducts();

            return View(results);
        }
    }
}
