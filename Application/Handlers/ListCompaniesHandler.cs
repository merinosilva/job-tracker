using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Requests;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

// return all company data
namespace Application.Handlers
{
    public class ListCompaniesHandler : IRequestHandler<ListCompanies, List<CompanyDTO>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ListCompaniesHandler(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<CompanyDTO>> Handle(ListCompanies request, CancellationToken cancellationToken)
        {
            var list = await _context.Companies.ProjectTo<CompanyDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            return list;
        }
    }
}