using System.Linq;

namespace WebServer.Models
{
    public class ManagerRidersDB
    {
    
        public ManagerRidersDB()
        { 
        }

        public Rider[] PassRiders()
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            return db.Rider.ToArray();
        }

        public void Edit(Rider toEdit)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();

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
            ModelBazyDataContext db = new ModelBazyDataContext();
            Rider r = db.Rider.FirstOrDefault(x => x.id_rider == idRider);
            r.id_team = idTeam;
            db.SubmitChanges();
        }

        public void Remove(int id)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            Rider r = db.Rider.FirstOrDefault(x => x.id_rider == id);
            db.Rider.DeleteOnSubmit(r);
            db.SubmitChanges();
           
        }

        public void Create(Rider r)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            db.Rider.InsertOnSubmit(r);
            db.SubmitChanges();
        }
        public Rider PassRider(int id)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            return db.Rider.FirstOrDefault(x => x.id_rider == id);

        }

    }
}
