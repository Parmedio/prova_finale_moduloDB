using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_2___ADO.NET
{
    internal class Repository
    {
        public const string connectionString = @"Data Source=PARMEDIO\SQLEXPRESS;Initial Catalog=ArtWork;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public const string query01 = "SELECT M.MuseumName, AW.[Name] AS ArtworkName, C.[Name] AS CharacterName " +
                                "FROM ARTWORK AS AW JOIN MUSEUM AS M ON AW.ID_Museum = M.Id_Museum " +
                                "JOIN ARTIST AS A ON A.Id_Artist = AW.ID_Artist " +
                                "LEFT JOIN [CHARACTER] AS C ON AW.ID_Character = C.Id_Character " +
                                "WHERE A.Country = 'Italia'";

        public const string query02 = "SELECT DISTINCT A.[ArtistName] " +
                                "FROM (SELECT ID_Museum, ID_Artist FROM ARTWORK) AS AW " +
                                "JOIN (SELECT Id_Museum, City FROM MUSEUM) AS M ON AW.ID_Museum = M.Id_Museum " +
                                "JOIN (SELECT Id_Artist, [Name] AS ArtistName FROM ARTIST) AS A ON AW.ID_Artist = A.Id_Artist " +
                                "WHERE City = 'Parigi'";

        public const string query03 = "SELECT City " +
                                "FROM (SELECT ID_Museum, [Name] AS ArtworkName FROM ARTWORK) AS AW " +
                                "JOIN (SELECT Id_Museum, City FROM MUSEUM) AS M ON AW.ID_Museum = M.Id_Museum " +
                                "WHERE ArtworkName = 'Flora'";

        public static void colorFormatter(string color, string key, string value = "")
        {
            ConsoleColor consoleColor;
            switch (color.ToLower())
            {
                case "black":
                    consoleColor = ConsoleColor.Black;
                    break;
                case "red":
                    consoleColor = ConsoleColor.Red;
                    break;
                case "green":
                    consoleColor = ConsoleColor.Green;
                    break;
                case "yellow":
                    consoleColor = ConsoleColor.Yellow;
                    break;
                case "blue":
                    consoleColor = ConsoleColor.Blue;
                    break;
                case "magenta":
                    consoleColor = ConsoleColor.Magenta;
                    break;
                case "cyan":
                    consoleColor = ConsoleColor.Cyan;
                    break;
                case "white":
                    consoleColor = ConsoleColor.White;
                    break;
                default:
                    consoleColor = ConsoleColor.Gray;
                    break;
            }

            Console.ForegroundColor = consoleColor;
            Console.Write(key);
            Console.ResetColor();
            Console.WriteLine(value);
        }
    }
}
