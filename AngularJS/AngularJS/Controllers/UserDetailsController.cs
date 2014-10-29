using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS.Models;
namespace AngularJS.Controllers
{
    public class UserDetailsController : Controller
    {
        //
        // GET: /UserDetails/
        asapEntities dbcontext = new asapEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayUsers()
        {
            UserModel Userobj = new UserModel();
            Userobj.AllUsersList = (from usr in dbcontext.tblUsers
                                    select new UserModel
                                    {
                                        UserId=usr.UserID,
                                        Username=usr.Username,
                                        FirstName=usr.Firstname,
                                        LastName=usr.Lastname,
                                        Address1=usr.Address1,
                                        Email=usr.Email,
                                       
                                    }).ToList();
            return View(Userobj);
           // return Json(Userobj,JsonRequestBehavior.AllowGet);
        }
        public ActionResult Userinformation()
        {
            UserModel Userobj = new UserModel();
            Userobj.AllUsersList = (from usr in dbcontext.tblUsers
                                    select new UserModel
                                    {
                                        UserId = usr.UserID,
                                        Username = usr.Username,
                                        FirstName = usr.Firstname,
                                        LastName = usr.Lastname,
                                        Address1 = usr.Address1,
                                        Email = usr.Email,

                                    }).ToList();
            return View(Userobj);
                
        }
 

    }
}
