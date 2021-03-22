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
            Team[] teamsTab = managerTeamsDB.PassTeams();
            TeamView[] tab = new TeamView[teamsTab.Length];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = ConvertToTeamView(teamsTab[i]);

            return tab;
        }

        private TeamView ConvertToTeamView(Team team)
        {
            TeamView teamView = new TeamView()
            {
                Id = team.id_team,
                TeamName = team.name
            };
            return teamView;


        }
    }
}