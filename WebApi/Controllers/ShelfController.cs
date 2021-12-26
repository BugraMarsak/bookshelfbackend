using Business.Abstract;
using Core.Utilities.webscrap;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : Controller
    {
        IShelfService _shelfService;

        public ShelfController(IShelfService shelfService)
        {
            _shelfService = shelfService;
        }

        [HttpPost("add")]
        public IActionResult add(Shelf shelf)
        {
            var result = _shelfService.Add(shelf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Shelf shelf)
        {
            var result = _shelfService.Delete(shelf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetOrdersByUserId(int Id)
        {
            var result = _shelfService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("reading")]
        public string test(string url)
        {
            var result = WebScrap.test(url);
            return result;
        }

    }
}
