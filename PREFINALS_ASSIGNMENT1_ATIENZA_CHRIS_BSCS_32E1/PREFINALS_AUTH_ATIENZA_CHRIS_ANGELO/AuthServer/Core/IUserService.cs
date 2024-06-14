namespace AuthServer.Core
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
