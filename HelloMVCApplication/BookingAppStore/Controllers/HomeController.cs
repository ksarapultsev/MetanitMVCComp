using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingAppStore.Models;
using BookingAppStore.Util;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BookingAppStore.Controllers
{
    public class HomeController : Controller
    {
        // создадим контекст данных
        BookContext db = new BookContext();
           
        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Book> books = db.Books;
            // передадим все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;
            // Возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            //добавляем информацию о покупке в базу данных 
            db.Purchases.Add(purchase);
            //сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, " + purchase.Person + ", за покупку!";
        }

        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Hello World!</h2>");
        }
        
        public ActionResult GetImage()
        {
            string path = "../Image/audi.jpg";
            return new ImageResult(path);
        }

        public async Task<ActionResult> BookList()
        {
            IEnumerable<Book> books = await db.Books.ToListAsync();
            ViewBag.Books = books;
            return View("Index");
        }
    }
}