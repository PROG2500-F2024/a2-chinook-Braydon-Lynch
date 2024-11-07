using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Data;
using PROG2500_A2_Chinook.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;


namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for ArtistsPage.xaml
    /// </summary>
    public partial class ArtistsPage : Page
    {
        ChinookContext context = new ChinookContext();
        CollectionViewSource artistsViewSource = new CollectionViewSource();

        public ArtistsPage()
        {
            InitializeComponent();

            //Tie the markup viewsource object to the C# code viewsource object
            artistsViewSource = (CollectionViewSource)FindResource(nameof(artistsViewSource));

            //Use the dbContext to tell EF to load the data we want to use on this page.
            context.Artists.Load();

            //Set the viewsource data source to use the album data collection (dbset)
            artistsViewSource.Source = context.Artists.Local.ToObservableCollection();
        }

    }
}
