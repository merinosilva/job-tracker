using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class JobApplication
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string ApplicationRef { get; set; }
        public string ApplicationSource { get; set; }
        public string JobPostURL { get; set; }
        public virtual ICollection<JobApplicationProgress> progress { get; set; }
    }
}