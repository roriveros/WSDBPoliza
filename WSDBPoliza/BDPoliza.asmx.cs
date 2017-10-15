using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
namespace WSDBPoliza
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class BDPoliza : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=RODRIGOTHRASH; Initial Catalog=rodrigoontour; Integrated Security=True; user=c##pablo; password=pablo1234;";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM POLIZASEGURO", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
