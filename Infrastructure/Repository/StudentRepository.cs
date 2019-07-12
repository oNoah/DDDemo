using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class StudentRepository : Repository<Student, StudyContext>, IStudentRepository
    {
        public StudentRepository(StudyContext studyContext)
            :base(studyContext)
        {

        }

        public Task Sign()
        {
            throw new NotImplementedException();
        }
    }
}
