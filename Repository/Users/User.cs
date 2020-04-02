using PhotoAwards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoAwards.Repository.Users
{
    public class User : BaseRepository<UserModel>,IUser
    {
    }
}
