using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Requests;
using Domain.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// api controller for CRUD operations related to job applications
namespace API.Controllers
{
    [ApiController]
    [Route("api/job-application")]
    public class JobApplicationController : ControllerBase
    {
        public IMediator _mediator { get; }
        public JobApplicationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("list-all")]
        [HttpGet]
        public async Task<ActionResult<List<JobApplicationDTO>>> ListApplications()
        {
            return await _mediator.Send(new ListApplications());
        }

        [Route("save")]
        [HttpPost]
        public async Task<IActionResult> SaveApplication(JobApplicationDTO application)
        {
            return Ok(await _mediator.Send(new SaveApplication{Application = application}));
        }

    }
}