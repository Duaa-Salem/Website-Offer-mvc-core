using duaaOffer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace duaaOffer.Controllers
{
    public class RegisterandLoginController : Controller
    {
        private readonly TestContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private UserManager<AspNetUsers> user;
        private SignInManager<AspNetUsers> sign;
        public RegisterandLoginController(TestContext _context, IWebHostEnvironment _hostEnvironment , UserManager<AspNetUsers> userM,
            SignInManager<AspNetUsers> sginM)
        {
            this._context = _context;
            this._hostEnvironment = _hostEnvironment;
            user = userM;
            sign = sginM;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(string username,string Fname, string Lname, string Phone, string Email, string Type, string PasswordHash)
        {
            try
            {
                ViewBag.Message = "User already registered";
                AspNetUsers users = await user.FindByNameAsync(username);
                if (users == null)
                {
                    users = new AspNetUsers();
                    users.UserName = username;
                    users.Fname = Fname;
                    users.Lname = Lname;
                    users.Email = Email;
                    users.Phone = Phone;
                    //users.PasswordHash = PasswordHash;
                    users.Type = Type;
                }
                IdentityResult result = await user.CreateAsync(users,PasswordHash);
                ViewBag.Message = "User was Created";
                return RedirectToAction("Index", "AspNetUsers");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View();
        }


        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> loginAsync(string userName, string PasswordHash)
        {
            const string id = "id";
           var result = await sign.PasswordSignInAsync(userName, PasswordHash, false, false);
            AspNetUsers userdata = await _context.AspNetUsers.Where(x => x.UserName == userName ).FirstOrDefaultAsync();

            if (result.Succeeded)
            {
                
                switch (userdata.Type)
                {
                    case "admin":
                        {
                            HttpContext.Session.SetInt32("id", Convert.ToInt32(userdata.Id));
                            return RedirectToAction("Index", "AspNetUsers");
                        }
                    case "user":
                        {
                            HttpContext.Session.SetInt32("id", Convert.ToInt32(userdata.Id));
                            return RedirectToAction("Create", "Offers");
                        }
                
                }
            }
            ViewBag.MSG = "Email or Password incorrect";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "HomePage");
        }
    }
}
