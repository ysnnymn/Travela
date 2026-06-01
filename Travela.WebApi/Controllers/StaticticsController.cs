using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticticsController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public StaticticsController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult StaticticList()
        {
            var value = _categoryService.TGetCategoryCount();
            return Ok(new
            {
                categoryCount = value
            });
        }
    }
}
