using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPoliza
{
    public partial class HomePoliza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            updateGridView();
        }
        public void updateGridView()
        {
            WSDBPoliza.BDPolizaSoapClient ws = new WSDBPoliza.BDPolizaSoapClient();

            DataSet ds = ws.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            updateGridView();
        }
    }
}