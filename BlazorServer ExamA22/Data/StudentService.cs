namespace BlazorServer_ExamA22.Data;
using System.Linq;
using BlazorServer_ExamA22.Models;
public class StudentService
{
    private readonly List<Student> _list = new List<Student>();
    public List<Student> GetAll() => _list;

    public void AddStudent(Student student)
    {
        student.Id = _list.Count + 1;
        _list.Add(student);
    }
}