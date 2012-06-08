using System;
using System.Linq;
using System.ServiceModel;
using System.Xml;
using System.Xml.Linq;
using ZipWebService;

public partial class OrderEntry : System.Web.UI.Page
{
    private int referredBit;

    protected void Page_Load(object sender, EventArgs e)
    {
        dateDob.MaxDate = DateTime.Now.AddYears(-18);
        dateDob.MinDate = DateTime.Now.AddYears(-100);
        ajaxPanelPageScripts.ResponseScripts.Add("$('#step2').hide();");
    }

    protected void BtnSubmitClick(object sender, EventArgs e)
    {
        string lastName = txtLastName.Text;
        string firstName = txtFirstName.Text;
        string middleName = txtMiddleName.Text;
        string address = txtAddress.Text;
        string city = txtCity.Text;
        string state = txtState.Text;
        int zipCode = Convert.ToInt32(txtZipCode.Text);
        int socialSecurity = Convert.ToInt32(txtSSN.Text);
        var dateOfBirth = (DateTime)dateDob.SelectedDate;
        long contactNumber = Convert.ToInt64(txtContact.Text);
        long referralNumber = Convert.ToInt64(txtReferralNum.Text);
        string email = txtEmail.Text;
        var dateEst = DateTime.Today;
        const double Balance = 0;
        try
        {
            var customer = new Customer(lastName, firstName, middleName, address, city, state, zipCode, socialSecurity,
                dateOfBirth, dateEst, contactNumber, Balance, referredBit, referralNumber, email);
            if (customer.AddCustomer())
            {
                ajaxPanelPageScripts.ResponseScripts.Add("alert('Customer successfully created!');");
                ajaxPanelPageScripts.ResponseScripts.Add("$('#step1').hide('slow');");
                ajaxPanelPageScripts.ResponseScripts.Add("$('#step2').delay(500).show('slow');");
            }
            else
            {
                //ajaxPanelCustInfo.ResponseScripts.Add("alert('Unable to add customer. Please check that social security number does not already exist.');");
                ajaxPanelPageScripts.ResponseScripts.Add("alert('" + customer.Error + "');");
            }
        }
        catch (FormatException)
        {
            ajaxPanelCustInfo.ResponseScripts.Add("alert('Please check that data is in proper format.');");
        }
    }

    protected void BtnResetClick(object sender, EventArgs e)
    {
        ClearCustomerInfo();
        txtFirstName.Focus();
        btnValidateZip.Enabled = true;
        btnSubmit.Enabled = false;
    }

    public void ClearCustomerInfo()
    {
        txtAddress.Text = "";
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtMiddleName.Text = "";
        txtZipCode.Text = "";
        txtContact.Text = "";
        txtSSN.Text = "";
        txtCity.Text = "";
        txtState.Text = "";
        dateDob.Clear();
        txtReferralNum.Text = "0";
        cboReferred.SelectedIndex = 0;
        txtReferralNum.Enabled = false;
    }

    public void GetCityState(string zip)
    {
        try
        {
            var client = new USZipSoapClient("USZipSoap");
            XmlNode allNodes = client.GetInfoByZIP(zip);
            var x = XDocument.Parse(allNodes.InnerXml);
            var city = x.Descendants("CITY").Select(m => m.Value);
            var state = x.Descendants("STATE").Select(m => m.Value);
            txtCity.Text = city.First();
            txtState.Text = state.First();
            btnSubmit.Enabled = true;
        }
        catch (XmlException)
        {
            txtCity.Text = "";
            txtState.Text = "";
            ajaxPanelCustInfo.ResponseScripts.Add("alert('Invalid Zip Code. Check zip code and validate again.')");
        }
        catch (EndpointNotFoundException)
        {
            ajaxPanelCustInfo.ResponseScripts.Add(
                "alert('Zip Code Lookup is unavailable. Please enter city and state manually.');");
            txtCity.Enabled = true;
            txtCity.ReadOnly = false;
            txtState.Enabled = true;
            txtState.ReadOnly = false;
            btnValidateZip.Enabled = false;
            btnSubmit.Enabled = true;
        }
    }

    protected void BtnValidateClick(object sender, EventArgs e)
    {
        GetCityState(txtZipCode.Text);
    }

    protected void CboReferredSelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        switch (cboReferred.SelectedIndex)
        {
            case 1:
                {
                    referredBit = 1;
                    txtReferralNum.Enabled = true;
                    break;
                }
            case 0:
                {
                    referredBit = 0;
                    txtReferralNum.Enabled = false;
                    txtReferralNum.Text = "0";
                    break;
                }
        }
    }
}