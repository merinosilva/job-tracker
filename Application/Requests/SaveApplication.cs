using Domain.DTO;
using MediatR;

namespace Application.Requests
{
    public class SaveApplication : IRequest<Unit>
    {
        public JobApplicationDTO Application { get; set; }
    }
}