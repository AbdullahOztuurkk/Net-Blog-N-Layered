using System.Text.RegularExpressions;
using BlogWebUI.Entities.Concrete;
using FluentValidation;

namespace BlogWebUI.Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.Surname).NotEmpty();
            RuleFor(m => m.About).MaximumLength(800).WithMessage("Hakkında bölümü 800 karakterden fazla olamaz.");
            RuleFor(n => n.Mail).Must(RegexMail).WithMessage("Geçerli bir mail girmediniz.");
        }

        private bool RegexMail(string arg)
        {
            Regex regex=new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(arg);
        }
    }
}
