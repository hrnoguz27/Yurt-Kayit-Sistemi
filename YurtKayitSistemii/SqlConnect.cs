using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace YurtKayitSistemi
{
    public class SqlConnect
    {
        public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=your data source;Initial Catalog=YurtOtomasyonu;User ID=your_id;Password=your_pass");
            conn.Open();
            return conn;
        }
    }
}
