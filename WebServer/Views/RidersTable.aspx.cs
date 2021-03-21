using System;
using WebServer.Controllers;
using WebServer.Views.ViewModels;

namespace WebServer.Views
{
    public partial class RidersTable : System.Web.UI.Page
    {
        public RiderView[] RidersList;
        protected void Page_Load(object sender, EventArgs e)
        {
            RidersManager rl = new RidersManager();
            RidersList = rl.PassRiders();
        }


    }
}