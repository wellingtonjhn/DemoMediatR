using FluentValidation;

namespace DemoMediatR.Application.Commands.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUser>
    {
        public CreateUserValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("O Nome é obrigatório");

            RuleFor(a => a.Email)
                .EmailAddress()
                .WithMessage("E-mail inválido");

            RuleFor(a => a.Password)
                .NotEmpty()
                .WithMessage("A Senha é obrigatória");

            RuleFor(a => a.ConfirmPassword)
                .NotEmpty()
                .WithMessage("A Confirmação de Senha é obrigatória");

            RuleFor(a => a.ConfirmPassword)
                .Equal(b=> b.Password)
                .WithMessage("As Senhas não conferem");
        }
    }
}