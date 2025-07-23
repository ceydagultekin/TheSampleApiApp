using System.Net.Http.Json;
using System.Text.Json;
using WinFormDemo.Models;
using WinFormDemo.Services;

namespace WinFormDemo;

public partial class Courses : Form
{
    private List<CourseModel>? courses;
    private int currentCourse = 0;

    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public Courses()
    {
        InitializeComponent();
    }

    private async void Courses_Load(object sender, EventArgs e)
    {
        try
        {
            courses = await HttpService.Client.GetFromJsonAsync<List<CourseModel>>("/courses", options) ?? new();
            LoadCourse(0);
        }
        catch (Exception ex)
        {

            MessageBox.Show($"Error calling API: {ex.Message}");
            courses = new();
        }
    }

    private void LoadCourse(int index)
    {
        if (courses is null || index < 0 || index >= courses.Count)
        {
            return;
        }

        courseImage.ImageLocation = courses[index].CourseImage;
        currentCourse = index;
    }

    private void previous_Click(object sender, EventArgs e)
    {
        LoadCourse(currentCourse - 1);
    }

    private void next_Click(object sender, EventArgs e)
    {
        LoadCourse(currentCourse + 1);
    }
}
