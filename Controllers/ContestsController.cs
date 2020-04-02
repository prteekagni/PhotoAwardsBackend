using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoAwards.Models;
using PhotoAwards.Repository.Contests;
using PhotoAwards.ViewModels;

namespace PhotoAwards.Controller
{
    [Route("api/[controller])")]
    public class ContestsController : ControllerBase
    {
        #region Private Property
        private readonly IContest _repo;
        private ContestViewModel vm;
        public ContestsController(IContest repo)
        {
            this._repo = repo;
            this.vm = new ContestViewModel(_repo);
        }
        #endregion

        [HttpGet, AllowAnonymous]

        public async Task<IActionResult> Get()
        {

            var result = await vm.GetContests();
            return Ok(result);
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await this.vm.GetContestsById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ContestModel value)
        {
            return Ok(await vm.Create(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody]ContestModel value)
        {
            return Ok(await this.vm.UpdateContests(id, value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}"), AllowAnonymous]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await this.vm.DeleteContests(id));
        }
    }


}

