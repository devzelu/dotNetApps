using System;
using WebServer.Controllers;
using WebServer.Views.ViewModels;

namespace WebServer.Views
{
    public partial class TeamsTable : System.Web.UI.Page
    {
        public TeamView[] TeamsList;
        protected void Page_Load(object sender, EventArgs e)
        {
            TeamsManager teamsManager = new TeamsManager();
            TeamsList = teamsManager.PassTeams();
        }


    }
}