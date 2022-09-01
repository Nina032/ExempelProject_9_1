using ExempelProject.Data;
using ExempelProject.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExempelProject.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : Controller
    {
        private readonly IExempelRepository repository;
        private readonly ILogger<ProductsController> logger;

        public ProductsController(IExempelRepository repository, ILogger<ProductsController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                return Ok(repository.GetAllProducts());
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get products: {ex}");
                return BadRequest("failed to get products");
            }
        }
    }
}
