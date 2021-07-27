using AutoMapper;
using Domain.DTO;
using Domain.Entity;

/*
Create auto mapper profiles for each mapping from / to entity -> DTO classes.
*/
namespace Application.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<JobApplication, JobApplicationDTO>();
        }
    }
}