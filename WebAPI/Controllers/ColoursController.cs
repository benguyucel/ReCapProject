using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        IColourService _colourService;

        public ColoursController(IColourService colourService)
        {
            _colourService = colourService;
        }

        [HttpGet("getcolours")]
        public IActionResult GetColours()
        {
            var result = _colourService.GetAllColour();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcolour")]
        public IActionResult GetColour(int id)
        {
            var result = _colourService.GetColourById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addcolour")]
        public IActionResult AddColour(Colour colour )
        {
            var result = _colourService.Add(colour);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletecolour")]
        public IActionResult DeleteColour(Colour colour)
        {
            var result = _colourService.Delete(colour);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatecolour")]
        public IActionResult UpdateColour(Colour colour)
        {
            var result = _colourService.Update(colour);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
