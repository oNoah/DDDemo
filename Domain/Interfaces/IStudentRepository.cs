using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task Sign();
    }
}
