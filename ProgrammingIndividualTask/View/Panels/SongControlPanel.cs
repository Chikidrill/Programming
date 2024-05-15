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
            // Путь к файлу с данными

            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreChanges) return;
            int selectedIndex = SongsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                Song selectedSong = _songs[selectedIndex];

                SongNameTextBox.Text = selectedSong.SongName;
                ArtistNameTextBox.Text = selectedSong.ArtistName;
                DurationTextBox.Text = selectedSong.Duration.ToString();
                GenreComboBox.SelectedItem = selectedSong.Genre;
            }

        }
        // Обработчик события клика по ListBox



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

            ignoreChanges = true;
            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            ignoreChanges = false;

            SongsListBox.ClearSelected();

            SaveSongList();

            // Отображаем обновленный список песен в ListBox
            DisplaySongList();

            // Очищаем поля ввода после добавления песни
            ClearInputFields();
        }
        private void DelSongButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли какой-либо элемент в ListBox
            if (SongsListBox.SelectedItem != null)
            {
                // Получаем индекс выбранной песни
                int selectedIndex = SongsListBox.SelectedIndex;

                // Удаляем песню из списка
                _songs.RemoveAt(selectedIndex);

                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();

                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Выберите песню для удаления.");
            }
        }
        private void DisplaySongList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            SongsListBox.Items.Clear();

            // Добавляем каждую песню из списка в ListBox
            foreach (Song song in _songs)
            {
                SongsListBox.Items.Add($"Song name: {song.SongName} - Artist name: {song.ArtistName}");
            }
        }
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

        // Метод для сохранения списка песен в файл
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

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно проводить валидацию поля
            try
            {
                SongNameTextBox.BackColor = AppColors.StandartColor;
                string songname = SongNameTextBox.Text;
                _currentSong.SongName = songname;
                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();
            }
            catch (Exception)
            {
                SongNameTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void ArtistNameTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                ArtistNameTextBox.BackColor = AppColors.StandartColor;
                string artistname = ArtistNameTextBox.Text;
                _currentSong.ArtistName = artistname;
                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();
            }
            catch (Exception)
            {
                ArtistNameTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DurationTextBox.BackColor = AppColors.StandartColor;
                int duration = int.Parse(DurationTextBox.Text);
                _currentSong.Duration = duration;
                // Сохраняем список песен в файл
                SaveSongList();

                // Отображаем обновленный список песен в ListBox
                DisplaySongList();
            }
            catch (Exception)
            {
                DurationTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void ClearSelectedButton_Click(object sender, EventArgs e)
        {
            ignoreChanges = true;

            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            SongsListBox.ClearSelected();

            ignoreChanges = false;
        }
    }
}
