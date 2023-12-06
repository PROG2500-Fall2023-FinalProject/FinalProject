using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
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
    public partial class Actors : Page
    {
        ImdbContext _context = new ImdbContext();
        CollectionViewSource actorViewSource = new CollectionViewSource();

        public Actors()
        {
            InitializeComponent();

            //Tie the markup viewsource object to the code viewsource object
            actorViewSource = (CollectionViewSource)FindResource(nameof(actorViewSource));

            //Use the dbContext to tell EF to load the data we'll use on this page
            _context.Names.Load();

            //Set the viewsource data source to use the actor data collection
            actorViewSource.Source = _context.Names.Local.ToObservableCollection();
            actorViewSource.Source = _context.Titles.Local.ToObservableCollection();

            //Set the listview with actor data
            ActorListView.ItemsSource = _context.Names.Local.ToObservableCollection();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = actorSearch.Text;

            // linq query expression
            var query =
                from actor in _context.Names
                where actor.PrimaryName.Contains(searchTerm)
                select actor;

            ActorListView.ItemsSource = query.ToList();
        }
    }
}
