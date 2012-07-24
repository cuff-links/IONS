using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace IONS
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If the user is not an administor, redirect to customerSearch page.
            if (!Page.User.IsInRole("Admin"))
            {
                Response.Redirect("CustomerSearch.aspx");
            }
        }

        protected void BtnEnterSystemClick(object sender, EventArgs e)
        {
            //Enter system to customerSearch page.
            Response.Redirect("~/CustomerSearch.aspx", true);
        }

        protected void BtnLogOutClick(object sender, EventArgs e)
        {
            //Log out of system and clear the session.
            FormsAuthentication.SignOut();
            Roles.DeleteCookie();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        private bool InsertEmployeeRecord(string firstName, string lastName, string middleInit, int isSales, string email,
                                          string userId)
        {
            //set up SQL connection and commands to use the createEmployee Stored procedure.
            using (var connection = new SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (var command = new SqlCommand("CreateEmployee", connection))
                {
                    try
                    {
                        //Try to create all parameters and execute stored procedure. If successful,
                        //return true.
                        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = firstName;
                        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
                        if (middleInit == "N/A")
                        {
                            command.Parameters.Add("@MiddleInit", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@MiddleInit", SqlDbType.VarChar).Value = middleInit;
                        }

                        command.Parameters.Add("@IsSalesperson", SqlDbType.Bit).Value = isSales;
                        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                        command.Parameters.Add("@UserID", SqlDbType.VarChar).Value = userId;
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        //Return false.
                        return false;
                    }
                }
            }
        }

        protected void CreateUserWizardCreatingUser(object sender, LoginCancelEventArgs e)
        {
            //Gather all data for employee record and run stored procedure to create new employee.
            var textFirst = (TextBox)createUserWizard.CreateUserStep.ContentTemplateContainer.FindControl("txtFirstName");
            var firstName = textFirst.Text;
            var textLast = (TextBox)createUserWizard.CreateUserStep.ContentTemplateContainer.FindControl("txtLastName");
            var lastName = textLast.Text;
            var textMiddle = (TextBox)createUserWizard.CreateUserStep.ContentTemplateContainer.FindControl("txtMiddle");
            var middleInit = textMiddle.Text;
            if (middleInit == null)
            {
                middleInit = "N/A";
            }
            var cboRole =
                (Telerik.Web.UI.RadComboBox)
                createUserWizard.CreateUserStep.ContentTemplateContainer.FindControl("cboRoles");
            var role = cboRole.SelectedValue;
            var isSales = 0;
            if (role == "Sales")
            {
                isSales = 1;
            }
            var textEmail = (TextBox)createUserWizard.CreateUserStep.ContentTemplateContainer.FindControl("Email");
            var email = textEmail.Text;
            var textUserId = (TextBox)createUserWizard.CreateUserStep.ContentTemplateContainer.FindControl("UserName");
            var userId = textUserId.Text;

            //If insert employee record is not true, advise the user that the employee record was not
            //successfully created though the user was.
            if (!InsertEmployeeRecord(firstName, lastName, middleInit, isSales, email, userId))
            {
                RadWindowManager1.RadAlert("User created but unable to create employee record. Contact development team.",
                                           300, 150, "Employee Error", "");
            }

            //add user to selected role.
            Roles.AddUserToRole(userId, role);
        }
    }
}