using PhotoAwards.Models;
using System;
using System.Threading.Tasks;

namespace PhotoAwards.Repository.Entries
{
    public interface IEntry : IBaseRepository<EntryModel>
    {
        Task<object> AddVote(VotingModel vote);
        Task<object> BoostPost(Guid EntryID);
    }
}
