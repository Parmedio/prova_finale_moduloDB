// See https://aka.ms/new-console-template for more information
using ESERCIZIO_2___ADO.NET;
using Microsoft.Data.SqlClient;
using static ESERCIZIO_2___ADO.NET.Repository;

string separator = "===============================================\n";
try
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();

        Console.WriteLine("Query 01: Scrivere una query \"select\" per recuperare la lista contenete: museo, nome opera, nome \r\npersonaggio degli artisti italiani\n");

        using (SqlCommand command = new SqlCommand(query01, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nomePersonaggio = "";
                    if (!reader.IsDBNull(2))
                    {
                        nomePersonaggio = reader.GetString(2);
                    }
                    Console.WriteLine($"Museum: {reader.GetString(0)}\nArtworkName: {reader.GetString(1)}\nCharacterName: {nomePersonaggio}\n");
                }
            }
        }
        Console.WriteLine(separator);
       
        Console.WriteLine("Query 02: Scrivere una query per recuperare i nomi degli artisti, opere di quali sono conservate a Parigi\n");

        using (SqlCommand command = new SqlCommand(query02, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ArtistName: {reader.GetString(0)}\n");
                }
            }
        }
        Console.WriteLine(separator);

        Console.WriteLine("Query 03: Recuperare la città in cui è conservato il quadro \"Flora\"\n");

        using (SqlCommand command = new SqlCommand(query03, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"City: {reader.GetString(0)}\n");
                }
            }
        }
        Console.WriteLine(separator);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Si è verificato un errore: " + ex.Message);
}