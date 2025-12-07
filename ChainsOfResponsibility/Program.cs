using ChainsOfResponsibility.Middlewares;
using ChainsOfResponsibility.Models;
using ChainsOfResponsibility.Models.Interface;
using ChainsOfResponsibility.Servers;

namespace ChainsOfResponsibility
{
    internal class Program
    {
        static private Server? _server;

        static void Init()
        {

            _server = new Server();

            _server.RegisterUser(new User()
                { 
                    Name = "Master",
                    Email = "master.udemy@hotmail.com",
                    Password = "pw@test!123456"
                }
            );

            _server.RegisterUser(new User()
                {
                    Name = "Jaqueline",
                    Email = "jaque@hotmail.com",
                    Password = "123456"
                }
            );
            
            Middleware middleware = new CheckUserMiddleware(_server);
            
            middleware
                .LinkWith(new CheckPermissionMiddleware())
                .LinkWith(new CheckPasswordMiddleware());

            _server.Middleware = middleware;
        }

        static void Main(string[] args)
        {
            Init();

            IUser userAdm = new User()
            {
                Name = "Master",
                Email = "master.udemy@hotmail.com",
                Password = "pw@test!123456"
            };

            IUser user1 = new User()
            {
                Name = "Jaqueline",
                Email = "jaque@hotmail.com",
                Password = "123456"
            };

            IUser user2 = new User()
            {
                Name = "Jaqueline",
                Email = "jaque.ffddf@hotmail.com",
                Password = "123456"
            };

            _server!.Login(user1);

            Console.ReadKey();
        }
    }
}