using System;
using System.Web.Script.Serialization;
using WebServer.Controllers;

namespace WebServer.API
{
    public partial class RidersPassJson : System.Web.UI.Page
    {
        //This page give JSON string with all Riders in database
        protected void Page_Load(object sender, EventArgs e)
        {
            
            RidersManager rm = new RidersManager();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(rm.PassRiders());

            Response.Write(json);
            
        }
    }
}