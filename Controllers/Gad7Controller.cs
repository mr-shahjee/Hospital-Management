using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PracticeCrud.Models;

namespace PracticeCrud.Controllers
{
    [Route("Gad7")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class Gad7Controller : Controller
    {
         private readonly IConfiguration _config;
        public readonly UserContext _userContext;
        public Gad7Controller(IConfiguration config, UserContext userContext)
        {
            _config = config;
            _userContext = userContext;
        }

          [HttpPost]
        public IActionResult CreateGad7(Gad7 gad7)
        {
            _userContext.gad7s.Add(gad7);
            _userContext.SaveChanges();
            return Ok("Success from create method");
        }

        [HttpGet]
public IActionResult GetGad7()
{
    var getall =_userContext.gad7s.ToList();
     return Ok(getall);
}
    }
}