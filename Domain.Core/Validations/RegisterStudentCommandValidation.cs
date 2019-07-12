using Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Validations
{
    /// <summary>
    /// 添加学生命令模型验证
    /// 继承 StudentValidation 基类
    /// </summary>
    public class RegisterStudentCommandValidation : StudentValidation<RegisterStudentCommand>
    {
        public RegisterStudentCommandValidation()
        {
            ValidateName();//验证姓名
            ValidateBirthDate();//验证年龄
            ValidateEmail();//验证邮箱
            //可以自定义增加新的验证
        }
    }
}
