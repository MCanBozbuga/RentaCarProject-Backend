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
        // 1. Adım constructor oluştur. Business'den alacağımız için IBrandService _brandService;
        // Ampulden Genereta constructor oluşturulur.
        // 2. Adım [HttpGet("getall")] gibi operasyonlarını oluştur.  => public IActionResult GetAll()
        // 3. Adım  _brandService 'i sonuca ata. var result = _colorService.GetAll();
        // 4. Adım if sonuc başarılı ise Ok döndğr , değilse BadRequest döndür.   => if (result.Success)
        // 5. Adım Add yaparken Color'ı using'e eklemelisin.
        IRentalService _rentalService;
        public RentalsController(IRentalService  rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyrentalid")]
        public IActionResult GetByRentalId(int rentalId)
        {
            var result = _rentalService.GetByRentalId(rentalId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
