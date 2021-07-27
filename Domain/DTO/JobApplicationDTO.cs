using System;

namespace Domain.DTO
{
    public class JobApplicationDTO
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string ApplicationRef { get; set; }
        public string ApplicationSource { get; set; }
        public string JobPostURL { get; set; }
    }
}