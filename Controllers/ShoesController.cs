using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shoes.Models;
using shoes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace shoes.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoesController : ControllerBase
  {
    private readonly ShoeRepository _shoeRepo;
    public ShoesController(ShoeRepository shoeRepo)
    {
      _shoeRepo = shoeRepo;
    }

    // GET api/values
    // [HttpGet]
    // public ActionResult<IEnumerable<string>> Get()
    // {
    //   return Ok(_shoeRepo.GetAll());
    // }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Shoe> Get(int id)
    {
      Shoe result = _shoeRepo.GetShoeById(id);
      if (result != null)
      {
        return Ok(result);
      }
      return NotFound();
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Shoe> Post([FromBody] Shoe value)
    {
      return Created("/api/shoes/", _shoeRepo.AddShoe(value));
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Shoe> Put(int id, [FromBody] Shoe value)
    {
      Shoe result = _shoeRepo.EditShoe(id, value);
      if (result != null)
      {
        return result;
      }
      return NotFound();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      if (_shoeRepo.DeleteShoe(id))
      {
        return Ok("Deleted");
      }
      return NotFound("No Shoe to delete");
    }
  }
}