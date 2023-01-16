using DemoApplication.Database;
using DemoApplication.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Areas.Client.Controllers
{
    [Area("client")]
    [Route("card")]
    public class CardController : Controller

  

    {
        private readonly DataContext _dbContext;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public CardController(DataContext dataContext, IUserService userService, IEmailService emailService)
        {
            _dbContext = dataContext;
            _userService = userService;
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
