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
        public List<Save> GetSavesInfo()
        {
            List<Save> saves = new List<Save>();
            SqlConnection conn = new SqlConnection(

                @""
                );

            return saves;
        }
    }
}
