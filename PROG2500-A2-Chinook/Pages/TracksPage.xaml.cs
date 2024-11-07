using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Data;
using PROG2500_A2_Chinook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for TracksPage.xaml
    /// </summary>
    public partial class TracksPage : Page
    {
        private readonly ChinookContext _context = new ChinookContext();

        public TracksPage()
        {
            InitializeComponent();
            LoadTracks();
        }

        private void LoadTracks()
        {
            try
            {
                var tracks = _context.Tracks
                    .Include(t => t.Album)
                    .Include(t => t.Genre)
                    .Include(t => t.MediaType)
                    .ToList();

                TracksListView.ItemsSource = tracks;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading tracks: {ex.Message}");
            }
        }
    }
}
