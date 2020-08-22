﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceSite.Data;
using eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace eCommerceSite.Controllers
{
    public class UserController : Controller
    {

        private readonly ProductContext _context;

        public UserController(ProductContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel reg)
        {
            if(ModelState.IsValid)
            {
                // Map data to user account instance
                UserAccount acc = new UserAccount()
                {
                    DateOfBirth = reg.DateOfBirth,
                    Email = reg.Email,
                    password = reg.Password,
                    Username = reg.Username
                };
                // add to database
                _context.UserAccounts.Add(acc);
                await _context.SaveChangesAsync();
                // redirect to home page
                return RedirectToAction("Index", "Home");
            }

            return View(reg);
        }
    }
}