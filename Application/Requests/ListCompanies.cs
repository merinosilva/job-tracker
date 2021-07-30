using System.Collections.Generic;
using Domain.DTO;
using MediatR;

namespace Application.Requests
{
    public class ListCompanies : IRequest<List<CompanyDTO>>
    {
        
    }
}