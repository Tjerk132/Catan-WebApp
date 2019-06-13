using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RetrieveSavesData
    {
        SqlConnection conn = new SqlConnection
        (
            @"Server=mssql.fhict.local;
            Database=dbi386599;
            User Id=dbi386599;
            Password=12345;"
         );
        public List<Save> GetSavesInfo()
        {
            List<Save> saves = new List<Save>();
            using (conn)
            {

            }


            return saves;
        }
    }
}
