using PhotoAwards.Models;
using System.Threading.Tasks;


namespace PhotoAwards.Repository.Contests
{
    public interface IContestsRepository : IBaseRepository<ContestsModel>
    {
        // Task <AdsModel> GetAdsByCategory(string _value);
    }
}