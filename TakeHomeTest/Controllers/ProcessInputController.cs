using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessInputController : ControllerBase
    {
        private readonly IProcessInputService _processInputService;
        private readonly ILogger<ProcessInputController> _logger;

        public ProcessInputController(IProcessInputService processInputService, ILogger<ProcessInputController> logger)
        {
            _processInputService = processInputService;
            _logger = logger;
        }

        [HttpPost("/FormatCSV")]
        [Consumes("text/plain")]
        public IActionResult Post([FromBody] string csvInput)
        {
            string response = _processInputService.ProcessInput(csvInput);
            return Ok(response);
        }
    }
}
