using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client; // ODP.NET Oracle managed provider
namespace WSDBPoliza
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class BDPoliza : System.Web.Services.WebService
    {
        public OracleConnection GetConnection()
        {
            string connection = System.Configuration.ConfigurationManager.AppSettings["connectionString"].ToString();

            return new OracleConnection(connection);
        }

        [WebMethod]
        public DataSet GetData()
        {
            OracleConnection cn = new OracleConnection();
            OracleCommand dbCommand = cn.CreateCommand();
            DataSet dataset = new DataSet();

            cn = GetConnection();

            dbCommand.CommandText = "SELECT * FROM POLIZASEGURO";
            dbCommand.CommandType = CommandType.Text;

            try
            {
                dbCommand.Connection = cn;
                OracleDataAdapter adapter = new OracleDataAdapter(dbCommand);
                adapter.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                dbCommand.Dispose();
                cn.Dispose();
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                dbCommand.Dispose();
                cn.Dispose();
            }
        }
    }
}
