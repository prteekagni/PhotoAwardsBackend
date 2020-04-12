using System.Collections.Generic;
using System.Threading.Tasks;
using PhotoAwards.Models;

namespace PhotoAwards.Repository.Contests
{
    public interface IContest : IBaseRepository<ContestModel>
    {
        Task<List<ContestModel>> GetContestsByStaus(string status);
    }
}
