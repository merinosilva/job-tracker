using Domain.DTO;
using MediatR;

namespace Application.Requests
{
    public class SaveCompany : IRequest<Unit>
    {
        public CompanyDTO company { get; set; }
    }
}