using Bridge.Platform.Inteface;

namespace Bridge.Platform.Model
{
    internal class BasePlatform : IPlatform
    {
        protected TypePlatform Platform;

        private bool IsValidPlatform()
        {
            return PlatformInfo.IsValidPlatfomr(Platform);
        }

        private string GetNamePlatform() => PlatformInfo.CaptionPlatform(Platform);


        protected void Initialize()
        {
            ConfigureRMTP();
        }

        public string PlatformName
        { 
            get => GetNamePlatform();
        }

        public bool Authenticate()
        {
            return IsValidPlatform();
        }

        public void ConfigureRMTP()
        {
            if (Authenticate())
            {
                Console.WriteLine($"{PlatformName}: Autenticação realizada com sucesso!\n" +
                                  $"{PlatformName}: Configurando servidor RMTP.");
            }
            else
            {
                Console.WriteLine($"{PlatformName}: Ocorreu uma falha na autenticação!\n" +
                                  $"{PlatformName}: Não foi possível configurar o servidor.");
            }
        }
    }
}
