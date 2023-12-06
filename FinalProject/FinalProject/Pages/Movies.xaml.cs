using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
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

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for Movies.xaml
    /// </summary>
    /// 
    public partial class Movies : Page
    {
        ImdbContext _context = new ImdbContext();
        CollectionViewSource movieViewSource = new CollectionViewSource();

        public Movies()
        {
            InitializeComponent();
            movieViewSource = (CollectionViewSource)FindResource(nameof(movieViewSource));

            movieViewSource.Source = _context.Names.Local.ToObservableCollection();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = movieSearch.Text;

            // linq query expression
            var query = _context.Titles.Where(movie => movie.PrimaryTitle.Contains(movieSearch.Text)).ToList();
            movieListView.ItemsSource = query.ToList();
        }
    }
}
