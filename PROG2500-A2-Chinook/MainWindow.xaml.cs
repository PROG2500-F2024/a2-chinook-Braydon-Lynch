using PROG2500_A2_Chinook.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG2500_A2_Chinook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Home Button Click Event Handler
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Home Page (you can update this to your home page logic)
            MainContentFrame.Navigate(new HomePage());
        }

        // Albums Button Click Event Handler
        private void AlbumsButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Albums Page
            MainContentFrame.Navigate(new AlbumsPage());
        }

        // Artists Button Click Event Handler
        private void ArtistsButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Artists Page
            MainContentFrame.Navigate(new ArtistsPage());
        }

        // Tracks Button Click Event Handler
        private void TracksButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the TracksPage
            MainContentFrame.Navigate(new TracksPage());
        }

        // Exit Menu Item Click Event Handler
        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Close the application
            Application.Current.Shutdown();
        }

        // Albums Menu Item Click Event Handler
        private void AlbumsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new AlbumsPage());
        }

        // Artists Menu Item Click Event Handler
        private void ArtistsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new ArtistsPage());
        }

        // Tracks Menu Item Click Event Handler
        private void TracksMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new TracksPage());
        }
    }
}
