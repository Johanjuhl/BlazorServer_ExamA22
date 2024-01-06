using BlazorServer_ExamA22.Models;

namespace BlazorServer_ExamA22.Data;

public class GradeService
{
    private readonly List<GradeInCourse> _grades = new List<GradeInCourse>();
    public List<GradeInCourse> GetAllGrades() => _grades;

    public void AddGradeToStudent(GradeInCourse grade)
    {
        grade.Id = _grades.Count + 1;
        _grades.Add(grade);
    }

    private List<StatisticsOverviewDto> statisticsList = new List<StatisticsOverviewDto>
    {
        
    }
}