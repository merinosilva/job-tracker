using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public virtual ICollection<JobApplication> applications { get; set; }
    }
}