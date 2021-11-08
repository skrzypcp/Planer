using Microsoft.AspNetCore.Mvc;
using Planer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planer.Controllers
{
    [Route("api")]
    public class BookController : Controller
    {
        [Route("")]
        public IActionResult Random()
        {
            Book book = new Book();
            book.Author = "Bibeault Katz";
            book.Title = "jQuery in Action";

            return new JsonResult(book);
        }

        [Route("all")]
        public IActionResult AllBooks()
        {
            List<Book> list = new List<Book>();
            Book book = new Book();
            book.Author = "Bibeault Katz";
            book.Title = "jQuery in Action";
            Book book2 = new Book();
            book2.Author = "Robin Sen";
            book2.Title = "Android w Akcji";
            list.Add(book); list.Add(book2);

            return new JsonResult(list);
        }
    }
}
