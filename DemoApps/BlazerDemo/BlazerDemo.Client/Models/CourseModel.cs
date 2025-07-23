namespace BlazerDemo.Client.Models;

public class CourseModel
{
    public int Id { get; set; }
    public bool IsPreorder { get; set; }
    public string? CourseUrl { get; set; }
    public string? CourseType { get; set; }
    public string? CourseName { get; set; }
    public int CourseLessonCount { get; set; }
    public double CourseLengthInHours { get; set; }
    public string? ShortDescription { get; set; }
    public string? CourseImage { get; set; }
    public int PriceInUSD { get; set; }
    public string? CoursePreviewLink { get; set; }
}
