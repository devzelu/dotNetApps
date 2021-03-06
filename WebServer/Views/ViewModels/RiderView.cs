using System;

namespace WebServer.Views.ViewModels
{
    public class RiderView
    {
        public int Id_Rider { get; set; }
        public int? Id_Team { get; set; }
        public string TeamName { get 
            {
                if (Id_Team != null)
                {
                Models.ManagerTeamsDB managerTeamsDB =  new Models.ManagerTeamsDB();
                return managerTeamsDB.PassTeam(Id_Team).name;
                }
                else
                {
                    return "";
                }
            } 
           
        }
       

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int? StartNumber { get; set; }


        public string NickName
        {
            get
            {
                return FirstName.Substring(0,1) + LastName.Substring(0,1) + StartNumber.ToString();
            }
        }


        public string NameNationality
        {
            get
            {
                return string.Format("{0} {1} ({2})",
                    FirstName, LastName, Nationality);
            }
        }

        public RiderView()
        {

        }
        public RiderView(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public RiderView(string firstName, string lastName, string nationality) : this(firstName, lastName)
        {
            Nationality = nationality;
        }

        public RiderView(string id_Rider, string id_Team, string firstName, string lastName, string nationality,string height, string weight,string startNumber)
        {
            Id_Rider = Convert.ToInt32(id_Rider);

            if (id_Team == "")
                Id_Team = null;
            else
                Id_Team = Convert.ToInt32(id_Team);

            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;

            if (height == "")
                Height = null;
            else
                Height = Convert.ToInt32(height);

            if (weight == "")
                Weight = null;
            else
                Weight = Convert.ToInt32(weight);
            if(startNumber == "")
            {
                StartNumber = null;
            }
            else
            {
                StartNumber = Convert.ToInt32(startNumber);
            }

        }

        public string IntroduceYourself()
        {
            return string.Format("I am {0} {1} from ({2})", FirstName, LastName, Nationality);
        }

    }
}
