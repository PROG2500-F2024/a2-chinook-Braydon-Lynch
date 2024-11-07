using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Data;
using PROG2500_A2_Chinook.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;


namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for AlbumsPage.xaml
    /// </summary>
    public partial class AlbumsPage : Page
    {
        ChinookContext context = new ChinookContext();
        CollectionViewSource albumsViewSource = new CollectionViewSource();

        public AlbumsPage()
        {
            InitializeComponent();

            //Tie the markup viewsource object to the C# code viewsource object
            albumsViewSource = (CollectionViewSource)FindResource(nameof(albumsViewSource));

            //Use the dbContext to tell EF to load the data we want to use on this page.
            context.Albums.Load();

            //Set the viewsource data source to use the album data collection (dbset)
            albumsViewSource.Source = context.Albums.Local.ToObservableCollection();
        }

    }
}
