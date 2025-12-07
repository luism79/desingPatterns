using ChainsOfResponsibility.Models.Interface;

namespace ChainsOfResponsibility.Middlewares
{
    internal class CheckPasswordMiddleware : Middleware
    {
        private Boolean IsCommonPasswrod(string password)
        {
            var commonPassword = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "123456", "1234567", "12345678", "123456789",
                "password", "admin"
            };

            return commonPassword.Contains(password);
        }

        public override bool Check(IUser user)
        {
            if (IsCommonPasswrod(user.Password))
                Console.WriteLine($"Atenção {user.Name}!!!\n" +
                                  "Senha é de nível muito fraca!\n" +
                                  "Recomendamos que a sua senha seja alterada contento letras, números e caracteres especiais.\n");

            return CheckNext(user);
        }
    }
}
