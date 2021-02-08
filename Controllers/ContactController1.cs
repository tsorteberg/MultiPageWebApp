/***************************************************************
* Name        : ContactController.cs
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
using Microsoft.AspNetCore.Mvc;
using MultiPageWebApp.Models;

namespace ContactListSorteberg.Controllers
{
    public class ContactController : Controller
    {
        // Context class private attribute.
        private ContactContext context { get; set; }

        // Primary constructor.
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }

        // Add get action.
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Contact());
        }

        // Edit get action.
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        // Edit post action.
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                return View(contact);
            }
        }

        // Delete get action.
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        // Action method to post confirmation of object deletion.
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}