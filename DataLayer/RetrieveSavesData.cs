
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RetrieveSavesData
    {
        public List<Save> GetSavesInfo()
        {
            List<Save> saves = new List<Save>();
            try
            {
                //SqlConnection conn = new SqlConnection(
                //    @"Server=mssql.fhict.local;
                //    Database=dbi386599;
                //    User Id=dbi386599;
                //    Password=12345;"
                // );
                //using (conn)
                //{
                //    conn.Open();
                //    string query = "SELECT * FROM [Saves]";
                //    SqlCommand cmd = new SqlCommand(query, conn);
                //    DataTable dtResult = new DataTable();
                //    dtResult.Load(cmd.ExecuteReader());
                //    conn.Close();
                //    foreach (DataRow dr in dtResult.Rows)
                //    {
                //        Save save = new Save();

                //        save.Name = dr[1].ToString();

                //        DateTime.TryParse(dr[2].ToString(), out DateTime Time);
                //        save.Time = Time;

                //        saves.Add(save);
                //    }
                //}
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }         
            return saves;
        }
    }
}
