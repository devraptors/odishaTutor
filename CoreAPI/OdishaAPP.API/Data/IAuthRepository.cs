using System.Threading.Tasks;
namespace OdishaAPP.API.Models
{
    public interface IAuthRepository
    {
       //  Task<User> Register (User user,string password);

         //Task<User> Login (string Username, string Password);

         Task<bool> UserExists (string username);
    }
}