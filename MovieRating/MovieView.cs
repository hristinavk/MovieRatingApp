using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating
{
    public class MovieView : ContentView
    {
        public MovieView(Movie movie)
        {
            Image thumbnailImage = new Image
            {
                Source = movie.MovieThumbnail,
                HeightRequest = 85
            };

            Label titleLabel = new Label
            {
                Text = movie.MovieTitle,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center
            };

            NativeRatingView rating = new NativeRatingView
            {
                Value = 0,
                StarColor = Color.Parse("Yellow")
            };

            Content = new HorizontalStackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.Start,
                Children = { thumbnailImage, titleLabel, rating }
            };
        }
    }
}
