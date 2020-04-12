using PhotoAwards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PhotoAwards.Repository.Contests
{
    public class Contest : IContest
    {
        public Task<ContestModel> Add(ContestModel item)
        {
            throw new NotImplementedException();
        }

        public Task<ContestModel> Find(object key)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<ContestModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ContestModel> Remove(object Id)
        {
            throw new NotImplementedException();
        }

        public Task<ContestModel> Update(ContestModel item)
        {
            throw new NotImplementedException();
        }
    }
}
