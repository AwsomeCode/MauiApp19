namespace MauiApp19
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new MainTabbedPage()));
        }
    }

    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            this.Children.Add(new ContentPage
            {
                Title = "Home Tab 1",
                Content = new StackLayout
                {
                    Children = {
                        new Label { Text = "Home Tab 1" },
                        new Button { Text = "Go to ProductTabbedPage", 
                            Command = new Command(Clicked) }
                    }
                }
            });
            this.Children.Add(new ContentPage
            {
                Title = "Home Tab 2",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Home Tab 2" }
                    }
                }
            });
        }

        private async void Clicked(object obj)
        {
            await Navigation.PushAsync(new ProductTabbedPage());
        }
    }

    public class ProductTabbedPage : TabbedPage
    {
        public ProductTabbedPage()
        {
            this.Children.Add(new ContentPage
            {
                Title = "Product Tab 1",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Product Tab 1" },
                    }
                }
            });
            this.Children.Add(new ContentPage
            {
                Title = "Product Tab 2",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Product Tab 2" }
                    }
                }
            });
        }
    }
}