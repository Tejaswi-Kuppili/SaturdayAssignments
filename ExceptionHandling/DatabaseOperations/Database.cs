using System.Data.SqlClient;

class DatabaseProcessor
{
    private string connectionString = "Data Source=server;Initial Catalog=database;User ID=username;Password=password";

    public void ProcessData()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // Execute a database query
                string sqlQuery = "SELECT * FROM TableName";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Process the query results
                while (reader.Read())
                {
                    // Process each row of data
                    string value = reader.GetString(0);
                    Console.WriteLine(value);
                }

                // Close the reader
                reader.Close();

                // Close the database connection
                connection.Close();
            }
        }
        catch (SqlException ex)
        {
            // Handle SQL exceptions
            Console.WriteLine("Database error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle general exceptions
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        DatabaseProcessor dbProcessor = new DatabaseProcessor();
        dbProcessor.ProcessData();

        Console.ReadLine();
    }
}