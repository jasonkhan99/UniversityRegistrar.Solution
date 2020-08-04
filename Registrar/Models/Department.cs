using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Courses = new HashSet<Course>();
      this.Students = new HashSet<Student>();
    }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public ICollection<Course> Courses { get; }
    public ICollection<Student> Students { get; }
  }
}