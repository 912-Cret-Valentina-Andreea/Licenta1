namespace elearning.Entities
{
    public class Classes
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        //public List<Student>? Students { get; set; }
        public int TeacherId { get; set; }
    }
}
