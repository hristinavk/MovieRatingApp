using Microsoft.Maui.Media;

namespace MovieRating
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            Movie movie1 = new Movie("red_dragon.jpg","Red dragon");
            Movie movie2 = new Movie("red_riding_hood_final.jpg", "Red riding hood");
            Movie movie3 = new Movie("how_to_train_your_dragon.jpg", "How to train your dragon");
            Movie movie4 = new Movie("lion_king.jpeg", "Lion king");
            Movie movie5 = new Movie("skeleton_key.jpg", "Skeleton key");
            Movie movie6 = new Movie("the_silence_of_the_lambs.jpg", "The silence of the lambs");
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
