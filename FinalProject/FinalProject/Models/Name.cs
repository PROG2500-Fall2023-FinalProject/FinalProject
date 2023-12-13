using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    partial class Name
    {
        public string? LifeYears
        {
            get
            {
                string? born = String.IsNullOrEmpty(this.BirthYear.ToString()) ? "unknown" : this.BirthYear.ToString();
                string? death = String.IsNullOrEmpty(this.DeathYear.ToString()) ? "unknown" : this.DeathYear.ToString();

                return born + " - " + death;
            }
        }

        public string? Profession
        {
            get
            {
                return String.IsNullOrEmpty(this.PrimaryProfession.ToString()) ? "unknown" : this.PrimaryProfession.ToString();
            }
        }

        public List<string>? MovieList
        {
            get
            {
               List<string> list = new List<string>();
                foreach (Title title in this.Titles)
                {
                    list.Add(title.PrimaryTitle);
                }
        
               return list;
            }
        }
    }
}
