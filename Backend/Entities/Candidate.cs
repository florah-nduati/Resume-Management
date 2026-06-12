using System.ComponentModel.DataAnnotations;

namespace Backend.Entities

{
    public class Candidate : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }
        // Relationships
        public long JobId { get; set; }
        public Job Job { get; set; }
    }
}