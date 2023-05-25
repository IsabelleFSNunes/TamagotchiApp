using Microsoft.AspNetCore.Mvc;

namespace TamagotchiApp.Controllers
{
    [ApiController]
    [Route("mytamagotchi")]
    public class TamagotchiController : ControllerBase
    { 
        [HttpGet]
        public void Get()
        {
            const string url = "https://pokeapi.co/api/v2/ability/65/";
            using( var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                //Console.WriteLine(response.StatusCode);
                var reponse_content = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(reponse_content);

            }

        }

        [HttpPost(Name = "test")]
        public void Post()
        {
            Console.WriteLine("Teste Post");
        }

    }
}