using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ocelot_api.Repository;

namespace ocelot_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IRepository _repository;

        public ArticleController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _repository.Get(id);
            if (article is null)
                return NotFound();
            return Ok(article);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedId = _repository.Delete(id);
            if (deletedId == 0)
                return NotFound();
            return NoContent();
        }
    }
}
