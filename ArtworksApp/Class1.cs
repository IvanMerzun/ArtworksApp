using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtworksApp
{
    public class Artwork
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}, {Year}, ${Price}";
        }
    }

    public class Painting : Artwork
    {
        public string Material { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Material: {Material}";
        }
    }

    public class Book : Artwork
    {
        public int Pages { get; set; }
        public int Circulation { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Pages: {Pages}, Circulation: {Circulation}";
        }
    }
}
