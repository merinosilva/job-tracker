using System;

namespace Domain.Entity
{
    public class JobApplicationProgress
    {
        public Guid ApplicationId { get; set; }
        public int ProgressNo { get; set; }
        public virtual JobApplication Application { get; set; }
        public DateTime ProgressDate { get; set; }
        public string ProgressType { get; set; }
        public string Note { get; set; }

    }
}