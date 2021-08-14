using Domain.DTO;
using MediatR;

namespace Application.Requests
{
    public class SaveCompany : IRequest<Unit>
    {
        public CompanyDTO Company { get; set; }
    }
}