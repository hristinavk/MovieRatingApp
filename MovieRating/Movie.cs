using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating;

public partial class Movie : ContentView
{
    public Movie()
    {}
    public Movie(string Thumbnail, string Title)
    {
        MovieThumbnail = Thumbnail;
        MovieTitle = Title;        
    }
    public string MovieThumbnail { get; set; } = "Default Value";
    public string MovieTitle { get; set; } = "Default Value";

}