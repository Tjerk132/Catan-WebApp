using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catan_Asp._Net.Views.Catan;
using Catan_Asp._Net.Models.Viewmodel;
using Catan_Asp._Net.Models;
using System.Data.SqlClient;
using System.Data;

namespace Catan_Asp._Net.Controllers
{
    public class CatanController : Controller
    {
        // GET: Catan
        public ActionResult Index()
        {
            using (SqlConnection sqlCon = new SqlConnection
            (
                @"Server=studmysql01.fhict.local;
                database=dbi404906;
                UID=dbi404906;
                password=138751"
            ))

            {
                sqlCon.Open();
                string query = "SELECT * FROM myquests";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                CatanViewmodel viewmodel = new CatanViewmodel
                {
                    Saves = new List<Save>()
                };

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                DataTable dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                sqlCon.Close();
                foreach (DataRow dr in dtResult.Rows)
                {
                    Save save = new Save();

                    save.Name = dr[1].ToString();

                    DateTime.TryParse(dr[2].ToString(), out DateTime Date);
                    save.Time = Date;

                    viewmodel.Saves.Add(save);
                }
                //}
                return View(viewmodel);
            }
        }
    }
}