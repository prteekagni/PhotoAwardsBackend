using PhotoAwards.Models;
using System.Threading.Tasks;


namespace PhotoAwards.Repository.Users
{
    public interface IUsersRepository : IBaseRepository<UsersModel>
    {
        // Task <AdsModel> GetAdsByCategory(string _value);
    }
}