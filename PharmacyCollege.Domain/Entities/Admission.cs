using System.ComponentModel.DataAnnotations;

namespace PharmacyCollege.Domain.Entities
{
    public class Admission
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
