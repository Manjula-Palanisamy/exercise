using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXC.API.Models
{
    public class UserRegister
    {
        public int UserRegisterID { get; set; }
        public string EncryptedUserRegisterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public int CreatedBy { get; set; }
        public int ReturnMessage { get; set; }
        public int ReturnStatus { get; set; }
        public List<UserRegisterList> UserRegisterList { get; set; }
        public int PageNo { get; set; }
        public int RecordsPerPage { get; set; }
        public string SortColumn { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
    }

    public class UserRegisterList
    {
        public int UserRegisterID { get; set; }
        public string EncryptedUserRegisterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int CreatedBy { get; set; }
        public int PageNo { get; set; }
        public int RecordsPerPage { get; set; }
        public string SortColumn { get; set; }
        public int? TotalRecordCount { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
    }

    public class UserRegisterGrid
    {
        public int UserRegisterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int CreatedBy { get; set; }
        //public List<UserRegisterList> UserRegisterList { get; set; }
        public int PageNo { get; set; }
        public int RecordsPerPage { get; set; }
        public string SortColumn { get; set; }
    }
}
