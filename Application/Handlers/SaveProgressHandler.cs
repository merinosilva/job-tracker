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
    public class SaveProgressHandler : IRequestHandler<SaveProgress, Unit>
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public SaveProgressHandler(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(SaveProgress request, CancellationToken cancellationToken)
        {
            var prog = await context.Progresses.FirstOrDefaultAsync(prog => prog.ApplicationId == request.Progress.ApplicationId && prog.ProgressNo == request.Progress.ProgressNo);
            if(prog == null) // a new object
            {
                context.Progresses.Add(mapper.Map<JobApplicationProgress>(request.Progress));
            }
            else // update existing data
            {
                mapper.Map(request.Progress, prog);
            }
            await context.SaveChangesAsync();
            
            return Unit.Value;
        }
    }
}