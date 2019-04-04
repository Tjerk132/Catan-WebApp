using Catan_Asp._Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataLayer
{
    public class RetrieveSavesData
    {
        public string Save(byte[] Image)
        {
           string Hash = "";
           SqlConnection conn = new SqlConnection(
                @"Server=mssql.fhict.local;
                Database=dbi386599;
                User Id=dbi386599;
                Password=12345;"
             );
            using (conn)
            {
                conn.Open();
                string query = "INSERT INTO Saves(Image) VALUES(@image) SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@image", Image);
                DataTable dtResult = new DataTable();
                dtResult.Load(cmd.ExecuteReader());
                conn.Close();
                foreach (DataRow dr in dtResult.Rows)
                {
                    Hash = dr[1].ToString();
                }

               
                return Hash;
            }
        }
        public List<Save> GetSavesInfo()
        {
            SqlConnection conn = new SqlConnection(
                @"Server=mssql.fhict.local;
                Database=dbi386599;
                User Id=dbi386599;
                Password=12345;"
             );
            List<Save> saves = new List<Save>();
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

                    DateTime.TryParse(dr[2].ToString(), out DateTime Time);
                    save.Time = Time;

                    saves.Add(save);
                }
            }
            return saves;
        }

    }
}
