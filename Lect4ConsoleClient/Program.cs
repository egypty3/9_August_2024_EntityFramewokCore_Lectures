using System.Net.Http.Json;

namespace Lect4ConsoleClient
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7260/api/Authors/");			

			while (true)
			{
				Console.WriteLine("Menu:");
				Console.WriteLine("1. Get All Authors");
				Console.WriteLine("2. Get First Two Authors");
				Console.WriteLine("3. Get Author by ID");
				Console.WriteLine("4. Add New Author");
				Console.WriteLine("5. Update Author");
				Console.WriteLine("6. Delete Author");
				Console.WriteLine("7. Exit");
				Console.Write("Enter your choice: ");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						await GetAllAuthors(client);
						break;
					case "2":
						await GetFirstTwoAuthors(client);
						break;
					case "3":
						await GetAuthorById(client);
						break;
					case "4":
						await AddNewAuthor(client);
						break;
					case "5":
						await UpdateAuthor(client);
						break;
					case "6":
						await DeleteAuthor(client);
						break;
					case "7":
						return;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}
		static async Task GetAllAuthors(HttpClient client)
		{
			var authors = await client.GetFromJsonAsync<List<Author>>("GetAll");
			foreach (var author in authors)
			{
				Console.WriteLine($"ID: {author.AuthorId}, Name: {author.FirstName} {author.LastName}");
			}
		}

		static async Task GetFirstTwoAuthors(HttpClient client)
		{
			var authors = await client.GetFromJsonAsync<List<Author>>("GetTwo");
			foreach (var author in authors)
			{
				Console.WriteLine($"ID: {author.AuthorId}, Name: {author.FirstName} {author.LastName}");
			}
		}

		static async Task GetAuthorById(HttpClient client)
		{
			Console.Write("Enter Author ID: ");
			int id = int.Parse(Console.ReadLine());
			var author = await client.GetFromJsonAsync<Author>($"GetAuthor/{id}");
			if (author != null)
			{
				Console.WriteLine($"ID: {author.AuthorId}, Name: {author.FirstName} {author.LastName}");
			}
			else
			{
				Console.WriteLine("Author not found.");
			}
		}

		static async Task AddNewAuthor(HttpClient client)
		{
			Console.Write("Enter Author First Name: ");
			string firstName = Console.ReadLine();
			Console.Write("Enter Author Last Name: ");
			string lastName = Console.ReadLine();
			var newAuthor = new Author { FirstName = firstName, LastName = lastName };
			var response = await client.PostAsJsonAsync("", newAuthor);
			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("Author added successfully.");
			}
			else
			{
				Console.WriteLine("Error adding author.");
			}
		}

		static async Task UpdateAuthor(HttpClient client)
		{
			Console.Write("Enter Author ID: ");
			int id = int.Parse(Console.ReadLine());
			Console.Write("Enter Author First Name: ");
			string firstName = Console.ReadLine();
			Console.Write("Enter Author Last Name: ");
			string lastName = Console.ReadLine();
			var updatedAuthor = new Author { AuthorId = id, FirstName = firstName, LastName = lastName };
			var response = await client.PutAsJsonAsync($"{id}", updatedAuthor);
			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("Author updated successfully.");
			}
			else
			{
				Console.WriteLine("Error updating author.");
			}
		}

		static async Task DeleteAuthor(HttpClient client)
		{
			Console.Write("Enter Author ID: ");
			int id = int.Parse(Console.ReadLine());
			var response = await client.DeleteAsync($"{id}");
			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("Author deleted successfully.");
			}
			else
			{
				Console.WriteLine("Error deleting author.");
			}
		}
	}
}


