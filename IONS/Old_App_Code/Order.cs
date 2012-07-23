using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IONS
{
    public class Order
    {
        readonly private string ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        private SqlConnection sqlConnection;
        //Create all properties

        public string ClientNumber { get; set; }

        public string OrderNumber { get; set; }

        public DataSet OrderSearch { get; set; }

        public DataSet OrderedProductSearch { get; set; }

        public SqlDataReader OrderingClient { get; set; }

        public string Error { get; set; }

        public string Comments { get; set; }

        public DateTime DueDate { get; set; }

        public string Status { get; set; }

        public string[] SelectedProducts { get; set; }

        public string EmployeeId { get; set; }

        public bool UpdateOrderInfo()
        {
            //Open sqlconnection with string. Automatically disposed after use.
            using (var connection = new SqlConnection(ConnectionString))
            {
                //Use stringbuilder to create string for query
                var queryString = new StringBuilder("UPDATE ORDERS SET");
                queryString.Append(" DueDate = @DueDate, ");
                queryString.Append(" Status = @Status, ");
                queryString.Append(" Comments = @Comments ");
                queryString.Append(" WHERE Order# = @OrderNumber");

                //Create command with commandString and connection
                using (var command = new SqlCommand(queryString.ToString(), connection))
                {
                    try
                    {
                        //Try to add parameters, open connection and execute query. If successful, return true.
                        command.Parameters.Add("@DueDate", SqlDbType.VarChar).Value = DueDate;
                        if (Comments == null)
                        {
                            command.Parameters.Add("@Comments", SqlDbType.VarChar).Value = "No Comments";
                        }
                        else
                        {
                            command.Parameters.Add("@Comments", SqlDbType.VarChar).Value = Comments;
                        }
                        command.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
                        command.Parameters.Add("@OrderNumber", SqlDbType.VarChar).Value = OrderNumber;
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

        public bool CompleteOrder()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                //Create command with querystring and connection
                using (var command = new SqlCommand("CompleteOrder", connection))
                {
                    //try to add parameter for userI and open query. Return true if successful.
                    try
                    {
                        command.Parameters.Add("@OrderNumber", SqlDbType.VarChar).Value = OrderNumber;

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

        public bool PlaceOrder()
        {
            //Create querystring and create new connection.
            using (var connection = new SqlConnection(ConnectionString))
            {
                //Create command with querystring and connection
                using (var command = new SqlCommand("CreateNewOrder", connection))
                {
                    //try to add parameter for userI and open query. Return true if successful.
                    try
                    {
                        command.Parameters.Add("@DueDate", SqlDbType.VarChar).Value = DueDate;
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        command.Parameters.Add("@Comments", SqlDbType.VarChar).Value = Comments;
                        command.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = EmployeeId;

                        //Since the client can choose up to 5 products, this for loop creates all of the
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

        public bool SearchExistingOrder()
        {
            //Parameterized query for searching for existing orders.
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string queryString = "SELECT * FROM ORDERS WHERE Client# = @ClientNumber AND Status = 'P'";
                using (var command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        connection.Open();

                        if (command.ExecuteReader().HasRows)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public bool SearchOrderDetails()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var queryString = new StringBuilder("SELECT o.Order#, c.Client#, FirstName + ' ' + LastName as 'Name', ");
                queryString.Append("ContactNumber as 'Contact#', Address, City + '/' + State + '/' + CAST(Zip as VARCHAR) as 'CityState' , ");
                queryString.Append("DueDate, Case Status WHEN 'P' THEN 'Pending' WHEN 'C' THEN 'Complete' END, ");
                queryString.Append("Comments, EmployeeID FROM ORDERS o JOIN Client c on ");
                queryString.Append("o.Client# = c.Client# WHERE o.Client# = @ClientNumber AND o.Order# = @OrderNumber");

                using (var command = new SqlCommand(queryString.ToString(), connection))
                {
                    try
                    {
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        command.Parameters.Add("@OrderNumber", SqlDbType.VarChar).Value = OrderNumber;
                        var adapter = new SqlDataAdapter(command);
                        var myDataSet = new DataSet();
                        adapter.Fill(myDataSet, "Order");

                        OrderSearch = myDataSet;
                        if (OrderSearch.Tables["Order"].Rows.Count > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (Exception exception)
                    {
                        Error = exception.Message;
                        return false;
                    }
                }
            }
        }

        public bool PullOrderingClientDetails()
        {
            sqlConnection = new SqlConnection(ConnectionString);
            const string queryString = "SELECT FirstName + ' ' + LastName as 'Name' , Address," +
                              "City + '/' +State + '/' + CAST(Zip as VARCHAR) as 'CityState', ContactNumber " +
                              "as 'Contact#' FROM CLIENT WHERE Client# = @ClientNumber";
            using (var command = new SqlCommand(queryString, sqlConnection))
            {
                try
                {
                    command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                    sqlConnection.Open();
                    OrderingClient = command.ExecuteReader();
                    return true;
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return false;
                }
            }
        }

        public bool CancelOrder()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string queryString = "DELETE FROM ORDERS WHERE Order# = @OrderNumber";
                using (var command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        command.Parameters.Add("@OrderNumber", SqlDbType.VarChar).Value = OrderNumber;
                        connection.Open();
                        command.ExecuteNonQuery();
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

        public string RetrieveOrderNumber()
        {
            const string queryString = "SELECT Order# FROM ORDERS o INNER JOIN CLIENT c on c.Client# = o.Client# WHERE " +
                                       "o.Client# = @ClientNumber AND Status = 'P'";
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        connection.Open();
                        return (string)command.ExecuteScalar();
                    }
                    catch (Exception exception)
                    {
                        Error = exception.Message;
                        return "";
                    }
                }
            }
        }

        public bool SearchProductDetails()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var queryString = new StringBuilder("SELECT CASE Category WHEN 'TV' THEN 'Television' WHEN 'LD' THEN 'Long Distance' ");
                queryString.Append("ELSE Category END as 'Category' , Name as 'Plan Name', Price from ORDEREDPRODUCT op ");
                queryString.Append("JOIN ORDERS o on o.Order# = op.Order# JOIN CLIENT c on ");
                queryString.Append("c.Client# = o.Client# JOIN PRODUCT p on p.ProductID = op.ProductID ");
                queryString.Append("WHERE o.Client# = @ClientNumber AND ");
                queryString.Append("o.Order# = @OrderNumber");
                using (var command = new SqlCommand(queryString.ToString(), connection))
                {
                    try
                    {
                        command.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = ClientNumber;
                        command.Parameters.Add("@OrderNumber", SqlDbType.VarChar).Value = OrderNumber;
                        var adapter = new SqlDataAdapter(command);
                        var myDataSet = new DataSet();
                        adapter.Fill(myDataSet, "Products");

                        OrderedProductSearch = myDataSet;
                        if (OrderedProductSearch.Tables["Products"].Rows.Count > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (Exception exception)
                    {
                        Error = exception.Message;
                        return false;
                    }
                }
            }
        }

        public void CloseConnection()
        {
            sqlConnection.Close();
        }
    }
}