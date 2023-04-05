using EXC.API.Interfaces;
using EXC.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserRegisterController : ControllerBase
    {

        public IUserRegister _repository { get; }
        public readonly ILogger<UserRegisterController> _log;
        public UserRegisterController(IUserRegister repository, ILogger<UserRegisterController> log)
        {
            _repository = repository;
            _log = log;
        }
        [Route("InsertUpdateUserRegister")]
        [HttpPost]
        public int InsertUpdateUserRegister(UserRegister model)
        {
            var validItems = -111;
            try
            {
                validItems = _repository.InsertUpdateUserRegister(model);
                if (validItems != 0)
                {
                    return validItems;
                }
            }
            catch (Exception ex)
            {
                //_log.LogInformation(ex.InnerException.ToString());
            }
            return validItems;
        }

        [Route("LoadUserRegisterDetails")]
        [HttpPost]
        //public async Task ActionResult<UserRegisterList> LoadUserRegisterDetails(UserRegisterGrid model)
        //public ActionResult<UserRegisterList> LoadUserRegisterDetails(UserRegisterGrid model)
        //{
        //    var data = _repository.LoadUserRegisterDetails(model));
        //    return data;

        //}

        public async Task<List<UserRegisterList>> LoadUserRegisterDetails(UserRegisterGrid model)
        {
            var data = await Task.Run(() => _repository.LoadUserRegisterDetails(model));
            return data;
        }

    }
}
