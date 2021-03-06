using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    // api/[controller] bookings it so the "Controller" part of the name is ignored.
    // Example: this API endpoint can be accessed with just websitename.com/Bookings instead of websitename.com/BookingsController.
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        // Dependency injection
        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Bookings
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            List<string> includes = new List<string> { "Vehicle", "Customer" };
            var bookings = await _unitOfWork.Bookings.GetAll(includes: includes);
            return Ok(bookings);
        }

        // GET: /Bookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            List<string> includes = new List<string> { "Vehicle", "Customer" };
            var booking = await _unitOfWork.Bookings.Get(bookingToGet => bookingToGet.Id == id, includes);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        // PUT: /Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await BookingExists(id) == false)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            await _unitOfWork.Bookings.Insert(booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: /Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            return booking == null;
        }
    }
}
