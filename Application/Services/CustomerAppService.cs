using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            return null;
            //return _customerRepository.GetAll().ProjectTo<CustomerViewModel>();
        }

        public CustomerViewModel GetById(int id)
        {
            return null;
            //return _mapper.Map<CustomerViewModel>(_customerRepository.GetById(id));
        }

        public void Register(CustomerViewModel customerViewModel)
        {
            //var registerCommand = _mapper.Map<RegisterNewCustomerCommand>(customerViewModel);
        }

        public void Update(CustomerViewModel customerViewModel)
        {
            //var updateCommand = _mapper.Map<UpdateCustomerCommand>(customerViewModel);
        }

        public void Remove(Guid id)
        {
            //var removeCommand = new RemoveCustomerCommand(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
