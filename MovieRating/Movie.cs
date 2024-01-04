using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating;

public partial class Movie : ContentView
{   
    public Movie(string Thumbnail, string Title, double rating, int votes)
    {
        MovieThumbnail = Thumbnail;
        MovieTitle = Title;   
        MovieRating = rating;
        NewRating = 0;
        VotesCount = votes;
    }
    public string MovieThumbnail { get; set; } = "Default Value";
    public string MovieTitle { get; set; } = "Default Value";

    public int newRating;
    public int NewRating
    {
        get
        {
            return newRating;
        }
        set
        {
            if (value == 0)
                return;

            if(VotesCount == 0)
            {
                newRating = value;
                VotesCount = 1;
                MovieRating = value;
                return;
            }
            if(newRating != 0)
            {
                if (VotesCount - 1 == 0)
                {
                    newRating = value;
                    VotesCount = 1;
                    MovieRating = value;
                    OnPropertyChanged(nameof(MovieRating));
                    return;
                }
                MovieRating = ((VotesCount * MovieRating) - newRating) / (VotesCount - 1);
                newRating = 0;
                VotesCount -= 1;                
            }
            
            newRating = value;
            MovieRating = ((VotesCount * MovieRating) + value) / (VotesCount + 1);
            VotesCount += 1;
            OnPropertyChanged(nameof(MovieRating));

        }
    }
    public int VotesCount;
    public double MovieRating { set; get; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}