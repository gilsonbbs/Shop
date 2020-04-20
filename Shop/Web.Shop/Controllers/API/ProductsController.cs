namespace Web.Shop.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Web.Shop.Data;


    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAll());
        }
    }
}
