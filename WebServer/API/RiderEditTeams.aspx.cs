﻿using System;
using System.Web.Script.Serialization;
using WebServer.Controllers;

namespace WebServer.API
{
    public partial class RiderEditTeams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string idRider = Request["idRider"];
            string idTeam = Request["idTeam"];
            if(!string.IsNullOrEmpty(idRider) && !string.IsNullOrEmpty(idTeam))
            {

                RidersManager rm = new RidersManager();
                rm.SetTeam(Convert.ToInt32(idRider),Convert.ToInt32(idTeam));
                
            }
            else
            {

            TeamsManager tm = new TeamsManager();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(tm.PassTeams());

            Response.Write(json);
            }
        }
    }
}