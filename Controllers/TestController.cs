using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace testdotnet
{
    [Area("TestArea")]
    [Route("api/[area]/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private const string MODULE = "TEST";

        [HttpGet]
        [SwaggerOperation(Tags = new[] { MODULE })]
        [ProducesResponseType(typeof(Todo[]), 200)]
        public IActionResult GetTodos()
        {
            try
            {
                var sampleTodos = new Todo[] {
    new(1, "Walk the dog",null,true),
    new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
    new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
    new(4, "Clean the bathroom",null,true),
    new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
          };
                return Ok(sampleTodos);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}