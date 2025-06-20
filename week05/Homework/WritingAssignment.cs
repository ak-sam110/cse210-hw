// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get writing assignment info
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
