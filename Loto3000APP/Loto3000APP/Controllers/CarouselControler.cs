using Loto3000App.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loto3000APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselControler : ControllerBase
    {
        public ICarouselInteface _carouselInteface { get; set; }

        public CarouselControler(ICarouselInteface carouselInteface)
        {
            _carouselInteface = carouselInteface;
        }

        [HttpGet("RandomNumbers")]
        public IActionResult DraftNumbers()
        {
            return Ok(_carouselInteface.DraftNumbers());
        }
    }
}
