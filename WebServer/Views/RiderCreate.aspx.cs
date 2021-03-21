using System;
using WebServer.Controllers;
using WebServer.Views.ViewModels;

namespace WebServer.Views
{
    public partial class RiderCreate : System.Web.UI.Page
    {

        protected void btnSave_Click(object sender, EventArgs e)
        {
            RidersManager rm = new RidersManager();
            RiderView r = new RiderView
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Nationality = txtNationality.Text,
                Height = Convert.ToInt32(txtHeight.Text),
                Weight = Convert.ToInt32(txtWeight.Text)
            };

            rm.Save(r);



            Response.Redirect("RidersTable.aspx");
        }
    }
}