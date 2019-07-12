using Domain.Models;
using System;

namespace Domain.Dao
{
    /// <summary>
    /// 领域对象持久化层
    /// </summary>
    public class CustomerDao
    {
        public static Customer GetCustomer(string id)
        {
            return new Customer(new Guid(),"","", DateTime.Now);
        }


        public static string SaveCustomer(Customer customer)
        {
            return "保存成功";
        }
    }
}
