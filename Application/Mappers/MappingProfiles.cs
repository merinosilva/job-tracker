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
            // mapping
            CreateMap<Company, CompanyDTO>();
            CreateMap<JobApplication, JobApplicationDTO>();
            CreateMap<JobApplicationProgress, JobApplicationProgressDTO>();

            // reverse mapping
            CreateMap<CompanyDTO, Company>();
            CreateMap<JobApplicationDTO, JobApplication>();
            CreateMap<JobApplicationProgressDTO, JobApplicationProgress>();
        }
    }
}