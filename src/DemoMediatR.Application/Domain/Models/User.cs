namespace DemoMediatR.Application.Domain.Models
{
    public class User
    {
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}