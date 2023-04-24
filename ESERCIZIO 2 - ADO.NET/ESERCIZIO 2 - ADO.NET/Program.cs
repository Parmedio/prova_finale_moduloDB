// See https://aka.ms/new-console-template for more information
using ESERCIZIO_2___ADO.NET;
using Microsoft.Data.SqlClient;
using static ESERCIZIO_2___ADO.NET.Repository;

string separator = "==============================================================================================\n";
try
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        colorFormatter("green", "Query 01:\nScrivere una query \"select\" per recuperare la lista contenete:\n-> museo\n-> nome opera\n-> nome personaggio\ndegli artisti 'italiani'\n");

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
                    colorFormatter("red", "       Museum: ", $"{reader.GetString(0)}");
                    colorFormatter("red", "  ArtworkName: ", $"{reader.GetString(1)}");
                    colorFormatter("red", "CharacterName: ", $"{nomePersonaggio}\n");
                }
            }
        }
        colorFormatter("magenta", $"{separator}");

        colorFormatter("green", "Query 02:\nScrivere una query per recuperare i nomi degli artisti, opere di quali sono conservate a 'Parigi'\n");
        
        using (SqlCommand command = new SqlCommand(query02, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    colorFormatter("blue", "ArtistName: ", $"{reader.GetString(0)}\n");
                }
            }
        }
        colorFormatter("magenta", $"{separator}");

        colorFormatter("green", "Query 03:\nRecuperare la città in cui è conservato il quadro 'Flora'\n");

        using (SqlCommand command = new SqlCommand(query03, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    colorFormatter("yellow", "City: ", $"{reader.GetString(0)}\n");
                }
            }
        }
        colorFormatter("magenta", $"{separator}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Si è verificato un errore: " + ex.Message);
}