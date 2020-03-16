using PhotoAwards.Models;
using System.Threading.Tasks;


namespace PhotoAwards.Repository.Enteries
{
    public interface IEnteriesRepository : IBaseRepository<EnteriesModel>
    {
        // Task <AdsModel> GetAdsByCategory(string _value);
    }
}