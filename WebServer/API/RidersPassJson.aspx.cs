using System;
using System.Web.Script.Serialization;
using WebServer.Controllers;

namespace WebServer.API
{
    public partial class RidersPassJson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            RidersManager rm = new RidersManager();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(rm.PassRiders());

            Response.Write(json);
            
        }
    }
}