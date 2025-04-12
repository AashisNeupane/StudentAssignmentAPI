namespace StudentAssignmentAPI.Entities;

public class Assignment
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDateTime { get; set; }
    public bool IsSubmitted { get; set; }
    
    public Guid StudentID { get; set; }
    public Student Student { get; set; }
}