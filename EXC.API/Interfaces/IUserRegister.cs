using EXC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXC.API.Interfaces
{
    public interface IUserRegister
    {
        public int InsertUpdateUserRegister(UserRegister model);
        List<UserRegisterList> LoadUserRegisterDetails(UserRegisterGrid model);
    }
}
