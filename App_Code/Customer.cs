using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    readonly private string ConnectionString =
        "Data Source=.\\SQLEXPRESS;AttachDbFilename=" +
        HttpContext.Current.Server.MapPath("~\\App_Data\\ASPNETDB.mdf") + ";Integrated Security=True;User Instance=True";

    public Customer(string lastName, string firstName, string midName, string address, string city, string state, int zip,
        int social, DateTime dateBirth, DateTime dateEst, long contactNumber, double balance, int referredBit, long referralNumber, string email)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = midName;
        Address = address;
        City = city;
        State = state;
        ZipCode = zip;
        SocialSecurity = social;
        DateOfBirth = dateBirth;
        DateEstablished = dateEst;
        ContactNumber = contactNumber;
        Balance = balance;
        ReferredBit = referredBit;
        ReferralNumber = referralNumber;
        Email = email;
        SalesId = "Silne01";
    }

    public long CustomerNumber { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public int ZipCode { get; set; }

    public int SocialSecurity { get; set; }

    public DateTime DateOfBirth { get; set; }

    public long ContactNumber { get; set; }

    public string Email { get; set; }

    public DateTime DateEstablished { get; set; }

    public double Balance { get; set; }

    public int ReferredBit { get; set; }

    public long ReferralNumber { get; set; }

    public string Error { get; set; }

    public string SalesId { get; set; }

    public bool AddCustomer()
    {
        //var sqlCommand = new SqlCommand("silne30.CreateCustomer", sqlConnection);
        var sqlConnection = new SqlConnection(ConnectionString);
        var sqlCommand = new SqlCommand("CreateCustomer", sqlConnection);
        try
        {
            sqlCommand.Parameters.Add("@LastName", SqlDbType.Char).Value = LastName;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.Char).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.Char).Value = MiddleName;
            sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            sqlCommand.Parameters.Add("@City", SqlDbType.VarChar).Value = City;
            sqlCommand.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
            sqlCommand.Parameters.Add("@Zip", SqlDbType.Int).Value = ZipCode;
            sqlCommand.Parameters.Add("@SSN", SqlDbType.Int).Value = SocialSecurity;
            sqlCommand.Parameters.Add("@DOB", SqlDbType.Date).Value = DateOfBirth;
            sqlCommand.Parameters.Add("@ContactNumber", SqlDbType.BigInt).Value = ContactNumber;
            sqlCommand.Parameters.Add("@DateEst", SqlDbType.Date).Value = DateEstablished;
            sqlCommand.Parameters.Add("@Balance", SqlDbType.Decimal).Value = Balance;
            sqlCommand.Parameters.Add("@ReferralBit", SqlDbType.Bit).Value = ReferredBit;
            sqlCommand.Parameters.Add("@Referral#", SqlDbType.BigInt).Value = ReferralNumber;
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
            return false;
        }
        finally
        {
            sqlConnection.Dispose();
        }
    }
}