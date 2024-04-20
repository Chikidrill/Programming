using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    /// <summary>
    /// Осуществляет поиск фильма с наибольшим рейтингом.
    /// </summary>
    public partial class FilmsControl : UserControl
    {
        Film[] _films = new Film[5];
        Film _currentfilm = new Film();
        /// <summary>
        /// Создание массива из 5 фильмов со случайными значениями года выпуска, рейтинга и жанра.
        /// </summary>
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
        /// <summary>
        /// Поиск фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="_films">Массив фильмов.</param>
        /// <returns>Индекс фильма с наибольшим рейтингом.</returns>
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
        /// <summary>
        /// Отображение данных о выбранном фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Отображение фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonfilms_Click_1(object sender, EventArgs e)
        {
            double FilmMaxRateIndex = FindFilmMaxRate(_films);
            films_listbox.SelectedIndex = (int)FilmMaxRateIndex;
        }
        /// <summary>
        /// Изменение и сохранение названия фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titletxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                titletxtbox.BackColor = AppColors.StandartColor;
                string Title = titletxtbox.Text;
                _currentfilm.Title = Title;
            }
            catch (Exception)
            {
                titletxtbox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение длительности фильма с её валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void durationminutestxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                durationminutestxtbox.BackColor = AppColors.StandartColor;
                int Duration = int.Parse(durationminutestxtbox.Text);
                _currentfilm.DurationMinutes = Duration;
            }
            catch (Exception)
            {
                durationminutestxtbox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение года выпуска фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void releaseyeartxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                releaseyeartxtbox.BackColor = AppColors.StandartColor;
                int Release = int.Parse(releaseyeartxtbox.Text);
                _currentfilm.ReleaseYear = Release;
            }
            catch (Exception)
            {
                releaseyeartxtbox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение жанра фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genretxtbox_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentfilm == null) return;
            string genre = genretxtbox.Text;
            if (TryGetEnumValue<Genres>(genre, out Genres value))
            {
                _currentfilm.Genre = value;
                genretxtbox.BackColor = AppColors.StandartColor;
            }
            else
            {
                genretxtbox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение рейтинга фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratingtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                ratingtxtbox.BackColor = AppColors.StandartColor;
                double Rating = double.Parse(ratingtxtbox.Text);
                _currentfilm.Rating = Rating;
            }
            catch (Exception)
            {
                ratingtxtbox.BackColor = AppColors.InvalidColor;
            }
        }
    }
}
