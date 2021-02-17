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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getrentals")]
        public IActionResult GetRentals()
        {
            var result = _rentalService.GetAllRental();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("rentalsdetail")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetRentalsDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getrental")]
        public IActionResult GetRental(int id)
        {
            var result = _rentalService.GetAllRentalById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addrental")]
        public IActionResult AddRental(Rental rental)
        {
            var result = _rentalService.Rental(rental);
            if (result.Success)
            {
                return Ok(rental);
            }
            return BadRequest(result);
        }
        [HttpPost("updaterental")]
        public IActionResult UpdateRental(Rental rental)
        {
            var result = _rentalService.UpdateRental(rental);
            if (result.Success)
            {
                return Ok(rental);
            }
            return BadRequest(result);
        }
        [HttpPost("deleterental")]
        public IActionResult DeleteRental(Rental rental)
        {
            var result = _rentalService.DeleteRental(rental);
            if (result.Success)
            {
                return Ok(rental);
            }
            return BadRequest(result);
        }
    }
}
