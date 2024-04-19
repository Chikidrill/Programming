using Microsoft.VisualBasic.Devices;
using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {

        Rectangle _currentRectangle = new Rectangle();
        Rectangle[] _rectangles = new Rectangle[5];
        private List<Rectangle> _canvaRectangles = new List<Rectangle>();
        private Rectangle _currentCanvaRectangle;
        private List<string> CanvaRectanglesListBoxItems = new List<string>();
        private List<Panel> _rectanglesPanels = new List<Panel>();
        Film[] _films = new Film[5];
        Film _currentfilm = new Film();
        public MainForm()
        {

            InitializeComponent();
            rectpanel.BorderStyle = BorderStyle.FixedSingle;
            OutputParseLabel.Text = "";
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                SeasonCombobox.Items.Add(season);
            }
            Random random = new Random();
            string[] rectangle_listboxItems = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Colour randcolor = (Colour)random.Next(1, 7);
                Rectangle rectangle = new Rectangle(random.Next(3, 118), random.Next(3, 320), randcolor);
                _rectangles[i] = rectangle;
                rectangle_listboxItems[i] = ($"Rectangle {i + 1}");
            }
            rectangle_listbox.Items.AddRange(rectangle_listboxItems);
            foreach (var rect in _rectangles)
            {
                secondRectListBox.Items.Add(rect.ToString());
            }
            string[] films_listboxItems = new string[5];
            string[] filmsTitles = new string[5] { "Batman", "Avengers: Final", "The GodFather", "Joker", "Ghostbusters" };
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
        // Laboratory work #1+#2
        private readonly Type[] _typeModel = new Type[] { typeof(Colour), typeof(EducationForm), typeof(Genres), typeof(Manufacturers), typeof(Season), typeof(Weekday) };
        static private bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            ValueListBox.Items.Clear();
            ValueListBox.Items.AddRange(values);
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string daytoparse = ParseValuetxtbox.Text;
            if (Enum.TryParse<Weekday>(daytoparse, out Weekday parsedDay))
            {
                int numericValue = (int)parsedDay;
                OutputParseLabel.Text = $"Это день недели ({parsedDay} = {numericValue})";
            }
            else
            {
                OutputParseLabel.Text = "Нет такого дня недели";
            }
        }
        private void SetTabBackColor(System.Drawing.Color color)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.BackColor = color;
            }
        }
        private void seasonbtn_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonCombobox.SelectedItem.ToString();
            switch (selectedSeason)
            {
                case "Winter":
                    SetTabBackColor(System.Drawing.Color.AliceBlue);
                    MessageBox.Show("Бррр... Холодно! Даже программа замерзла :/");
                    break;
                case "Spring":
                    SetTabBackColor(System.Drawing.Color.Green);
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Каникулы :D !!!");
                    break;
                case "Autumn":
                    SetTabBackColor(System.Drawing.Color.SandyBrown);
                    MessageBox.Show("Я календарь, я календарь, я календарь....");
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Отображение числового значения выбранного элемента перечисления
            intvaluetxtbox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }
        // Laboratory work #3
        //Rectangles
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double MaxWidth = rectangles[0].Width;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = rectangles[i].Width;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;
        }
        private void findbtn_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            rectangle_listbox.SelectedIndex = RectangleMaxWidthIndex;
        }
        private void rectangle_listbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (rectangle_listbox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[rectangle_listbox.SelectedIndex];
            lengthtxtbox.Text = _currentRectangle.Length.ToString();
            widthtxtbox.Text = _currentRectangle.Width.ToString();
            colortxtbox.Text = _currentRectangle.Color.ToString();
            xcentertxtbox.Text = _currentRectangle.Center.coord_X.ToString();
            ycentertxtbox.Text = _currentRectangle.Center.coord_Y.ToString();
            idtxtbox.Text = _currentRectangle.ID.ToString();
        }
        private void lengthtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            int index = rectangle_listbox.Items.IndexOf(_currentRectangle);
            try
            {
                lengthtxtbox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(lengthtxtbox.Text);
                _currentRectangle.Length = length;

            }
            catch (Exception)
            {
                lengthtxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void widthtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            int index = rectangle_listbox.Items.IndexOf(_currentRectangle);
            try
            {
                widthtxtbox.BackColor = System.Drawing.Color.White;
                int width = int.Parse(widthtxtbox.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                widthtxtbox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        //Films
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
        //Lab 5
        private void secondRectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondRectListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[secondRectListBox.SelectedIndex];
                // Отображение данных выбранного прямоугольника
                selectedIdTxtBox.Text = _currentRectangle.ID.ToString();
                selectedXTxtBox.Text = _currentRectangle.Center.coord_X.ToString();
                selectedYTxtBox.Text = _currentRectangle.Center.coord_Y.ToString();
                selectedWidthTxtBox.Text = _currentRectangle.Width.ToString();
                selectedLengthTxtBox.Text = _currentRectangle.Length.ToString();
            }
            else
            {
                // Очистка текстовых полей
                selectedIdTxtBox.Text = "";
                selectedXTxtBox.Text = "";
                selectedYTxtBox.Text = "";
                selectedWidthTxtBox.Text = "";
                selectedLengthTxtBox.Text = "";
                _currentRectangle = null;
            }
        }
        private int GiveRectangleOrder()
        {
            int RectangleOrder;
            if (CanvaRectanglesListBoxItems.Count != 0)
            {

                RectangleOrder = Convert.ToInt16(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1].Substring(0, 2).Trim(')')) + 1;
            }
            else
            {
                RectangleOrder = 1;
            }
            return RectangleOrder;
        }
        private void addrecButton_Click(object sender, EventArgs e)
        {
            Rectangle NewRectangle = RectangleFactory.Randomize();


            _canvaRectangles.Add(NewRectangle);
            CanvaRectanglesListBoxItems.Add($"{GiveRectangleOrder()})L={NewRectangle.Length};W={NewRectangle.Width};X={NewRectangle.Center.coord_X} ;Y= {NewRectangle.Center.coord_Y}");
            secondRectListBox.Items.Add(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1]);
            secondRectListBox.SelectedIndex = secondRectListBox.Items.Count - 1;

            Panel NewPanel = new Panel();
            NewPanel.Location = new Point((int)NewRectangle.Center.coord_X - NewRectangle.Width / 2, (int)NewRectangle.Center.coord_Y - NewRectangle.Length / 2);
            NewPanel.Height = NewRectangle.Length;
            NewPanel.Width = NewRectangle.Width;
            NewPanel.BackColor = System.Drawing.Color.LightGreen;

            _rectanglesPanels.Add(NewPanel);
            rectpanel.Controls.Add(NewPanel);

            selectedLengthTxtBox.BackColor = System.Drawing.Color.White;
            selectedWidthTxtBox.BackColor = System.Drawing.Color.White;

            FindCollision();
            UpdateListBox();
        }
        public void CanvaRectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                //Ограничил до 200, но можно и больше
                //int length = _random.Next(10,200);
                //int widtht = _random.Next(10,200);
                //_canvaRectangles.Add(new Rectangle(length, widtht, ""));

                _canvaRectangles.Add(RectangleFactory.Randomize());
                CanvaRectanglesListBoxItems.Add($"{i + 1})L={_canvaRectangles[i].Length};W={_canvaRectangles[i].Width};X={_canvaRectangles[i].Center.coord_X};Y={_canvaRectangles[i].Center.coord_Y}");

                Panel InitPanel = new Panel();
                InitPanel.Location = new Point((int)_canvaRectangles[i].Center.coord_X - _canvaRectangles[i].Width / 2, (int)_canvaRectangles[i].Center.coord_Y- _canvaRectangles[i].Length / 2);
                InitPanel.Height = _canvaRectangles[i].Length;
                InitPanel.Width = _canvaRectangles[i].Width;
                InitPanel.BackColor = System.Drawing.Color.LightGreen;
                rectpanel.Controls.Add(InitPanel);
                _rectanglesPanels.Add(InitPanel);
            }
            foreach (string el in CanvaRectanglesListBoxItems)
            {
                secondRectListBox.Items.Add(el);
            }
            FindCollision();
        }
        private void FindCollision()
        {
            foreach (var panel in _rectanglesPanels)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }

            for (int i = 0; i < _canvaRectangles.Count; i++)
            {
                for (int j = 0; j < _canvaRectangles.Count; j++)
                {
                    if (!(_canvaRectangles[i] == _canvaRectangles[j]) && CollissionManager.IsCollision(_canvaRectangles[i], _canvaRectangles[j]))
                    {
                        _rectanglesPanels[i].BackColor = System.Drawing.Color.Red;

                        _rectanglesPanels[j].BackColor = System.Drawing.Color.Red;
                    }

                }
            }
        }

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            CanvaRectangleInitiaziation();
        }
        private void UpdateListBox()
        {
            secondRectListBox.Items.Clear();
            foreach (var rectangle in _rectangles)
            {
                secondRectListBox.Items.Add(rectangle.ToString()); // Формат вывода строки
            }
        }

        private void delrecButton_Click(object sender, EventArgs e)
        {
            _rectangles.RemoveAt(secondRectListBox.SelectedIndex);
            UpdateListBox();
        }

        private void selectedWidthTxtBox_TextChanged(object sender, EventArgs e)
        {
            int index = rectangle_listbox.Items.IndexOf(_currentRectangle);
            try
            {
                selectedWidthTxtBox.BackColor = System.Drawing.Color.White;
                int width = int.Parse(selectedWidthTxtBox.Text);
                _currentRectangle.Width = width;
                UpdateListBox();

            }
            catch (Exception)
            {
                selectedWidthTxtBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void selectedLengthTxtBox_TextChanged(object sender, EventArgs e)
        {
            int index = rectangle_listbox.Items.IndexOf(_currentRectangle);
            try
            {
                selectedLengthTxtBox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(selectedLengthTxtBox.Text);
                _currentRectangle.Length = length;
                UpdateListBox();
            }
            catch (Exception)
            {
                selectedLengthTxtBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void selectedXTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}