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
using System.Diagnostics;
using System.Numerics;

namespace FinalProject.Pages
{
    public partial class Actors : Page
    {
        ImdbContext _context = new ImdbContext();
        CollectionViewSource actorViewSource = new CollectionViewSource();

        public Actors()
        {
            InitializeComponent();
            actorViewSource = (CollectionViewSource)FindResource(nameof(actorViewSource));
            ActorListView.ItemsSource = _context.Names.Local.ToObservableCollection();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // grab text from search bar
            string searchTerm = actorSearch.Text;

            // linq query expression
            var actorsQuery =
                from actor in _context.Names
                where actor.PrimaryName.Contains(searchTerm)
                select new
                {
                    // select only the data required
                    PrimaryName = actor.PrimaryName,
                    LifeYears = actor.LifeYears,
                    Profession = actor.Profession,
                };

            // set data from query to the source
            actorViewSource.Source = actorsQuery.ToList();
        }
    }
}
