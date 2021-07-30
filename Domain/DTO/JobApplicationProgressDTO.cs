using System;

namespace Domain.DTO
{
    public class JobApplicationProgressDTO
    {
        public Guid ApplicationId { get; set; }
        public int ProgressNo { get; set; }
        public DateTime ProgressDate { get; set; }
        public string ProgressType { get; set; }
        public string Note { get; set; }
        
    }
}