using System.Threading.Tasks;
using DemoMediatR.Application.Domain.Models;

namespace DemoMediatR.Application.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task Save(User user);
    }
}