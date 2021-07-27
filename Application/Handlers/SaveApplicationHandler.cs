using System.Threading;
using System.Threading.Tasks;
using Application.Requests;
using AutoMapper;
using Domain.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers
{
    public class SaveApplicationHandler : IRequestHandler<SaveApplication, Unit>
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public SaveApplicationHandler(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(SaveApplication request, CancellationToken cancellationToken)
        {
            var ja = await context.Applications.FirstOrDefaultAsync(application => application.Id == request.Application.Id);
            if(ja == null) // a new object
            {
                context.Applications.Add(mapper.Map<JobApplication>(request.Application));
            }
            else // update existing data
            {
                mapper.Map(request.Application, ja);
            }
            await context.SaveChangesAsync();
            
            return Unit.Value;
        }
    }
}