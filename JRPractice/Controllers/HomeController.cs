using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace JRPractice.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult studentList()
        {
            string data ;
            SqlCommand cmd = new SqlCommand("Get_Student_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            data = JsonConvert.SerializeObject(dt);
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}