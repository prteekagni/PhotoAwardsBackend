using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotoAwards.Models;
using PhotoAwards.Repository.Contests;



namespace PhotoAwards.ViewModels
{
    public class ContestsViewModel
    {
        #region Private Variables 
        public IContestsRepository _repo { get; set; }
        
        #endregion
        public ContestsViewModel(IContestsRepository repo)
        {
            this._repo = repo;
        }
    
        public async Task<ContestsModel> Create(ContestsModel data)
        {
            data.ID = Guid.NewGuid();
            var result = await this._repo.Add(data);
            // if(result !=null && data.Logo!=null){
            //      var img =  await this._imgRepo.Find(data.Logo.ID.ToString());
            //      if(img !=null){
            //          img.RefrenceID = data.ID;
            //      }
            //     await this._imgRepo.Update(img);
            //     data.Logo = img;
            // }

            //this._imgRepo.Add()

            return result;
        }

        public async Task<List<ContestsModel>> GetContestss()
        {
            return await this._repo.GetAll() as List<ContestsModel>;
        }

        public async Task<ContestsModel> GetContestsById(string id)
        {
            return await this._repo.Find(id);
        }

        public async Task<ContestsModel> UpdateContests(Guid id, ContestsModel model)
        {
            model.ID = id;
            return await this._repo.Update(model);
        }
        public async Task<ContestsModel> DeleteContests(string id)
        {
            return await this._repo.Remove(id);
        }

        public async Task<IEnumerable<ContestsModel>> GetContestsByType(string key)
        {
            return await this._repo.GetContestsByType(key);
        }
    }
}