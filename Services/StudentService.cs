using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using Registrar.Data; // Ensure this matches the namespace in RegistrarContext

namespace Registrar.Services
{
    public class StudentService : IStudentService
    {
        private readonly RegistrarContext _context;

        public StudentService(RegistrarContext context)
        {
            _context = context;
        }

        public async Task AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        // Other methods to retrieve, update, and delete students can be added here
    }
}
