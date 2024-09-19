using System.Data;
using System.Data.SqlClient;

namespace Lect1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GetNorthwindProducts();
		}

		private static void GetNorthwindProducts()
		{
			// Old ADO.NET implementation

			try
			{
				// create a SqlConnection object that will connect to Northwind Database
				SqlConnection connection = new SqlConnection(
						"Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True;"
					);
				connection.Open();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Connection to database northwind has been opened successfully");
				SqlCommand command = new SqlCommand("select * from Products", connection);

				SqlDataAdapter adapter = new SqlDataAdapter(command);

				DataTable dt = new DataTable();
				adapter.Fill(dt);

				Console.WriteLine($"No. of rows : {dt.Rows.Count}");
				Console.ForegroundColor = ConsoleColor.White;
				foreach (DataRow dr in dt.Rows)
				{
					//Console.WriteLine($"Product Name: {dr[1]}, Unit Price : {dr[5]}");
					Console.WriteLine($"Product Name: {dr["ProductName"]}, Unit Price : {dr["UnitPrice"]}");
				}
				connection.Close();
			}
			catch (SqlException ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex.Message);
			}
		}
	}
}
