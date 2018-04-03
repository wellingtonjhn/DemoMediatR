using DemoMediatR.Application.Core;
using MediatR;

namespace DemoMediatR.Application.Commands
{
    public class CreateUser : IRequest<Response>
    {
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }
        public string ConfirmPassword { get; }

        public CreateUser(string name, string email, string password, string confirmPassword)
        {
            Name = name;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}