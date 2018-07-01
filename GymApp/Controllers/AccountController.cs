using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Login()
        {
            return View(new User());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View(new NewUser());
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(NewUser user, UserManager<User> _userManager)
        {
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(user);
            }
            return View();
        }
    }
}