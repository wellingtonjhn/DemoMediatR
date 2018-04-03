using DemoMediatR.Application.Commands;
using DemoMediatR.Application.Core;
using DemoMediatR.Application.Domain.Interfaces;
using DemoMediatR.Application.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatR.Application.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUser, Response>
    {
        private readonly IUserRepository _repository;

        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var user = new User(request.Name, request.Email, request.Password);

            await _repository.Save(user);

            return new Response("Usuário criado com sucesso");
        }
    }
}