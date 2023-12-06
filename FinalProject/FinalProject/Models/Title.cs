using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public partial class Title
    {
        public string? EpisodeCount
        {
            get
            {
                string value = "";

                if (0 == this.EpisodeParentTitles.Count)
                {
                    value = "N/A";
                } else
                {
                    value = "No. of Episodes: " + this.EpisodeParentTitles.Count;
                }

                return value;
            }
        }

        public string? AdultFilm
        {
            get
            {
                string value = "";

                if (true == this.IsAdult) value = "Adult";
                else value = "Non-Adult";

                return value;
            }
        }


        public string? AirTime
        {
            get
            {
                string value = "";

                if (null == this.StartYear ^ null == this.EndYear)
                {
                    if (null == this.StartYear) value = this.EndYear.ToString();
                    else if (null == this.EndYear) value = this.StartYear.ToString();

                } else if (null == this.StartYear && null == this.EndYear)
                {
                    value = "N/A";
                } else {
                    value = this.StartYear.ToString() + " - " + this.EndYear.ToString();
                }

                return value;
            }
        }

        public string? Duration
        {
            get
            {
                string value = "";

                if (this.RuntimeMinutes != null) value = "Duration: " + this.RuntimeMinutes.ToString() + "mins";
                else value = "N/A";

                return value;
            }
        }
    }
}
