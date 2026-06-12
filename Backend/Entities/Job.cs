using Backend.Enums;
using System.ComponentModel.DataAnnotations;
namespace Backend.Entities
{
    public class Job : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public JobLevel Level { get; set; }

        // Relationships
        public long CompanyId { get; set; } 
        public Company Company { get; set; }
        public ICollection<Candidate> Candidates { get; set; }


    }
}