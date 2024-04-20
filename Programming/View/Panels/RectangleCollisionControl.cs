using Programming.Model.Classes;
using Programming.Model.Geometry;
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
    /// <summary>
    /// Осуществляет динамическое отображение пересечений прямоугольников на канве.
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        private List<Rectangle> _canvaRectangles = new List<Rectangle>();
        private Rectangle _currentCanvaRectangle;
        private List<string> CanvaRectanglesListBoxItems = new List<string>();
        private List<Panel> _rectanglesPanels = new List<Panel>();
        public RectangleCollisionControl()
        {
            InitializeComponent();
            CanvaRectangleInitiaziation();
            CanvaRectPanel.BorderStyle = BorderStyle.FixedSingle;
        }
        /// <summary>
        /// Осуществляет рандомную генерацию 5 прямоугольников с выводом их на канву.
        /// </summary>
        public void CanvaRectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                _canvaRectangles.Add(RectangleFactory.Randomize());
                CanvaRectanglesListBoxItems.Add(
                    $"{i + 1})L={_canvaRectangles[i].Length};W={_canvaRectangles[i].Width};X={_canvaRectangles[i].Center.coord_X};Y={_canvaRectangles[i].Center.coord_Y}");

                Panel InitPanel = new Panel();
                InitPanel.Location = new Point((int)_canvaRectangles[i].Center.coord_X - _canvaRectangles[i].Width / 2,
                    (int)_canvaRectangles[i].Center.coord_Y - _canvaRectangles[i].Length / 2);
                InitPanel.Height = _canvaRectangles[i].Length;
                InitPanel.Width = _canvaRectangles[i].Width;
                InitPanel.BackColor = AppColors.ValidColor;
                CanvaRectPanel.Controls.Add(InitPanel);
                _rectanglesPanels.Add(InitPanel);
            }

            foreach (string el in CanvaRectanglesListBoxItems)
            {
                CanvaRectListBox.Items.Add(el);
            }

            FindCollision();
        }
        /// <summary>
        /// Считает уникальный идентификатор объекта на ЛистБоксе.
        /// </summary>
        /// <returns>Номер объекта</returns>
        private int GiveRectangleId()
        {
            int RectangleOrder;
            if (CanvaRectanglesListBoxItems.Count != 0)
            {
                RectangleOrder = Convert.ToInt16(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1]
                    .Substring(0, 2).Trim(')')) + 1;
            }
            else
            {
                RectangleOrder = 1;
            }

            return RectangleOrder;
        }
        /// <summary>
        /// Осуществляет добавление нового прямоугольника с рандомными полями и выводом его на канву. Так же добавляет его в массив прямоугольников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddRecButton_Click(object sender, EventArgs e)
        {
            Rectangle NewRectangle = RectangleFactory.Randomize();


            _canvaRectangles.Add(NewRectangle);
            CanvaRectanglesListBoxItems.Add(
                $"{GiveRectangleId()})L={NewRectangle.Length};W={NewRectangle.Width};X={NewRectangle.Center.coord_X} ;Y= {NewRectangle.Center.coord_Y}");
            CanvaRectListBox.Items.Add(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1]);
            CanvaRectListBox.SelectedIndex = CanvaRectListBox.Items.Count - 1;

            Panel NewPanel = new Panel();
            NewPanel.Location = new Point((int)NewRectangle.Center.coord_X - NewRectangle.Width / 2,
                (int)NewRectangle.Center.coord_Y - NewRectangle.Length / 2);
            NewPanel.Height = NewRectangle.Length;
            NewPanel.Width = NewRectangle.Width;
            NewPanel.BackColor = AppColors.ValidColor;

            _rectanglesPanels.Add(NewPanel);
            CanvaRectPanel.Controls.Add(NewPanel);

            CanvaLengthTxtBox.BackColor = AppColors.StandartColor;
            CanvaWidthTxtBox.BackColor = AppColors.StandartColor;

            FindCollision();

        }
        /// <summary>
        /// Осуществляет удаление прямоугольника по выбранному индексу. Так же удаляет его с канвы и массива прямоугольников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRecButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            _canvaRectangles.RemoveAt(selectedIndex);
            CanvaRectanglesListBoxItems.RemoveAt(selectedIndex);
            CanvaRectListBox.Items.RemoveAt(selectedIndex);

            CanvaRectListBox.SelectedIndex = CanvaRectListBox.Items.Count - 1;

            _rectanglesPanels.RemoveAt(selectedIndex);
            CanvaRectPanel.Controls.RemoveAt(selectedIndex);

            FindCollision();
        }
        /// <summary>
        /// Осуществляет проверку пересечений всех существующих прямоугольников на канве. При пересечении окрашивает, пересекающиеся прямоугольники в красный цвет, иначе зеленый.
        /// </summary>
        private void FindCollision()
        {
            foreach (var panel in _rectanglesPanels)
            {
                panel.BackColor = AppColors.ValidColor;
            }

            for (int i = 0; i < _canvaRectangles.Count; i++)
            {
                for (int j = 0; j < _canvaRectangles.Count; j++)
                {
                    if (!(_canvaRectangles[i] == _canvaRectangles[j]) &&
                        CollissionManager.IsCollision(_canvaRectangles[i], _canvaRectangles[j]))
                    {
                        _rectanglesPanels[i].BackColor = AppColors.ColissionColor;

                        _rectanglesPanels[j].BackColor = AppColors.ColissionColor;
                    }

                }
            }
        }
        /// <summary>
        /// Осуществляет изменения поля Width у конкретного объекта. Так же динамически изменяет его на канве с проверкой пересечений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CanvaWidthTxtBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectListBox.SelectedIndex;
            try
            {
                if (CanvaRectListBox.Items.Count != 0)
                {

                    CanvaWidthTxtBox.BackColor = AppColors.StandartColor;
                    int width = int.Parse(CanvaWidthTxtBox.Text);
                    _currentCanvaRectangle.Width = width;
                    CanvaYTxtBox.Text = _currentCanvaRectangle.Center.coord_Y.ToString();

                    CanvaRectanglesListBoxItems[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex].Substring(0, CanvaRectanglesListBoxItems[selectedIndex].IndexOf('L')) + ($"L={_currentCanvaRectangle.Length};W={_currentCanvaRectangle.Width};X={_currentCanvaRectangle.Center.coord_X};Y={_currentCanvaRectangle.Center.coord_Y}");
                    CanvaRectListBox.Items[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex];

                    _rectanglesPanels[selectedIndex].Width = width;

                    _rectanglesPanels[selectedIndex].Location = new Point((int)_currentCanvaRectangle.Center.coord_X - _currentCanvaRectangle.Width / 2, (int)_currentCanvaRectangle.Center.coord_Y - _currentCanvaRectangle.Length / 2);
                    _rectanglesPanels[selectedIndex].Width = _currentCanvaRectangle.Width;
                    FindCollision();
                }
            }
            catch (Exception)
            {
                CanvaWidthTxtBox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Осуществляет изменения поля Length у конкретного объекта. Так же динамически изменяет его на канве с проверкой пересечений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanvaLengthTxtBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectListBox.SelectedIndex;
            try
            {
                if (CanvaRectListBox.Items.Count != 0)
                {

                    CanvaLengthTxtBox.BackColor = AppColors.StandartColor;
                    int length = int.Parse(CanvaLengthTxtBox.Text);
                    _currentCanvaRectangle.Length = length;
                    CanvaXTxtBox.Text = _currentCanvaRectangle.Center.coord_X.ToString();

                    double X = _currentCanvaRectangle.Center.coord_X;
                    double Y = _currentCanvaRectangle.Center.coord_Y;

                    CanvaRectanglesListBoxItems[selectedIndex] =
                        CanvaRectanglesListBoxItems[selectedIndex]
                            .Substring(0, CanvaRectanglesListBoxItems[selectedIndex].IndexOf('L')) +
                        ($"L={_currentCanvaRectangle.Length};W={_currentCanvaRectangle.Width};X={X};Y={Y}");
                    CanvaRectListBox.Items[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex];

                    _rectanglesPanels[selectedIndex].Location = new Point(
                        (int)_currentCanvaRectangle.Center.coord_X - _currentCanvaRectangle.Width / 2,
                        (int)_currentCanvaRectangle.Center.coord_Y - _currentCanvaRectangle.Length / 2);
                    _rectanglesPanels[selectedIndex].Height = _currentCanvaRectangle.Length;

                    FindCollision();

                }
            }
            catch (Exception)
            {
                CanvaLengthTxtBox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Обновляет информацию о полях выбранного прямоугольника в ТексБоксах.
        /// </summary>
        private void UpdateRectangleInfo()
        {

            int selectedIndex = CanvaRectListBox.SelectedIndex;
            if (selectedIndex == -1) return;

            _currentCanvaRectangle = _canvaRectangles[selectedIndex];

            CanvaLengthTxtBox.Text = _currentCanvaRectangle.Length.ToString();
            CanvaWidthTxtBox.Text = _currentCanvaRectangle.Width.ToString();

            CanvaIdTxtBox.Text = (_currentCanvaRectangle.ID).ToString();

        }
        /// <summary>
        /// Очищает все ТекстБоксы ,если не созданно ни одного прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            if (CanvaRectListBox.Items.Count == 0)
            {
                CanvaLengthTxtBox.Text = "";
                CanvaLengthTxtBox.ReadOnly = true;

                CanvaWidthTxtBox.Text = "";
                CanvaWidthTxtBox.ReadOnly = true;

                CanvaXTxtBox.Text = "";
                CanvaYTxtBox.Text = "";

                CanvaIdTxtBox.Text = "";
            }
            else
            {
                CanvaLengthTxtBox.ReadOnly = false;
                CanvaWidthTxtBox.ReadOnly = false;
            }
        }
        /// <summary>
        /// Вызывает 2 метода при изменении индекса в ЛистБоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanvaRectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRectangleInfo();
            UpdateRectangleInfo();
        }
    }
}
