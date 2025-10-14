public class Student
{
    public int StudentID { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public bool Signed { get; set; }
    public DateTime SignedAt { get; set; }
}