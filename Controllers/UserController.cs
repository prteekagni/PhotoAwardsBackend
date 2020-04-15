using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoAwards.Models;
using PhotoAwards.Repository.Users;
using PhotoAwards.ViewModels;
using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService;
using PhotoAwards.Helper;

namespace PhotoAwards.Controller
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        #region Private Property
        private IUser _repo;
        private UserViewModel uservm;


        public UserController(IUser repo)
        {
            // AmazonSimpleNotificationServiceClient snsClient = new AmazonSimpleNotificationServiceClient(Amazon.RegionEndpoint.APSouth1);
            // SMSHelper.SendSms("+918851610111", "This is a message from controller");
            this._repo = repo;
            this.uservm = new UserViewModel(_repo);
        }


        #endregion

         [HttpGet]
        public async Task<IActionResult> Get()
        {
            Console.WriteLine("Display");
            return Ok(await this.uservm.GetUsers());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UserModel value)
        {
            Console.WriteLine("Display" + value.loggedVia);
            return Ok(await this.uservm.Create(value));
        }
    }
}