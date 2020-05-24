using System;
using BlogWebUI.Entities.Concrete;
using FluentValidation;

namespace BlogWebUI.Business.ValidationRules.FluentValidation
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(n => n.Keywords).NotEmpty();
            RuleFor(n => n.Content).MaximumLength(1200).
                MinimumLength(10).WithMessage("İçerik alanı 1200 karakterden fazla ve 10 karakterden az olamaz.");
            RuleFor(n => n.CreateDate).NotEmpty().WithMessage("Tarih alanı boş bırakılamaz");
            RuleFor(m => m.CreateDate).Must(n => n.Date < DateTime.Now.Date).WithMessage("Kayıt Tarihi ileri bir zamanda gerçekleşemez.");
            RuleFor(m => m.Title).NotEmpty().WithMessage("Başlık Alanı boş bırakılamaz");
        }
    }
}
