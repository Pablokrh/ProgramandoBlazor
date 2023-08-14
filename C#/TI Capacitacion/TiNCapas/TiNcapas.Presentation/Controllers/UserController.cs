using Microsoft.AspNetCore.Mvc;
using TiNcapas.Entities;
using TiNcapas.Presentation.ViewModels;
using TiNCapas.Bussiness;

namespace TiNcapas.Presentation.Controllers
{
    public class UserController : Controller
    {
        UserService UserService;
        public UserController()
        {
            //de vuelta no llega nada por parámetro
            UserService= new UserService();
        }



        [HttpGet]
        public IActionResult Create()
        {
            var UserViewModel=new UserViewModel();
            return View(UserViewModel);
        }

        [HttpPost]
        public IActionResult Create(UserViewModel userViewModel)
        { 
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Email = userViewModel.Email,
                    FirstName = userViewModel.FirstName,
                    LastName = userViewModel.LastName,
                    Password = userViewModel.Password
                };
                UserService.CreateUser(user);
            }

            return View(userViewModel);
        }
    }
}
