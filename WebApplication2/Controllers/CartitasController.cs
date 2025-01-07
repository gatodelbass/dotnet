//using Microsoft.AspNetCore.Mvc;

//namespace WebApplication2.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class CartitasController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        private readonly ILogger<CartitasController> _logger;

//        public CartitasController(ILogger<CartitasController> logger)
//        {

                

//            _logger = logger;
//        }

//        [HttpGet(Name = "GetCartitas")]
//        public IEnumerable<Cartitas> GetCartitas()
//        {
//            return Enumerable.Range(1, 5).Select(index => new Cartitas
//            {
//                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//                TemperatureC = Random.Shared.Next(-20, 55),
//                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//            })
//            .ToArray();
//        }


//        [HttpGet(Name = "GetCartitasNuevas")]
//        public String GetCartitasNuevas()
//        {
//            return "devuelve unas cartitas nuevas ";
//        }
//    }
//}
