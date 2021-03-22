using WebServer.Models;
using WebServer.Views.ViewModels;

namespace WebServer.Controllers
{


    public class RidersManager
    {
        readonly ManagerRidersDB managerRidersDB;

        public RidersManager()
        {
            managerRidersDB = new ManagerRidersDB();
        }
        /// <summary>
        /// Remove Rider
        /// </summary>
        /// <param name="id">Rider id</param>
        public void Remove(int id)
        {
            managerRidersDB.Remove(id);
        }

        public void Edit(RiderView edited)
        {
            Rider rdb = new Rider()
            {
                id_rider = edited.Id_Rider,
                id_team = edited.Id_Team,
                firstName = edited.FirstName,
                lastName = edited.LastName,
                nationality = edited.Nationality,
                height = edited.Height,
                weight = edited.Weight
            };

            managerRidersDB.Edit(rdb);

        }

        public void SetTeam(int idRider, int idTeam)
        {
            managerRidersDB.SetTeam(idRider, idTeam);
        }

        public void Save(RiderView created)
        {
            Rider rdb = new Rider()
            {
                id_team = created.Id_Team,
                firstName = created.FirstName,
                lastName = created.LastName,
                nationality = created.Nationality,
                height = created.Height,
                weight = created.Weight
            };

            managerRidersDB.Create(rdb);
        }

        public RiderView[] PassRiders()
        {
            Rider[] ridersTab= managerRidersDB.PassRiders();
            RiderView[] tab = new RiderView[ridersTab.Length];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = ConvertToRiderView(ridersTab[i]);

            return tab;
        }

        public RiderView PassRider(int id)
        {
            Rider r = managerRidersDB.PassRider(id);
            return ConvertToRiderView(r);  
        }

        private RiderView ConvertToRiderView(Rider rider)
        {
            RiderView r = new RiderView()
            {
                Id_Rider = rider.id_rider,
                Id_Team = rider.id_team,
                FirstName = rider.firstName,
                LastName = rider.lastName,
                Nationality = rider.nationality,
                Height = rider.height,
                Weight = rider.weight,
                StartNumber = rider.startNumber
            };
             return r;


        }


    }
}
