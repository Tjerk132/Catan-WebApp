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
        SqlConnection conn = new SqlConnection
        (
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\tjerk\source\repos\Catan-WebApp\Catan Asp._Net\App_Data\Database.mdf;
            Integrated Security=True"
        );
        // GET: Catan
        public ActionResult Index()
        {
            CatanViewmodel viewmodel = new CatanViewmodel();
            viewmodel.Saves = new List<Save>();
            using (conn)
            {
                conn.Open();
                string query = "SELECT * FROM [Saves]";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                conn.Close();
                foreach (DataRow dr in dtResult.Rows)
                {
                    Save save = new Save();

                    save.Name = dr[1].ToString();

                    DateTime.TryParse(dr[2].ToString(), out DateTime Date);
                    save.Time = Date;

                    viewmodel.Saves.Add(save);
                }
                return View(viewmodel);
            }
        }
    }
}