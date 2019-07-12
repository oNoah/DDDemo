using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudentAppService 
    {
        void Register(StudentViewModel customerViewModel);
        IEnumerable<StudentViewModel> GetAll();
        Task<StudentViewModel> GetById(int id);
        void Update(StudentViewModel customerViewModel);
        void Remove(Guid id);
    }
}
