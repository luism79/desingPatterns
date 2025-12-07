using ChainsOfResponsibility.Models.Interface;

namespace ChainsOfResponsibility.Middlewares
{
    internal abstract class Middleware
    {
        private Middleware? _next;

        protected Boolean CheckNext(IUser user)
        {
            if (_next == null) 
                return true;
            
            return _next.Check(user);
        }

        public Middleware LinkWith(Middleware next)
        {
            _next = next;

            return next;
        }

        public abstract Boolean Check(IUser user);
    }
}
