using WebServer.Controllers;
using WebServer.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServer.Views
{

    public partial class ZawodnicyLista : System.Web.UI.Page
    {
        public object __o;

        public RiderView[] ListaRiderow;
        protected void Page_Load(object sender, EventArgs e)
        {
            RidersManager zm = new RidersManager();
            ListaRiderow =  zm.PassRiders();
            

        }
    }
}