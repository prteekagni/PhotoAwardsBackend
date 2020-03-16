using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhotoAwards.Controller
{
   [Route("api/[controller])")]
    public class ContestsController: Controller{
 #region Private Property
        private IContestsRepository _repo;
        private ContestsViewModel vm;
        public ContestsController(IContestsRepository repo)
        {
            this._repo = repo;
            this.vm = new ContestsViewModel(this._repo);
        }
        #endregion

  [HttpGet, AllowAnonymous]

        public async Task<IActionResult> Get()
        {

            var result = await this.vm.GetContests();
            return Ok(result);
        }
        // GET api/values/5
        [HttpGet("{id}") ]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await this.vm.GetContestsById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ContestsModel value)
        {
            return Ok(await this.vm.Create(value));
        }

        // PUT api/values/5
        [HttpPut("{id}") ]
        public async Task<IActionResult> Put(Guid id, [FromBody]ContestsModel value)
        {
            return Ok(await this.vm.UpdateContests(id, value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}") , AllowAnonymous]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await this.vm.DeleteContests(id));
        }
    }


    }
    
