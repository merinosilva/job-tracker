using System;
using System.Collections.Generic;

namespace Domain.DTO
{
    public class JobApplicationDTO
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public Guid CompanyId { get; set; }
        public string ApplicationRef { get; set; }
        public string ApplicationSource { get; set; }
        public string JobPostURL { get; set; }
        public virtual ICollection<JobApplicationProgressDTO> progress { get; set; }
    }
}