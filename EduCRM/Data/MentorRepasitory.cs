using EduCRM.Interfaces;
using EduCRM.Models;
using Microsoft.EntityFrameworkCore;

namespace EduCRM.Data
{
    public class MentorRepasitory : IMentorRepository
    {
        private readonly AppDbContext _appDbContext;

        public MentorRepasitory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> CreateGroupAsync(Group entity)
        {
            await _appDbContext.Groups.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreateStudentAsync(Student entity)
        {
            await _appDbContext.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteGroupAsync(int id)
        {
            var entity = await _appDbContext.Groups.FindAsync(id);
            _appDbContext.Groups.Remove(entity);
            return true;          
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var entity = await _appDbContext.Students.FindAsync(id);
            _appDbContext.Students.Remove(entity);
            return true;
        }

        public async Task<IQueryable<Student>> GetAllAsync()
        {
            return _appDbContext.Students.Include(x => x.GroupId == x.Group.Id);
        }

        public async Task<Student> GetAsync(int id)
        {
            var student = await _appDbContext.Students.FindAsync(id);
            return student;
        }
    }
}
