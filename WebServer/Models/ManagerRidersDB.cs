using System.Linq;

namespace WebServer.Models
{
    public class ManagerRidersDB
    {
    
        readonly ModelBazyDataContext db = new ModelBazyDataContext();
        public ManagerRidersDB()
        { 
        }
        /// <summary>
        /// Return array of Riders
        /// </summary>
        /// <returns></returns>
        public Rider[] PassRiders()
        {
            return db.Rider.ToArray();
        }

        public void Edit(Rider toEdit)
        {

            Rider r = db.Rider.FirstOrDefault(x => x.id_rider == toEdit.id_rider);
            r.firstName = toEdit.firstName;
            r.lastName = toEdit.lastName;
            r.nationality = toEdit.nationality;
            r.height = toEdit.height;
            r.weight = toEdit.weight;
            db.SubmitChanges();
        }

        public void SetTeam(int idRider, int idTeam)
        {
            Rider r = db.Rider.FirstOrDefault(x => x.id_rider == idRider);
            r.id_team = idTeam;
            db.SubmitChanges();
        }
        /// <summary>
        /// Find Rider with specific id and remove it from database
        /// </summary>
        /// <param name="id">Rider id</param>
        public void Remove(int id)
        {
            Rider r = db.Rider.FirstOrDefault(x => x.id_rider == id);
            db.Rider.DeleteOnSubmit(r);
            db.SubmitChanges();
           
        }
        /// <summary>
        /// Create Rider in database
        /// </summary>
        /// <param name="r">Pass object of a class Rider</param>
        public void Create(Rider r)
        {
            db.Rider.InsertOnSubmit(r);
            db.SubmitChanges();
        }
        public Rider PassRider(int id)
        {
            return db.Rider.FirstOrDefault(x => x.id_rider == id);

        }

    }
}
