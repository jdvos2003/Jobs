using CarDescription_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDescription_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarContext _context;

        public CarsController(CarContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }
        [HttpGet]
        public async Task<ActionResult> GetAllCars()
        {
            return Ok(await _context.CarModels.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCar(int id)
        {
            var car = await _context.CarModels.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
    }
}
