using EXC.API.Interfaces;
using EXC.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Common Extension

        private readonly IUserRegister _icommonServices;
        public UserController(IUserRegister icommonServices)
        {
            _icommonServices = icommonServices;

        }

        #endregion


        // -- Get State Info -- //
        //#region Get State Info

        //[Route("GetUserAll")]
        //[HttpGet]
        //public async Task<List<UserRegisterList>> LoadUserRegisterDetails(UserRegister model)
        //{
        //    var data = await Task.Run(() => _icommonServices.LoadUserRegisterDetails(model));
        //    return data;
        //}

        //#endregion
    }
}
