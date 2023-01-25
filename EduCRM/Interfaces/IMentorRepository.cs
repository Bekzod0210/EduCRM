using EduCRM.Models;

namespace EduCRM.Interfaces
{
    public interface IMentorRepository
    {
        Task<bool> CreateStudentAsync(Student entity);
        Task<bool> CreateGroupAsync(Group entity);
        Task<bool> DeleteStudentAsync(int id);
        Task<bool> DeleteGroupAsync(int id);
        Task<IQueryable<Student>> GetAllAsync();
        Task<Student> GetAsync(int id);
    }
}
