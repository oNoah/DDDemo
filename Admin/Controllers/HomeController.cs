using Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 删除一个顾客信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [Authorize(Policy = "CanRemoveCustomerData")]
        [Route("customer-management/remove-customer/{id:guid}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
          
            ViewBag.Sucesso = "Customer Removed!";
            return RedirectToAction("Index");
        }

        ///// <summary>
        ///// 保存顾客方法:add & update
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="name"></param>
        ///// <param name="email"></param>
        ///// <param name="birthDate"></param>
        //public void saveCustomer(string id, string name, string email, string birthDate)
        //{
        //    Customer customer = CustomerDao.GetCustomer(id);
        //    if (customer == null)
        //    {
        //        customer = new Customer
        //        {
        //            Id = id
        //        };
        //    }

        //    if (name != null)
        //    {
        //        customer.Name = name;
        //    }
        //    if (email != null)
        //    {
        //        customer.Email = email;
        //    }

        //    //...还有其他属性

        //    CustomerDao.SaveCustomer(customer);
        //}
    }
}
