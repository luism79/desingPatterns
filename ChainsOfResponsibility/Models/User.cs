using ChainsOfResponsibility.Models.Interface;

namespace ChainsOfResponsibility.Models
{
    internal class User : IUser
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
