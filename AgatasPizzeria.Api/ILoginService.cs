namespace AgatasPizzeria.Api
{
    public interface ILoginService
    {
        bool Login(string userName, string password);
    }
}