using food4.Models;
using food4.Repository;
using food4.Repository.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace food4.Controllers
{
    public class HomeController : Controller
    {
        foodconDbContext db;
        private IWebHostEnvironment host;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, foodconDbContext context, IWebHostEnvironment _host)
        {
            _logger = logger;
            db = context;
            host = _host;
        }

        public IActionResult Index()
        {
            var result = db.Category.ToList();

            return View(result);
        }


        [HttpPost]
        public IActionResult SaveContact(string Name, string Email, string Message)
        {

            ContactUs result = new ContactUs();
            result.Name = Name;
            result.Email = Email;
            result.Message = Message;
            db.ContactUs.Add(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Reviews()
        {
            var result = db.ContactUs.ToList();
            return View(result);
        }
        public IActionResult Product(int id)
        {
            Category c = db.Category.Find(id);
            ViewBag.cat = c.Name;
            ViewBag.catid = c.Id;
            var result = db.Product.Where(x => x.CategoryId == id).ToList();
            return View(result);
        }
        public IActionResult AddOrder(int id)
        {
            
            Product p = db.Product.Find(id);
            Myorders order = new Myorders();
            order.Name = p.Name;
            order.Price = p.Price;
            order.Date = DateTime.Now;
            var result=db.Myorders.Add(order);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult DeleteOrder(int id)
        {

           
            Myorders order = db.Myorders.Find(id);
           db.Myorders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult MyOrder()
        {
            var result = db.Myorders.ToList();
            return View(result);
        }
        public IActionResult MyProfile()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUser(User user)
        {
            if (ModelState.IsValid)
            {
                uploadPhoto(user);
                db.User.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));

        }

        void uploadPhoto(User model)
        {
            if (model.File != null)
            {
                string uploadFolder = Path.Combine(host.WebRootPath, "images/Users");
                string uniqeFileName = Guid.NewGuid() + ".jpg";
                string filePath = Path.Combine(uploadFolder, uniqeFileName);
                using (var fileStreem = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyTo(fileStreem);
                }
                model.Image = uniqeFileName;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
