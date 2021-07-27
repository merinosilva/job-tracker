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

// return all job application data
namespace Application.Handlers
{
    public class ListApplicationsHandler : IRequestHandler<ListApplications, List<JobApplicationDTO>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ListApplicationsHandler(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<JobApplicationDTO>> Handle(ListApplications request, CancellationToken cancellationToken)
        {
            var list = await _context.Applications.ProjectTo<JobApplicationDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            return list;
        }
    }
}