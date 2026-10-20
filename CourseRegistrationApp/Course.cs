public class Course
{
    public string Name { get; set; }
    public int Fee { get; set; }
    
    public override string ToString() => Name;
}