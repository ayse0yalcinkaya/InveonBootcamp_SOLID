using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestPractice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //service katmanından çağıracak olan yer
        //DataAccess

        //olmayacaklar********
        //try-catch
        //business code
        //fat controller
        //ProductsController(IProductService,ICacheService,IXService,IHasService)
        //Unit test / Integration Test yazılmaz SADECE  End-to-End Test yazılır
    }                  //dışa bağımlılık yerimiz
}
