using EXC.API.Interfaces;
using EXC.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}




        //public IUserRegister _repository { get; }
        //public readonly ILogger<UserRegisterController> _log;
        //public WeatherForecastController(IUserRegister repository, ILogger<UserRegisterController> log)
        //{
        //    _repository = repository;
        //    _log = log;
        //}

        //[HttpPost]
        //public int InsertUpdateUserRegister(UserRegister model)
        //{
        //    var validItems = -111;
        //    try
        //    {
        //        validItems = _repository.InsertUpdateUserRegister(model);
        //        if (validItems != 0)
        //        {
        //            return validItems;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //_log.LogInformation(ex.InnerException.ToString());
        //    }
        //    return validItems;
        //}
        //#region Load User Register Details
        //[HttpGet]
        //public ActionResult<UserRegisterList> LoadUserRegisterDetails(UserRegister model)
        //{
        //    var validItems = _repository.LoadUserRegisterDetails(model);
        //    if (validItems != null)
        //    {
        //        return Ok(validItems);
        //    }
        //    return NotFound();
        //}
        //#endregion
    }
}
