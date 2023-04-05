using Dapper;
using EXC.API.Interfaces;
using EXC.API.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EXC.API.Data_DB
{
    public class DataUserRegister : IUserRegister
    {
        private readonly string _connectionString;

        public class Queries
        {
            public static string InsertUpdateUserRegister = "uspUserRegister";
            public static string LoadUserRegisterDetails = "uspLoadUserDetails";
        }
        public DataUserRegister(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("IMF001");
        }

        #region Insert Update FAQSectionQuestion
        public int InsertUpdateUserRegister(UserRegister model)
        {
            var ReturnStatus = -404;
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var EventParam = new Dapper.DynamicParameters();
                    EventParam.Add("@UserRegisterID", model.UserRegisterID);
                    EventParam.Add("@FirstName", model.FirstName);
                    EventParam.Add("@LastName", model.LastName);
                    EventParam.Add("@Email", model.Email);
                    EventParam.Add("@Phonenumber", model.Phonenumber);
                    EventParam.Add("@Address", model.Address);
                    EventParam.Add("@City", model.City);
                    EventParam.Add("@State", "State");
                    EventParam.Add("@Country", model.Country);
                    EventParam.Add("@PostalCode", model.PostalCode);
                    EventParam.Add("@CreatedBy", model.CreatedBy);
                    EventParam.Add("@Latitude", model.Latitude);
                    EventParam.Add("@Longtitude", model.Longtitude);
                    EventParam.Add("@ReturnStatus", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute(Queries.InsertUpdateUserRegister, EventParam, commandType: CommandType.StoredProcedure);
                    ReturnStatus = EventParam.Get<int>("@ReturnStatus");
                    return ReturnStatus;
                }
            }
            catch (Exception ex)
            {
                return ReturnStatus;
            }
        }
        #endregion

        public List<UserRegisterList> LoadUserRegisterDetails(UserRegisterGrid model)
        {
            List<UserRegisterList> userRegisterList = new List<UserRegisterList>();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var EventParam = new DynamicParameters();
                    EventParam.Add("@UserRegisterID", model.UserRegisterID);
                    EventParam.Add("@FirstName", ReplaceDbNullWithString(model.FirstName));
                    EventParam.Add("@LastName", ReplaceDbNullWithString(model.LastName));
                    EventParam.Add("@Email", ReplaceDbNullWithString(model.Email));
                    EventParam.Add("@Phonenumber", ReplaceDbNullWithString(model.Phonenumber));
                    EventParam.Add("@Address", ReplaceDbNullWithString(model.Address));
                    EventParam.Add("@City", ReplaceDbNullWithString(model.City));
                    EventParam.Add("@State", ReplaceDbNullWithString(model.State));
                    EventParam.Add("@Country", ReplaceDbNullWithString(model.Country));
                    EventParam.Add("@PostalCode", ReplaceDbNullWithString(model.PostalCode));
                    EventParam.Add("@PageNumber", model.PageNo);
                    EventParam.Add("@RecordsPerPage", model.RecordsPerPage);
                    EventParam.Add("@SortColumn", model.SortColumn);
                    userRegisterList = connection.Query<UserRegisterList>(Queries.LoadUserRegisterDetails, EventParam, commandType: System.Data.CommandType.StoredProcedure).ToList();
                    return userRegisterList;
                }
            }
            catch (Exception ex)
            {
                //expLog.LogData(ex);
                return userRegisterList;
            }
        }

        public static string ReplaceDbNullWithString(object value)
        {
            if ((value == DBNull.Value) || (value == null))
            {
                return string.Empty;
            }
            return value.ToString().Trim();
        }

    }
}
