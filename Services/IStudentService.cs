using System.Collections.Generic;
using System.Threading.Tasks;
using Registrar.Models;

namespace Registrar.Services
{
	public interface IStudentService
	{
		Task AddStudentAsync(Student student);
		Task<List<Student>> GetStudentsAsync();
	}
}