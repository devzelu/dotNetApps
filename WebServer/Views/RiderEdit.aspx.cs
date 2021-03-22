using System;
using System.Web.UI;
using WebServer.Controllers;
using WebServer.Views.ViewModels;

namespace WebServer.Views
{
    public partial class RiderEdit : System.Web.UI.Page
    {
        readonly RidersManager rm = new RidersManager();
        private void RedirectToMainPage()
        {
            Response.Redirect("RidersTable.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string idStr = Request["id"];

                if (idStr == null)
                {
                    RedirectToMainPage();
                }

                int id = Convert.ToInt32(idStr);
                RiderView r = rm.PassRider(id);

                txtIdRider.Text = r.Id_Rider.ToString();
                if (r.TeamName == "")
                {
                }
                else
                {

                lblTeamName.Text = r.TeamName;
                }
                txtFirstName.Text = r.FirstName;
                txtLastName.Text = r.LastName;
                txtNationality.Text = r.Nationality;
                txtHeight.Text = r.Height.ToString();
                txtWeight.Text = r.Weight.ToString();
            }


        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdRider.Text);
            RiderView r = rm.PassRider(id);
            r.FirstName = txtFirstName.Text;
            r.LastName = txtLastName.Text;
            r.Nationality = txtNationality.Text;
            r.Weight = Convert.ToInt32(txtWeight.Text);
            r.Height = Convert.ToInt32(txtHeight.Text);

            rm.Edit(r);
            RedirectToMainPage();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdRider.Text);
            rm.Remove(id);
            RedirectToMainPage();
        }

    }
}