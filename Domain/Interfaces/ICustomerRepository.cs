using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //一些Customer独有的接口
        Customer GetByEmail(string email);
    }
}
