using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgrammingIndividualTask.Model;

namespace ProgrammingIndividualTask.View.Panels
{
    public partial class SongControlPanel : UserControl
    {
        private List<Song> _songs = new List<Song>();
        private Song _currentSong;
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.txt");
        private bool ignoreChanges = false;
        public SongControlPanel()
        {

            InitializeComponent();
            LoadSongList();
            DisplaySongList();
            SortSongs();
            // Путь к файлу с данными
            SongNameErrorlabel.Text = "";
            ArtistNameErrorlabel.Text = "";
            DurationErrorlabel.Text = "";
            GenreErrorlabel.Text = "";
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }
        /// <summary>
        /// Событие для отображения выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SongsListBox.SelectedIndex;

            // Если выбранный индекс действителен
            if (selectedIndex != -1)
            {
                // Обновляем текущую песню
                _currentSong = _songs[selectedIndex];

                // Обновляем поля ввода с данными выбранной песни
                SongNameTextBox.Text = _currentSong.SongName;
                ArtistNameTextBox.Text = _currentSong.ArtistName;
                DurationTextBox.Text = _currentSong.Duration.ToString();
                GenreComboBox.Text = _currentSong.Genre.ToString();

            }
            else
            {
                // Сбрасываем текущую песню, если ничего не выбрано
                _currentSong = null;
                SongNameTextBox.Text = string.Empty;
                ArtistNameTextBox.Text = string.Empty;
                GenreComboBox.SelectedIndex = -1;
                DurationTextBox.Text = string.Empty;
            }

        }
        /// <summary>
        /// Осуществляет изменение поля SongName у конкретного объекта. Производит валидацию нового значения, сортировку и отображение после изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SongNameTextBox.BackColor = AppColors.StandartColor;
                string songname = SongNameTextBox.Text;

                // Проверяем, инициализирован ли _currentSong
                if (_currentSong == null)
                {
                    _currentSong = new Song();
                }
                SongNameErrorlabel.Text = "";
                _currentSong.SongName = songname;
                SortSongs();
                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();

            }
            catch (Exception ex)
            {
                SongNameTextBox.BackColor = AppColors.InvalidColor;
                SongNameErrorlabel.Text = ex.Message;
            }
        }
        /// <summary>
        /// Осуществляет изменение поля ArtistName у конкретного объекта. Производит валидацию нового значения, сортировку и отображение после изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArtistNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ArtistNameTextBox.BackColor = AppColors.StandartColor;
                string artistname = ArtistNameTextBox.Text;

                // Проверяем, инициализирован ли _currentSong
                if (_currentSong == null)
                {
                    _currentSong = new Song();
                }
                ArtistNameErrorlabel.Text = "";
                _currentSong.ArtistName = artistname;
                // Сохраняем список песен в файл
                SortSongs();
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();
            }
            catch (Exception ex)
            {
                ArtistNameTextBox.BackColor = AppColors.InvalidColor;
                ArtistNameErrorlabel.Text = ex.Message;
            }
        }
        /// <summary>
        /// Осуществляет изменение поля Duration у конкретного объекта. Производит валидацию нового значения, сортировку и отображение после изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = AppColors.StandartColor;
                int duration = int.Parse(DurationTextBox.Text);

                // Проверяем, инициализирован ли _currentSong
                if (_currentSong == null)
                {
                    _currentSong = new Song();
                }
                DurationErrorlabel.Text = "";
                _currentSong.Duration = duration;
                SortSongs();
                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();
            }
            catch (Exception ex)
            {
                DurationTextBox.BackColor = AppColors.InvalidColor;
                DurationErrorlabel.Text = ex.Message;
            }
        }
        /// <summary>
        /// Осуществляет изменение поля Genre у конкретного объекта. Производит валидацию нового значения, сортировку и отображение после изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SongsListBox.SelectedIndex;

            try
            {
                if (selectedIndex != -1 && Enum.TryParse(GenreComboBox.SelectedItem?.ToString(), out Genre genre))
                {
                    Song selectedSong = _songs[selectedIndex];
                    selectedSong.Genre = genre;
                    GenreErrorlabel.Text = "";
                    SongsListBox.Items[selectedIndex] = selectedSong;

                    // Сортируем список песен после изменения данных
                    SortSongs();

                    SaveSongList();
                    DisplaySongList();
                }
            }
            catch (Exception ex)
            {
                DurationTextBox.BackColor = AppColors.InvalidColor;
                GenreComboBox.Text = ex.Message;
            }
        }
        /// <summary>
        /// Осуществляет добавление нового объекта класса Song, записывая значения из TextBox и ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSongButton_Click(object sender, EventArgs e)
        {

            var newSong = new Song
            {
                SongName = SongNameTextBox.Text,
                ArtistName = ArtistNameTextBox.Text,
                Duration = int.Parse(DurationTextBox.Text),
                Genre = (Genre)GenreComboBox.SelectedItem
            };

            _songs.Add(newSong);
            SortSongs();
            ignoreChanges = true;
            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            ignoreChanges = false;
            SongNameErrorlabel.Text = "";
            ArtistNameErrorlabel.Text = "";
            DurationErrorlabel.Text = "";
            GenreErrorlabel.Text = "";
            SongsListBox.ClearSelected();

            SaveSongList();

            // Отображаем обновленный список песен в ListBox
            DisplaySongList();

            // Очищаем поля ввода после добавления песни
            ClearInputFields();
        }
        /// <summary>
        /// Осуществляет удаление объекта класса Song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelSongButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = SongsListBox.SelectedIndex;
            // Проверяем, выбран ли какой-либо элемент в ListBox
            if (selectedIndex != -1)
            {
                // Получаем индекс выбранной песни


                // Удаляем песню из списка
                _songs.RemoveAt(selectedIndex);
                SortSongs();
                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();

                ClearInputFields();
                SongNameErrorlabel.Text = "";
                ArtistNameErrorlabel.Text = "";
                DurationErrorlabel.Text = "";
                GenreErrorlabel.Text = "";
            }
            else
            {
                MessageBox.Show("Выберите песню для удаления.");
            }
        }
        /// <summary>
        /// Осуществляет очищение значений из TextBox и ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearSelectedButton_Click(object sender, EventArgs e)
        {
            // Сбрасываем текущую песню, если ничего не выбрано
            _currentSong = null;
            SongNameTextBox.Text = string.Empty;
            ArtistNameTextBox.Text = string.Empty;
            GenreComboBox.SelectedIndex = -1;
            DurationTextBox.Text = string.Empty;
            SongNameTextBox.BackColor = AppColors.StandartColor;
            ArtistNameTextBox.BackColor = AppColors.StandartColor;
            GenreComboBox.SelectedIndex = -1;
            DurationTextBox.BackColor = AppColors.StandartColor;
        }
        /// <summary>
        /// Осуществляет вывод значений в ListBox.
        /// </summary>
        private void DisplaySongList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            SongsListBox.Items.Clear();

            // Добавляем каждую песню из списка в ListBox
            foreach (Song song in _songs)
            {
                SongsListBox.Items.Add($"Artist name: {song.ArtistName} - Song name: {song.SongName}");
            }
        }
        /// <summary>
        /// Осуществляет загрузку файлов из файла.
        /// </summary>
        private void LoadSongList()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        // Парсим каждую строку в объект Song и добавляем его в список
                        string[] parts = line.Split(',');
                        Song song = new Song
                        {
                            SongName = parts[0],
                            ArtistName = parts[1],
                            Duration = int.Parse(parts[2]),
                            Genre = (Genre)Enum.Parse(typeof(Genre), parts[3])
                        };
                        _songs.Add(song);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Осуществляет сохранение данных в файл.
        /// </summary>
        private void SaveSongList()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Song song in _songs)
                    {
                        // Записываем каждую песню в файл в формате "Название песни,Исполнитель,Длительность,Жанр"
                        writer.WriteLine($"{song.SongName},{song.ArtistName},{song.Duration},{song.Genre}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
        /// <summary>
        /// Осуществляет очистку полей ввода после добавления или удаления выбранного элемента.
        /// </summary>
        private void ClearInputFields()
        {
            SongNameTextBox.Text = "";
            ArtistNameTextBox.Text = "";
            DurationTextBox.Text = "";
            GenreComboBox.SelectedIndex = -1; // Сброс выбора в комбо-боксе
            SongNameTextBox.BackColor = AppColors.StandartColor;
            ArtistNameTextBox.BackColor = AppColors.StandartColor;
            DurationTextBox.BackColor = AppColors.StandartColor;
            GenreComboBox.BackColor = AppColors.StandartColor;
            if (SongsListBox.SelectedIndex == -1)
            {
                // Очищаем выбранный элемент в ListBox
                SongsListBox.SelectedItem = null;
            }
        }
        /// <summary>
        /// Осуществляет сортировку песен.
        /// </summary>
        private void SortSongs()
        {
            // Сортируем список песен
            var sortedSongs = _songs.OrderBy(song => song.ArtistName).ThenBy(song => song.SongName).ToList();

            // Очищаем BindingList и добавляем отсортированные песни
            _songs.Clear();
            foreach (var song in sortedSongs)
            {
                _songs.Add(song);
            }
        }
    }
}
