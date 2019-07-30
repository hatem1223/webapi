using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repostories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepostory bookrepostory;
        public BookController(IBookRepostory _bookRepostory)
        {
            bookrepostory = _bookRepostory;
        }
        [HttpGet()]
        public IActionResult Get()
        {
            var Booklist = bookrepostory.GetBooks();
            return new JsonResult(Booklist);
        }
        [HttpGet("{Bookid}")]
        public IActionResult GetBookByid( int Bookid)
        {
            var Booklist = bookrepostory.GetBookbyid(Bookid);
            return new JsonResult(Booklist);
        }
        [HttpDelete("{Bookid}")]
        public IActionResult DeleteBook(int Bookid)
        {
             Book book = bookrepostory.GetBookbyid(Bookid);
            bookrepostory.DeleteBook(Bookid);
            bookrepostory.Save();
            return new JsonResult(book);
        }
        [HttpPost("insert")]
        public IActionResult InsertBook(Book book)
        {
            bookrepostory.InsertBook(book);
            bookrepostory.Save();
            return new JsonResult(book);

        }
        [HttpPost("update")]
        public IActionResult UpdateBook(Book book)
        {
            bookrepostory.UpdateBook(book);
            bookrepostory.Save();
            return new JsonResult(book);

        }


    }
}