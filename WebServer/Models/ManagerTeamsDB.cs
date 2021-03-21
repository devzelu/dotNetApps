using System.Linq;

namespace WebServer.Models
{
    public class ManagerTeamsDB
    {
        public Team[] PassTeams()
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            return db.Team.ToArray();
        }
    }
}