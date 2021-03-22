using System.Linq;

namespace WebServer.Models
{
    public class ManagerTeamsDB
    {
        readonly ModelBazyDataContext db = new ModelBazyDataContext();
        public Team[] PassTeams()
        {
             return db.Team.ToArray();
        }
        public Team PassTeam(int? id)
        {
            return db.Team.FirstOrDefault(x => x.id_team == id);
        }
    }
}