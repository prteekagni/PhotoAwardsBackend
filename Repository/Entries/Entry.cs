using PhotoAwards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoAwards.Repository.Entries
{
    public class Entry : IEntry
    {
        public Task<EntryModel> Add(EntryModel item)
        {
            throw new NotImplementedException();
        }

        public Task<object> AddVote(VotingModel vote)
        {
            throw new NotImplementedException();
        }

        public Task<object> BoostPost(Guid EntryID)
        {
            throw new NotImplementedException();
        }

        public Task<EntryModel> Find(object key)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<EntryModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EntryModel> Remove(object Id)
        {
            throw new NotImplementedException();
        }

        public Task<EntryModel> Update(EntryModel item)
        {
            throw new NotImplementedException();
        }
    }
}
