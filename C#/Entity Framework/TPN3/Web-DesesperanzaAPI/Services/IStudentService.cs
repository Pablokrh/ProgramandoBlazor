using Web_DesesperanzaAPI.Models;

namespace Web_DesesperanzaAPI.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudentsWithCourses();
        IEnumerable<Student> GetStudentsWithNoCourses();

    }
}
