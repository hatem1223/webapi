using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Models;
using WebApi.Repostories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly IAuthorRepostory authorRepostory;
        public AuthorController(IAuthorRepostory _authorRepostory)
        {
            authorRepostory = _authorRepostory;
        }
        
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var Authorlist = authorRepostory.GetAuthors().ToList();
            return new JsonResult(Authorlist) ;
            
        }
        [HttpPost("create")]
        public IActionResult CreateAuthor(Author author )
        {
            authorRepostory.InsertAuthor(author);
            authorRepostory.Save();
            var result = JsonConvert.SerializeObject(author, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            return Ok(result);
        }
        [HttpDelete ("{Authorid}")]
        public IActionResult DeleteAuthor(int Authorid)
        {
            Author author  =authorRepostory.GetAuthorByid(Authorid);
            authorRepostory.DeleteAuthor(Authorid);
            authorRepostory.Save();
            return new JsonResult(author);
        }
        //[HttpPost("update/{id}")]
        [HttpPatch("update")]
        public IActionResult UpdateAuthor(Author author)
        {
            authorRepostory.UpdateAuthor(author);
            authorRepostory.Save();
            return new JsonResult(author);
        }
    }
}