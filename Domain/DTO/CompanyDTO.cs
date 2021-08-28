using System;
using System.Collections.Generic;

namespace Domain.DTO
{
    public class CompanyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        // public virtual ICollection<JobApplicationDTO> applications { get; set; }
    }
}