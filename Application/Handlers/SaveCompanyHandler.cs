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
    public class SaveCompanyHandler : IRequestHandler<SaveCompany, Unit>
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public SaveCompanyHandler(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(SaveCompany request, CancellationToken cancellationToken)
        {
            var cmp = await context.Companies.FirstOrDefaultAsync(company => company.Id == request.Company.Id);
            if(cmp == null) // a new object
            {
                context.Companies.Add(mapper.Map<Company>(request.Company));
            }
            else // update existing data
            {
                mapper.Map(request.Company, cmp);
            }
            await context.SaveChangesAsync();
            
            return Unit.Value;
        }
    }
}