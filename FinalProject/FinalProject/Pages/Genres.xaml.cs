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
    /// Interaction logic for Genres.xaml
    /// </summary>
    public partial class Genres : Page
    {

        ImdbContext _context = new ImdbContext();
        CollectionViewSource genreViewSource = new CollectionViewSource();

        public Genres()
        {
            InitializeComponent();
            genreViewSource = (CollectionViewSource)FindResource(nameof(genreViewSource));

            _context.Genres.Load();
            _context.Titles.Load();

            var query = from genre in _context.Genres
                        select new
                        {
                            GenreName = genre.Name,
                            TitleNames = genre.Titles.Select(title => title.PrimaryTitle).ToList()
                        };

            genreViewSource.Source = query.ToList();
        }
    }
}
