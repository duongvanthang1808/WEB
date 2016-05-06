using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginDemo.Areas.Admin.Models.Model;
using LoginDemo.Areas.Admin.Models.DAO;
using LoginDemo.Common;
namespace LoginDemo.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.checkLogin(model.UserName, model.PassWord);

                if(result)
                {
                    
                    
                    var userSession = new UserLogin();

                    userSession.UserName = model.UserName;
                    userSession.PassWord = model.PassWord;

                    Session.Add(Common.CommonConstants.USER_SESSION, userSession);

                    return RedirectToAction("Index", "Home");
                }

            }else
            {
                ModelState.AddModelError("", "Dang nhap khong thanh cong");
            }

            return View("Index");
        }
    }
}
