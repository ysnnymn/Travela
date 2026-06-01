using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        [HttpGet]
        public IActionResult DestinationList()
        {
            var value = _destinationService.TGetListAll();
            return Ok(value);
        }

        [HttpGet("GetDestination")]
        public IActionResult GetDestination(int id)
        {
            var value = _destinationService.TGet(x => x.DestinationId == id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDestination(Destination destination)
        {
           _destinationService.TAdd(destination);
           return Ok("Rota Başaarıyla Eklendi");
        }

        [HttpPut]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return Ok("Rota Güncellendi");
        }

        [HttpDelete]
        public IActionResult DeleteDestination(int id)
        {
            var value=_destinationService.TGet(x => x.DestinationId == id);
            _destinationService.TDelete(value);
                return Ok("Rota Silindi");
        }
    }
}
