using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegDemo.Models;

namespace LoginRegDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        //this method should display the form for logging in or registering
        public IActionResult Index()
        {
            //update my Home/Index.cshtml file with login/reg forms
            //possible viewbag of errors?
            return View();
        }

        [HttpPost]
        //pick a route name
        //this method should accept the submitted form User object and add to database if submission is valid
        public IActionResult Register()
        {
            //check if submitted user is valid
            
            //check if entered email is already in the database
                //can I add custom errors to my model state?
            //if it does, render Index page with errors

            //if it is valid
            //save user in the database
            //redirect to a success page
            
            //if not valid, render the Index page with errors
                //could use ViewBag, or asp-validation-for (Model Binding)
        }

        [HttpPost]
        //pick a route name
        //this method should allow users to log in
        public IActionResult LogIn()
        {
            //this method should receive an email and password (or ViewModel??)
            
            //check if the email is in the database
            //if it is, check that the passwords match
            //if they do, redirect to success
            //if they don't, render Index page with errors
        }

        //should this method be in another controller?
        [HttpGet]
        //pick a route name
        public IActionResult Success()
        {
            //show a page
        }

    }
}
