using Domain.DTO;
using MediatR;

namespace Application.Requests
{
    public class SaveProgress : IRequest<Unit>
    {
        public JobApplicationProgressDTO Progress { get; set; }
    }
}