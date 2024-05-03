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
        [HttpGet("DestinationList")]
        public IActionResult DestinationList()
        { 
            var values=_destinationService.TGetListAll();   
            return Ok(values);
        }
        [HttpPost("CreateDestination")]
        public IActionResult CreateDestination(Destination destination)
        {
            _destinationService.TInsert(destination);
            return Ok("Rota Başarıyla Eklendi");
        }
        [HttpDelete("DeleteDestination")]
        public IActionResult DeleteDestination(int id)
        {
            _destinationService.TDelete(id);
            return Ok("Rota Başarıyla Silindi.");
        }

        [HttpPut("UpdateDestination")]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return Ok("Rota Başarıyla Güncellendi.");
        }

        [HttpGet("GetDestination")]
        public IActionResult GetDestination(int id)
        {
           
            return Ok(_destinationService.TGetById(id));
        }

    }
}
