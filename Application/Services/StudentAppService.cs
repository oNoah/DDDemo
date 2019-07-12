using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Core.Bus;
using Domain.Core.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentAppService : IStudentAppService
    {
        private readonly IStudentRepository _StudentRepository;
        private readonly IMapper _mapper;
        //中介者 总线
        private readonly IMediatorHandler Bus;
        public StudentAppService(
            IStudentRepository StudentRepository,
            IMediatorHandler bus,
            IMapper mapper
            )
        {
            _StudentRepository = StudentRepository;
            _mapper = mapper;
            Bus = bus;
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<StudentViewModel> GetById(int id)
        {
            var entity = await _StudentRepository.Get(id);
            var model = _mapper.Map<StudentViewModel>(entity);
            return model;
        }

        public void Register(StudentViewModel studentViewModel)
        {
            //这里引入领域设计中的写命令 还没有实现
            //请注意这里如果是平时的写法，必须要引入Student领域模型，会造成污染
            var registerCommand = _mapper.Map<RegisterStudentCommand>(studentViewModel);

            Bus.SendCommand(registerCommand);

            //_StudentRepository.Add(_mapper.Map<Student>(studentViewModel));
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
