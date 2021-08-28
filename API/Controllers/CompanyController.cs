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
    [Route("api/company")]
    public class CompanyController : ControllerBase
    {
        public IMediator _mediator { get; }
        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("list-all")]
        [HttpGet]
        public async Task<ActionResult<List<CompanyDTO>>> ListCompanies()
        {
            return await _mediator.Send(new ListCompanies());
        }

        [Route("save")]
        [HttpPost]
        public async Task<IActionResult> SaveCompany(CompanyDTO company)
        {
            return Ok(await _mediator.Send(new SaveCompany{Company = company}));
        }

    }
}