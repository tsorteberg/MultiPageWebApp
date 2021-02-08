/***************************************************************
* Name        : HomeController.cs
* Author      : Tom Sorteberg
* Created     : 02/07/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 2 Topic 3
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MultiPageWebApp.Models;

namespace MultiPageWebApp.Controllers
{
    public class HomeController : Controller
    {
        // Context class private attribute.
        private ContactContext context { get; set; }
        
        // Primary contructor.
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        // Index action.
        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
