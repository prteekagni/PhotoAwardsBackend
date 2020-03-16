using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotoAwards.Models;
using PhotoAwards.Repository.Enteries;



namespace PhotoAwards.ViewModels
{
    public class EnteriesViewModel
    {
        #region Private Variables 
        public IEnteriesRepository _repo { get; set; }
        
        #endregion
        public EnteriesViewModel(IEnteriesRepository repo)
        {
            this._repo = repo;
        }
    
        public async Task<EnteriesModel> Create(EnteriesModel data)
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

        public async Task<List<EnteriesModel>> GetEnteriess()
        {
            return await this._repo.GetAll() as List<EnteriesModel>;
        }

        public async Task<EnteriesModel> GetEnteriesById(string id)
        {
            return await this._repo.Find(id);
        }

        public async Task<EnteriesModel> UpdateEnteries(Guid id, EnteriesModel model)
        {
            model.ID = id;
            return await this._repo.Update(model);
        }
        public async Task<EnteriesModel> DeleteEnteries(string id)
        {
            return await this._repo.Remove(id);
        }

        public async Task<IEnumerable<EnteriesModel>> GetEnteriesByType(string key)
        {
            return await this._repo.GetEnteriesByType(key);
        }
    }
}