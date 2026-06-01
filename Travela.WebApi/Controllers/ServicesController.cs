using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var value=_serviceService.TGetListAll();
            return Ok(value);
        }

        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var value=_serviceService.TGet(x=>x.ServiceId == id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _serviceService.TAdd(service);
            return Ok("Hizmet Eklendi");
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok("Hizmet Güncellendi");
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var value=_serviceService.TGet(x=>x.ServiceId == id);
            _serviceService.TDelete(value);
            return Ok("Hizmet Silindi");
        }
        
    }
}
