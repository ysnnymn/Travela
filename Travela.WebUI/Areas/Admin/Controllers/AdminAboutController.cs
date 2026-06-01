using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Travela.EntityLayer.Concrete;
using Travela.WebUI.Areas.Admin.Models.AboutViewModel;

namespace Travela.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: AdminAboutController
        public async Task<IActionResult> AboutList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7002/api/Abouts");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<About>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(AboutCreateViewModel createViewModel)
        {
            // Varsayılan resim kullanıcı resim eklemezse otomatik resim eklencek
            string imageName = "default.png";
            if (createViewModel.Image != null)
            {
                var extension = Path.GetExtension(createViewModel.Image.FileName); //Dosya uzantısını al
                imageName = Guid.NewGuid().ToString() + extension; // Benzersiz isim oluştur
                //Klasör Yolu
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "about");
                if (!Directory.Exists(folderPath)) //Klasör Yoksa oluştur
                {
                    Directory.CreateDirectory(folderPath);
                }

                var path = Path.Combine(folderPath, imageName); //Dosya Yolu +adı
                using (var stream = new FileStream(path, FileMode.Create)) //Dosyayı oluştur
                {
                    await createViewModel.Image.CopyToAsync(stream); //Yüklenen Resmi Kaydet
                }

            }

            var about = new About
            {
                Title = createViewModel.Title,
                Description = createViewModel.Description,
                ImageUrl = "/images/about/" + imageName,
            };
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(about);
            StringContent stringContent=new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7002/api/Abouts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AboutList", "AdminAbout", new { area = "Admin" });
            }
            
            return View();


        }
    }
}

