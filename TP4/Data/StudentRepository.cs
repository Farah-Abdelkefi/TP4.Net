using TP4.Models;
using Microsoft.EntityFrameworkCore;
namespace TP4.Data
{
    public interface IStudentRepository:IRepository<Student>
    {
           IEnumerable<String> GetCourses();
    }
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly UniversityContext _context;
        public StudentRepository(UniversityContext db_context) : base(db_context)
        {
            this._context = db_context;
        }

        
        public IEnumerable<String> GetCourses()
        {
            return _context.Student.Select(s =>s.course).Distinct().ToList();

        }

        

    }
}
