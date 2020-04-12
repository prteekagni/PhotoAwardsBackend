using Microsoft.EntityFrameworkCore;
using PhotoAwards.Context;
using PhotoAwards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PhotoAwards.Repository.Contests
{
    public class Contest : IContest
    {
        private AppDbContext context;

        public Contest(AppDbContext context){
            this.context = context;
        }
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

        public async Task<List<ContestModel>> GetContestsByStaus(string status)
        {
             var source = await this.context.Contest
                      .Where(d => d.Status == status)
                      .ToListAsync();


                      return source;

            // throw new NotImplementedException();
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
