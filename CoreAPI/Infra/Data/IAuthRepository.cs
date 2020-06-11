using System.Threading.Tasks;
namespace Infrastructure
{
    public interface IAuthRepository
    {
       //  Task<User> Register (User user,string password);

         //Task<User> Login (string Username, string Password);

         Task<bool> UserExists (string username);
    }
}