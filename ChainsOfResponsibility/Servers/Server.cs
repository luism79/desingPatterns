using ChainsOfResponsibility.Middlewares;
using ChainsOfResponsibility.Models.Interface;

namespace ChainsOfResponsibility.Servers
{
    internal class Server
    {
        private Dictionary<string, IUser> _users = new Dictionary<string, IUser>();
        public Middleware? Middleware { get; set; }

        public Boolean Login(IUser user)
        {
            var result = Middleware!.Check(user);

            if (result)
            {
                Console.WriteLine("Usuário autorizado com sucesso!");
                Console.WriteLine($"Seja bem-vindo {user.Name}");
            }
            return result;
        }

        public void RegisterUser(IUser user)
        {
            _users[user.Email] = user;
        }

        public Boolean HasEmail(string email)
        {
            return _users.ContainsKey(key: email);
        }

        public Boolean IsValidPassword(IUser user)
        {
            IUser? value;

            _users.TryGetValue(user.Email, out value);

            return (value != null && value.Password.Equals(user.Password));
        }
    }
}
