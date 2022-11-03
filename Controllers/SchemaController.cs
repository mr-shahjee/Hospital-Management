using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticeCrud.Models;

namespace PracticeCrud.Controllers
{
     [Route("Schema")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class SchemaController : Controller
    {
           private readonly IConfiguration _config;
        public readonly UserContext _userContext;

        public SchemaController(IConfiguration config, UserContext userContext)
        {
            _config = config;
            _userContext = userContext;
        }

         [HttpPost]
        public IActionResult CreateSchema(Schema schema)
        {
            _userContext.schemas.Add(schema);
            _userContext.SaveChanges();
            return Ok("Success from create method");
        }
        [HttpGet]
    public IActionResult GetSchema()
{
    var getall =_userContext.schemas.ToArray();
     return Ok(getall);
}

[Route("GetById")]
[HttpGet]
    public IActionResult GetSchemaById(int id)
{
    var getall =_userContext.schemas.Where(x => x.schemaId == id);
     return Ok(getall);
}

    }
}