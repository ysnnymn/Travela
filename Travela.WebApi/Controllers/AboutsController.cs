using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _aboutService.TGetListAll();
            return Ok(value);
        }

        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGet(x => x.AboutId == id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok("Hakkımızda Güncellendi");
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _aboutService.TAdd(about);
            return Ok("Hakkımızda Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values=_aboutService.TGet(x=>x.AboutId == id);
            _aboutService.TDelete(values);
            return Ok("Hakkımızda Silindi");
        }
    }
}
