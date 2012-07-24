using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IONS
{
    public class Client
    {
        readonly private string ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Create all properties
        private SqlConnection sqlConnection;

        public string ClientNumber { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public string SocialSecurity { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public DateTime DateEstablished { get; set; }

        public double Balance { get; set; }

        public int ReferredBit { get; set; }

        public string ReferralNumber { get; set; }

        public string Error { get; set; }

        public string SalesId { get; set; }

        public SqlDataReader CustomerSearch { get; set; }

        public SqlDataReader ViewCustomerProducts { get; set; }

        public DateTime DueDate { get; set; }

        public string OrderComments { get; set; }

        public string[] SelectedProducts { get; set; }

        //Updates the client information (City, State, Address, Zip, and contact number)
        public bool UpdateClientInfo()
        {
            //Open sqlconnection with string. Automatically disposed after use.
            using (var connection = new SqlConnection(ConnectionString))
            {
                //Use stringbuilder to create string for query
                var commandString = new StringBuilder("UPDATE CLIENT SET");
                commandString.Append(" ADDRESS = @Address,");
                commandString.Append(" CITY = @City,");
                commandString.Append(" STATE = @State,");
                commandString.Append(" ZIP = @Zip ,");
                commandString.Append(" CONTACTNUMBER = @ContactNumber ");
                commandString.Append(" WHERE Client# = @Client# ");

                //Create command with commandString and connection
                using (var command = new SqlCommand(commandString.ToString(), connection))
                {
                    try
                    {
                        //Try to add parameters, open connection and execute query. If successful, return true.
                        command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
                        command.Parameters.Add("@City", SqlDbType.VarChar).Value = City;
                        command.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
                        command.Parameters.Add("@Zip", SqlDbType.Int).Value = ZipCode;
                        command.Parameters.Add("@ContactNumber", SqlDbType.VarChar).Value = ContactNumber;
                        command.Parameters.Add("@Client#", SqlDbType.VarChar).Value = ClientNumber;
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception exception)
                    {
                        //If false, set error property to message and return false.
                        Error = exception.Message;
                        return false;
                    }
                }
            }
        }

        //Retrieves employeeID for salesperson that created new customer
        public string RetrieveSalesId(string loggedInUser)
        {
            //Create querystring and create new connection.
            const string queryString = "SELECT EmployeeID FROM EMPLOYEE WHERE UserID = @UserID";
            using (var connection = new SqlConnection(ConnectionString))
            {
                //Create command with querystring and connection
                using (var command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        //try to add parameter for userI and open query. Return the user's employeeID as string.
                        command.Parameters.Add("@UserID", SqlDbType.VarChar).Value = loggedInUser;
                        connection.Open();
                        return (string)command.ExecuteScalar();
                    }
                    catch (Exception exception)
                    {
                        //Return failed if unsuccessful.
                        Error = exception.Message;
                        return "";
                    }
                }
            }
        }

        //Method to create new customer record.
        public bool AddCustomer()
        {
            //Create querystring and create new connection.
            using (var connection = new SqlConnection(ConnectionString))
            {
                //Create command with querystring and connection
                using (var command = new SqlCommand("CreateClient", connection))
                {
                    //try to add parameter for userI and open query. Return true if successful.
                    try
                    {
                        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                        command.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                        command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
                        command.Parameters.Add("@City", SqlDbType.VarChar).Value = City;
                        command.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
                        command.Parameters.Add("@Zip", SqlDbType.Int).Value = ZipCode;
                        command.Parameters.Add("@SSN", SqlDbType.VarChar).Value = SocialSecurity;
                        command.Parameters.Add("@DOB", SqlDbType.Date).Value = DateOfBirth;
                        command.Parameters.Add("@ContactNumber", SqlDbType.VarChar).Value = ContactNumber;
                        command.Parameters.Add("@DateEst", SqlDbType.Date).Value = DateEstablished;
                        command.Parameters.Add("@Balance", SqlDbType.Decimal).Value = Balance;
                        command.Parameters.Add("@ReferralBit", SqlDbType.Bit).Value = ReferredBit;
                        command.Parameters.Add("@Referral#", SqlDbType.VarChar).Value = ReferralNumber;
                        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                        command.Parameters.Add("@DueDate", SqlDbType.Date).Value = DueDate;
                        command.Parameters.Add("@Comments", SqlDbType.Text).Value = OrderComments;
                        command.Parameters.Add("@SalesID", SqlDbType.VarChar).Value = SalesId;

                        //Since the client can choose up to 10 products, this for loop creates all of the
                        //parameters. If null, it creates the parameter with a null value. If not, set to
                        //value. The stored procedure that will be called checks the null values and does
                        //not insert them.
                        for (int i = 0; i < SelectedProducts.Length; i++)
                        {
                            if (SelectedProducts[i] != null)
                            {
                                command.Parameters.Add("@Product" + (i + 1), SqlDbType.VarChar).Value =
                                    SelectedProducts[i];
                            }
                            else
                            {
                                command.Parameters.Add("@Product" + (i + 1), SqlDbType.VarChar).Value = DBNull.Value;
                            }
                        }
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                        return false;
                    }
                }
            }
        }

        //Check if the supplied social security number given by customer exists.
        public bool CheckIfCustomerExists()
        {
            //open Sql connection with SQL string
            using (var connection = new SqlConnection(ConnectionString))
            {
                //query string with parameter. create sqlCommand with commandString and connection.
                const string commandString = "SELECT * FROM CLIENT WHERE SSN = @SSN";
                using (var command = new SqlCommand(commandString, connection))
                {
                    try
                    {
                        //Try to add parameter, and open connection. If the query does not have rows,
                        //the customer does not exist. Return true. If not, return false.
                        command.Parameters.Add("@SSN", SqlDbType.VarChar).Value = SocialSecurity;
                        connection.Open();
                        if (command.ExecuteReader().HasRows)
                        {
                            Error =
                                "Client already exists in the system. Please check use customer search to check customer's social security number. ";
                            return true;
                        }
                        return false;
                    }
                    catch (Exception exception)
                    {
                        Error = exception.Message;
                        return true;
                    }
                }
            }
        }

        //Retrieve the products on the client's account.
        public bool ViewClientProducts()
        {
            //create stringbuilder for querystring. create connection using connection string.
            var queryString = new StringBuilder("SELECT CASE Category WHEN 'TV' THEN 'Television' ");
            queryString.Append("WHEN 'LD' THEN 'Long Distance' ELSE Category END as 'Category', ");
            queryString.Append("p.Name as 'Plan Name', p.Price as 'Price' FROM PRODUCT p INNER JOIN ");
            queryString.Append("CLIENTSPRODUCT cp on cp.productID = p.productID WHERE cp.Client# = @ClientNumber");
            sqlConnection = new SqlConnection(ConnectionString);
            {
                //use command that will dispose of itself once done using querystring and sqlconnection
                using (var command = new SqlCommand(queryString.ToString(), sqlConnection))
                {
                    //Try to run query, if successful, set property to data reader and return true. if not, return
                    //false for error handling.
                    try
                    {
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        sqlConnection.Open();
                        ViewCustomerProducts = command.ExecuteReader();
                        return true;
                    }
                    catch (Exception exception)
                    {
                        Error = exception.Message;
                        return false;
                    }
                }
            }
        }

        public bool DeleteClient()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string queryString = "DELETE FROM CLIENT WHERE Client# = @ClientNumber";
                using (var command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                        return false;
                    }
                }
            }
        }

        public bool SearchCustomer()
        {
            //Create parameterized query to search for the selected customer. Return values
            //and set CustomerSearch property to the returned datareader.
            sqlConnection = new SqlConnection(ConnectionString);
            const string commandString = "Select Client# , FirstName, LastName, Address, City, State, Zip, " +
                                   "DOB, SSN, ContactNumber, DateEst, Balance FROM CLIENT" +
                                   " WHERE Client# = @Client#";
            var command = new SqlCommand(commandString, sqlConnection);
            try
            {
                command.Parameters.Add("@Client#", SqlDbType.VarChar).Value = ClientNumber;
                sqlConnection.Open();
                CustomerSearch = command.ExecuteReader();
                return true;
            }
            catch (Exception exception)
            {
                Error = exception.Message;
                return false;
            }
        }

        public void CloseConnection()
        {
            //Close connection after datareader has pulled data because connection
            //must remain open until datareader is done.
            sqlConnection.Dispose();
        }
    }
}