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
        private string filePath = "C:\\Users\\dvorn\\source\\repos\\Programming\\ProgrammingIndividualTask\\Data.txt";
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
            if (SongsListBox.SelectedIndex == -1) return;
            _currentSong = _songs[SongsListBox.SelectedIndex];
            SongNameTextBox.Text = _currentSong.SongName;
            ArtistNameTextBox.Text = _currentSong.ArtistName;
            DurationTextBox.Text = _currentSong.Duration.ToString();
            GenreComboBox.Text = _currentSong.Genre.ToString();
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            Song newSong = new Song
            {
                SongName = SongNameTextBox.Text,
                ArtistName = ArtistNameTextBox.Text,
                Duration = int.Parse(DurationTextBox.Text),
                Genre = (Genre)GenreComboBox.SelectedItem
            };

            _songs.Add(newSong);
            SaveSongList();

            // Отображаем обновленный список песен в ListBox
            DisplaySongList();

            // Очищаем поля ввода после добавления песни
            ClearInputFields();
        }
        private void DisplaySongList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            SongsListBox.Items.Clear();

            // Добавляем каждую песню из списка в ListBox
            foreach (Song song in _songs)
            {
                SongsListBox.Items.Add($"{song.SongName} - {song.ArtistName} ({song.Duration} sec) - {song.Genre}");
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
            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationTextBox.Clear();
            GenreComboBox.SelectedIndex = -1; // Сброс выбора в комбо-боксе
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = SongsListBox.Items.IndexOf(_currentSong);
            try
            {
                SongNameTextBox.BackColor = AppColors.StandartColor;
                string songname = SongNameTextBox.Text;
                _currentSong.SongName = songname;

            }
            catch (Exception)
            {
                SongNameTextBox.BackColor = AppColors.InvalidColor;
            }
        }
    }
}
