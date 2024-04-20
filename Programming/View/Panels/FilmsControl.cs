using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class FilmsControl : UserControl
    {
        Film[] _films = new Film[5];
        Film _currentfilm = new Film();
        public FilmsControl()
        {
            InitializeComponent();
            Random random = new Random();
            string[] films_listboxItems = new string[5];
            string[] filmsTitles = new string[5]
                { "Batman", "Avengers: Final", "The GodFather", "Joker", "Ghostbusters" };
            for (int i = 0; i < 5; i++)
            {
                int durationMinutes = random.Next(20, 280);
                int releaseYear = random.Next(1900, DateTime.Now.Year + 1);
                double rating = Math.Round(random.NextDouble() * 10, 1);
                Film film = new Film(filmsTitles[i], durationMinutes, releaseYear, Genres.Action, rating);
                _films[i] = film;
                films_listboxItems[i] = ($"Movie {i + 1}");
            }

            films_listbox.Items.AddRange(films_listboxItems);
        }
        static private bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }

            value = default;
            return false;
        }
        private int FindFilmMaxRate(Film[] _films)
        {
            double MaxRate = _films[0].Rating;
            int MaxRateIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (_films[i].Rating > MaxRate)
                {
                    MaxRate = _films[i].Rating;
                    MaxRateIndex = i;
                }
            }

            return MaxRateIndex;
        }

        private void films_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (films_listbox.SelectedIndex == -1) return;
            _currentfilm = _films[films_listbox.SelectedIndex];
            titletxtbox.Text = _currentfilm.Title.ToString();
            durationminutestxtbox.Text = _currentfilm.DurationMinutes.ToString();
            releaseyeartxtbox.Text = _currentfilm.ReleaseYear.ToString();
            genretxtbox.Text = _currentfilm.Genre.ToString();
            ratingtxtbox.Text = _currentfilm.Rating.ToString();
        }

        private void buttonfilms_Click_1(object sender, EventArgs e)
        {
            double FilmMaxRateIndex = FindFilmMaxRate(_films);
            films_listbox.SelectedIndex = (int)FilmMaxRateIndex;
        }

        private void titletxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                titletxtbox.BackColor = System.Drawing.Color.White;
                string Title = titletxtbox.Text;
                _currentfilm.Title = Title;
            }
            catch (Exception)
            {
                titletxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void durationminutestxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                durationminutestxtbox.BackColor = System.Drawing.Color.White;
                int Duration = int.Parse(durationminutestxtbox.Text);
                _currentfilm.DurationMinutes = Duration;
            }
            catch (Exception)
            {
                durationminutestxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void releaseyeartxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                releaseyeartxtbox.BackColor = System.Drawing.Color.White;
                int Release = int.Parse(releaseyeartxtbox.Text);
                _currentfilm.ReleaseYear = Release;
            }
            catch (Exception)
            {
                releaseyeartxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void genretxtbox_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentfilm == null) return;
            string genre = genretxtbox.Text;
            if (TryGetEnumValue<Genres>(genre, out Genres value))
            {
                _currentfilm.Genre = value;
                genretxtbox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                genretxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ratingtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                ratingtxtbox.BackColor = System.Drawing.Color.White;
                double Rating = double.Parse(ratingtxtbox.Text);
                _currentfilm.Rating = Rating;
            }
            catch (Exception)
            {
                ratingtxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
