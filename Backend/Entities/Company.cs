using Backend.Enums;

namespace Backend.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        //Relationships
        public ICollection<Job> Jobs { get; set; }

    }
}