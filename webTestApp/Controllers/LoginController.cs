using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Windows;

namespace webTestApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Username, string Password)
        {
            if(AuthenticateAccount(Username, Password))
            {
                return View();
            }
            else
            {
                return View();
            }
        }
        //[HttpPost]
        //public JsonResult MyAction(UserViewModel UserModel)
        //{
            /* do something with your usermodel object */
           // UserModel.Name = "foo";
           // UserModel.Age = 5;

          //  return Json(UserModel, JsonRequestBehavior.AllowGet);
        //}
        public bool AuthenticateAccount(string username, string password)
        {
            string returned_username = null;
            string returned_password = null;
            
            string connectionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connectionString = "Data Source=(localdb)\\ProjectsV12;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False; Initial Catalog=IOT_Sensors; User ID =admin;Password =admin";
            sql = "Select name,password from CFG_CUSTOMER where name = '" + username + "'";
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                  {
                      returned_username = dataReader.GetString(0);
                      returned_password = dataReader.GetString(1);
                        
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write("Can not open connection ! ");
                Console.Write(ex.Message);
            }
            returned_username = returned_username.Trim();
            returned_password = returned_password.Trim();
            if ((password == returned_password) && (username == returned_username))
            {
                return true;
            }
            else return false;
        }
    }
}