using ConsoleApplication1.Classes;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MemoryApp.Pages;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MemoryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            MemTable memttable = new MemTable();
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NewGame));
        }

        private void Scores_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Scores));

        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Rules));
        }

        private void Author_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Author));
        }
    }
}
