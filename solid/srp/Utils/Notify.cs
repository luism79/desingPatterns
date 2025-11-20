using srp.Model;

namespace srp.Utils
{
    internal class Notify
    {
        private void ExecuteNotify(Client client)
        {
            throw new Exception("Método em contrução!");
        }
        public Notify(Client client)
        { 
            try
            {
                ExecuteNotify(client);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
