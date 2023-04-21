using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_2___ADO.NET.Model
{
    internal class Artwork
    {
        public int Id_Artwork { get; set; }
        public string ArtworkName { get; set; }
        public int ID_Museum { get; set; }
        public int ID_Artist { get; set; }
        public int ID_Character { get; set; }
    }
}
