using ChainsOfResponsibility.Models.Interface;

namespace ChainsOfResponsibility.Middlewares
{
    internal class CheckPermissionMiddleware : Middleware
    {
        const string DefaultUserAdm = "master.udemy@hotmail.com";
        public override bool Check(IUser user)
        {
            if (user.Email.Equals(DefaultUserAdm))
            {
                Console.WriteLine($"{user.Name}: Nível administrador");
            }

            return CheckNext(user);
        }
    }
}
