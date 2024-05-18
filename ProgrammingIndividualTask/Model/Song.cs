using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammingIndividualTask.Model
{
    /// <summary>
    /// Класс для создания песен.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Название песни для каждого объекта класса.
        /// </summary>
        private string _songName;
        /// <summary>
        /// Имя артиста для каждого объекта класса.
        /// </summary>
        private string _artistName;
        /// <summary>
        /// Длительность песни в секундах для каждого объекта класса.
        /// </summary>
        private int _duration;
        /// <summary>
        /// Жанр песни из перечисления Genre
        /// </summary>
        private Genre _genre;
        /// <summary>
        /// Возвращает и задаёт название песни. Не может быть пустым полем.
        /// </summary>
        public string SongName
        {
            get
            {
                return _songName;
            }
            set
            {
                int strLength = value.Length;
                Validator.AssertValueLength(strLength, 1, 50, nameof(SongName));
                 _songName = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт имя артиста. Не может быть пустым полем.
        /// </summary>
        public string ArtistName
        {
            get
            {
                return _artistName;
            }
            set
            {
                int strLength = value.Length;
                Validator.AssertValueLength(strLength, 1, 50, nameof(ArtistName));
                _artistName = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт длительность песни в секундах. Должно быть целым числом, больше 0.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                Validator.AssertValueInRange(value, 1, 7200, nameof(Duration));
                _duration = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт жанр песни из перечисления Genre. 
        /// </summary>
        public Genre Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }
        /// <summary>
        /// Создаёт экзмепляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="songName">Название песни.Не может бытьп пустым.</param>
        /// <param name="artistName">Имя артиста. Не может быть пустым.</param>
        /// <param name="duration">Длительность песни в секундах. Должно быть целым числом, больше 0. Не может быть пустым</param>
        /// <param name="genre">Жанр песни. Должен быть выбран из перечисления Genre.</param>
        public Song(string songName, string artistName, int duration, Genre genre)
        {
            SongName = songName;
            ArtistName = artistName;
            Duration = duration;
            Genre = genre;
        }
        public Song() { }
    }
}
