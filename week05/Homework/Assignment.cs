// Assignment.cs
public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary
    public string GetSummary()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }

    //Getter method for student name
    public string GetStudentName()
    {
        return _studentName;
    }
}
