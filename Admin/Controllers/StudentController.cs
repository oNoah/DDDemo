using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModels;
using Domain.Core.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
   

    public class StudentController : Controller
    {
        private readonly IStudentAppService _studentAppService;

        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void Register(StudentViewModel StudentViewModel)
        {
             _studentAppService.Register(StudentViewModel); 
        }

        // POST: Student/Create
        // 方法
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel studentViewModel)
        {
            try
            {
                ViewBag.ErrorData = null;

                // 视图模型验证
                if (!ModelState.IsValid)
                    return View(studentViewModel);

                //// 添加命令验证
                //RegisterStudentCommand registerStudentCommand = new RegisterStudentCommand(studentViewModel.Name,
                //    studentViewModel.Email, studentViewModel.BirthDate, "");

                //// 验证失败
                //if (!registerStudentCommand.IsValid())
                //{
                //    List<string> errorInfo= new List<string>();
                //    foreach(var error in registerStudentCommand.ValidationResult.Errors)
                //    {
                //        errorInfo.Add(error.ErrorMessage);
                //    }
                //    //对错误进行记录，还需要抛给前台
                //    ViewBag.ErrorData = errorInfo;
                //    return View(studentViewModel);
                //}

                // 执行添加方法
                _studentAppService.Register(studentViewModel);

                ViewBag.Sucesso = "Student Registered!";

                return View(studentViewModel);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }
    }
}