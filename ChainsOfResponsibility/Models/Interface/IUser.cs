namespace ChainsOfResponsibility.Models.Interface
{
    internal interface IUser
    {
        string Name { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
