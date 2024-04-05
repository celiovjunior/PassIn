using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassIn.Application.UseCases.Events.Register;
using PassIn.Communication.Requests;

namespace PassIn.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestEventJson request)
        {
            var useCase = new RegisterEventsUseCase();
            
            useCase.Execute(request);

            return Created();
        }

    }
}
