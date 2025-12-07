using ChainsOfResponsibility.Models.Interface;
using ChainsOfResponsibility.Servers;

namespace ChainsOfResponsibility.Middlewares
{
    internal class CheckUserMiddleware : Middleware
    {
        private Server? _server;

        private Boolean IsValidEmail(IUser user)
        {
            var result = _server!.HasEmail(user.Email);
            if (!result)
                throw new Exception($"Não foi possível localizar o e-mail digitado '{user.Email}'.");
            
            return result;
        }

        private Boolean IsValidPassword(IUser user)
        {
            var result = _server!.IsValidPassword(user);
            if (!result)
                throw new Exception($"Usuário {user.Name}\n" +
                                    "Senha digitada incorretamente!");

            return result;
        }

        private Boolean CheckInfoUser(IUser user)
        {
            return IsValidEmail(user) && IsValidPassword(user);
        }

        public CheckUserMiddleware(Server server) => _server = server;
        
        public override bool Check(IUser user)
        {
            if (user == null)
               throw new ArgumentNullException(nameof(user));

            try
            {
                CheckInfoUser(user);

                return CheckNext(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
