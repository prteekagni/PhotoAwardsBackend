using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotoAwards.Models;
using PhotoAwards.Repository.Contests;



namespace PhotoAwards.ViewModels
{
    public class ContestViewModel
    {
        #region Private Variables 
        public IContest _repo { get; set; }
        
        #endregion
        public ContestViewModel(IContest repo)
        {
            this._repo = repo;
        }
    
        public async Task<ContestModel> Create(ContestModel data)
        {
            data.ID = Guid.NewGuid();
            var result = await this._repo.Add(data);
            
            return result;
        }

        public async Task<List<ContestModel>> GetContests()
        {
            return await _repo.GetAll() as List<ContestModel>;
        }

        public async Task<ContestModel> GetContestsById(string id)
        {
            return await this._repo.Find(id);
        }

        public async Task<ContestModel> UpdateContests(Guid id, ContestModel model)
        {
            model.ID = id;
            return await this._repo.Update(model);
        }
        public async Task<ContestModel> DeleteContests(string id)
        {
            return await this._repo.Remove(id);
        }

        public async Task<IEnumerable<ContestModel>> GetContestsByStatus(string status)
        {
          return await this._repo.GetContestsByStaus(status);
        }

        
    }
}