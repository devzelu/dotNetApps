using System.Linq;
using WebServer.Models;
using WebServer.Views.ViewModels;

namespace WebServer.Controllers
{
    public class TeamsManager
    {
        readonly ManagerTeamsDB managerTeamsDB;

        public TeamsManager()
        {
            managerTeamsDB = new ManagerTeamsDB();
        }

        public TeamView[] PassTeams()
        {
            Team[] teamsDb= managerTeamsDB.PassTeams();

            return teamsDb.Select(x => new TeamView() { Id = x.id_team,TeamName = x.name}).ToArray();
        }
    }
}