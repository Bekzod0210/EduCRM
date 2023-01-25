namespace EduCRM.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        
        public int MentorId { get; set; }
        
        public Mentor? Mentor { get; set; }
        
        public List<Student>? Students { get; set; }
    }
}
