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
using Microsoft.AspNetCore.Hosting;

namespace CarRentalManagement.Server.Controllers
{
    // api/[controller] vehicles it so the "Controller" part of the name is ignored.
    // Example: this API endpoint can be accessed with just websitename.com/Vehicles instead of websitename.com/VehiclesController.
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        // Dependency injection
        public VehiclesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: /Vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            List<string> includes = new List<string> { "Make", "Model", "Colour" };
            var vehicles = await _unitOfWork.Vehicles.GetAll(includes: includes);
            return Ok(vehicles);
        }

        // GET: /Vehicles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            List<string> includes = new List<string> { "Make", "Model", "Colour", "Bookings" };
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id, includes);

            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // PUT: /Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }

            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateImageFile(vehicle.Image, vehicle.ImageName);
            }

            _unitOfWork.Vehicles.Update(vehicle);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await VehicleExists(id) == false)
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

        // POST: /Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateImageFile(vehicle.Image, vehicle.ImageName);
            }            

            await _unitOfWork.Vehicles.Insert(vehicle);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        // DELETE: /Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private string CreateImageFile(byte[] image, string imageName)
        {
            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{imageName}";
            var fileStream = System.IO.File.Create(path);
            fileStream.Write(image, 0, image.Length);
            fileStream.Close();
            return $"https://{url}/uploads/{imageName}";
        }

        private async Task<bool> VehicleExists(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);

            return vehicle == null;
        }
    }
}
