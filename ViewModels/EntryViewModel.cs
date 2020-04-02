using PhotoAwards.Models;
using PhotoAwards.Repository.Entries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoAwards.ViewModels
{
    public class EntryViewModel
    {
        #region Private Variables 
        public IEntry _repo { get; set; }
        
        #endregion
        public EntryViewModel(IEntry repo)
        {
            this._repo = repo;
        }
    
        public async Task<EntryModel> Create(EntryModel data)
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

        public async Task<List<EntryModel>> GetEnteriess()
        {
            return await this._repo.GetAll() as List<EntryModel>;
        }

        public async Task<EntryModel> GetEnteriesById(string id)
        {
            return await this._repo.Find(id);
        }

        public async Task<EntryModel> UpdateEnteries(Guid id, EntryModel model)
        {
            model.ID = id;
            return await this._repo.Update(model);
        }
        public async Task<EntryModel> DeleteEnteries(string id)
        {
            return await this._repo.Remove(id);
        }

        public async Task<IEnumerable<EntryModel>> GetEnteriesByType(string key)
        {
            return null;//await this._repo.GetEnteriesByType(key);
        }
    }
}