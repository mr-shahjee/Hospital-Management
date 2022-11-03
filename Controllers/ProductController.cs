using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using PracticeCrud.Models;

namespace PracticeCrud.Controllers
{
    [Route("Products")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ProductController : Controller
    {
         private readonly IConfiguration _config;
        public readonly UserContext _userContext;
        public ProductController(IConfiguration config, UserContext userContext)
        {
            _config = config;
            _userContext = userContext;
        }
        [HttpPost]
        public IActionResult CreateProduct(Products product)
        {
            _userContext.products.Add(product);
            _userContext.SaveChanges();
            return Ok("Success from create method");
        }


        
[HttpGet]
public IActionResult GetProducts()
{
    var getall =_userContext.products.ToList();
     return Ok(getall);
}



[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var del = _userContext.products.Where(n => n.ProductId == id).FirstOrDefault();
        _userContext.products.Remove(del);
            _userContext.SaveChanges();
    return Ok("Success from create method");
}


[HttpPut("{id}")]
public IActionResult EditData(int id, Products product)
{
    var edit = _userContext.products.Find(id);
    if(edit != null){
         edit.ProductName = product.ProductName;
       edit.Category = product.Category;
       edit.Condition = product.Condition;
       edit.Price = product.Price;
       edit.Comment = product.Comment;
       edit.Date = product.Date;
    _userContext.Update(edit);
        _userContext.SaveChanges();
    
}
      return Ok("Success from Edit method");

}



    }
}