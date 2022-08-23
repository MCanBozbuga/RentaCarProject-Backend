using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WebAPI.Controllers
{// 1. Adım constructor oluştur. Business'den alacağımız için IBrandService _brandService;
 // Ampulden Genereta constructor oluşturulur.
 // 2. Adım [HttpGet("getall")] gibi operasyonlarını oluştur.
 // 3. Adım  _brandService 'i sonuca ata.
 // 4. Adım if sonuc başarılı ise Ok döndğr , değilse BadRequest döndür.
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _carImageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _carImageService.GetBCaryId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("addcarimage")]
        public IActionResult Add([FromForm] IFormFile formFile, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(formFile,carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletecarimage")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPut("updatecarimage")]
        public IActionResult Update([FromForm] IFormFile formfile, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Update(formfile, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
