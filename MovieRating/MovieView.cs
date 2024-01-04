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
            Label movieRating = new Label
            {
                Text = movie.MovieRating.ToString(),
                VerticalOptions = LayoutOptions.Center,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center
            };

            NativeRatingView rating = new NativeRatingView
            {
                Value = 0,
                StarColor = Color.Parse("Yellow")
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                //This function is called only when clicked
                //or touched between the stars and the rating button.
                movie.NewRating = rating.Value;
                movieRating.Text = movie.MovieRating.ToString("F2");
            };

            rating.GestureRecognizers.Add(tapGestureRecognizer);

            Content = new HorizontalStackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.Start,
                Children = { thumbnailImage, titleLabel, movieRating, rating }
            };
        }
    }
}
