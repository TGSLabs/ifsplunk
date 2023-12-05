using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ifsplunk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseTextController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReverseTextController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string text)
        {
            return Ok(await _mediator.Send(new ReverseTextQuery { Text = text }));
        }
    }
}
