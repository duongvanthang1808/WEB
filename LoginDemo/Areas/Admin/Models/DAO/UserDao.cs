using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginDemo.Areas.Admin.Models.Entities;
namespace LoginDemo.Areas.Admin.Models.DAO
{
    public class UserDao
    {
        DbOnlineShop context = null;

        public UserDao()
        {
            context = new DbOnlineShop();
        }
       
        public bool checkLogin(string user, string password)
        {
            var result = context.Accounts.Count(x => x.UserName == user && x.PassWord == password);

            if (result > 0) return true;
            else return false;
        }
    }
}