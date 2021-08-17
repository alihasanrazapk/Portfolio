using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(ContactForm contact)
        {
            if(ModelState.IsValid)
            {
                db.Add(contact);
                db.SaveChanges();
                return RedirectToAction(nameof(Results),contact);
            }
            return View();
        }

        public IActionResult Results()
        {
            return View();
        }
      
        IEnumerable<ContactForm> ShowList { get; set; }
        public  IActionResult ShowAll()
        {
             ShowList = db.Contacts.ToList();
            return View(ShowList);
        }
    }
}
