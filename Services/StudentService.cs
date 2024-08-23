using Microsoft.EntityFrameworkCore;
using Registrar.Data;
using Registrar.Models;

namespace Registrar.Services;

public class StudentService : IStudentService
{
    private readonly RegistrarContext _context;

    public StudentService(RegistrarContext context)
    {
        _context = context;
    }

    public async Task<List<Student>> GetStudentsAsync()
{
    return await _context.Students
        .Include(s => s.Registrations)
            .ThenInclude(r => r.Course)
        .ToListAsync();
}

public async Task<Student?> GetStudentAsync(int id)
{
    return await _context.Students
        .Include(s => s.Registrations)
            .ThenInclude(r => r.Course)
        .FirstOrDefaultAsync(s => s.Id == id);
}


    public async Task AddStudentAsync(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {
        _context.Entry(student).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}
