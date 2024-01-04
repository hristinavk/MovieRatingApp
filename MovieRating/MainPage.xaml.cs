using Microsoft.Maui.Media;

namespace MovieRating
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            Movie movie1 = new Movie("red_dragon.jpg","Red dragon", 4.5, 10 );
            Movie movie2 = new Movie("red_riding_hood_final.jpg", "Red riding hood", 3.4, 15);
            Movie movie3 = new Movie("how_to_train_your_dragon.jpg", "How to train your dragon", 4.2, 34);
            Movie movie4 = new Movie("lion_king.jpeg", "Lion king", 4.1, 100);
            Movie movie5 = new Movie("skeleton_key.jpg", "Skeleton key", 4.5, 1);
            Movie movie6 = new Movie("the_silence_of_the_lambs.jpg", "The silence of the lambs", 4.8, 19);
            VerticalStackLayout stackLayout = new VerticalStackLayout();

            stackLayout.Children.Add(new MovieView(movie1));
            stackLayout.Children.Add(new MovieView(movie2));
            stackLayout.Children.Add(new MovieView(movie3));
            stackLayout.Children.Add(new MovieView(movie4));
            stackLayout.Children.Add(new MovieView(movie5));
            stackLayout.Children.Add(new MovieView(movie6));

            Content = new ScrollView
            {
                Content = stackLayout
            };         
           
        }
    }

}
