﻿using System;
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
    public partial class RectanglesControl : UserControl
    {
        Rectangle _currentRectangle = new Rectangle();
        Rectangle[] _rectangles = new Rectangle[5];
        public RectanglesControl()
        {
            InitializeComponent();
            Random random = new Random();
            string[] rectangle_listboxItems = new string[5];
            for (int k = 0; k < 5; k++)
            {
                Colour randcolor = (Colour)random.Next(1, 7);
                Rectangle rectangle = new Rectangle(random.Next(3, 118), random.Next(3, 320), randcolor);
                _rectangles[k] = rectangle;
                rectangle_listboxItems[k] = ($"Rectangle {k + 1}");
            }

            rectangle_listbox.Items.AddRange(rectangle_listboxItems);
        }
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
                lengthtxtbox.BackColor = AppColors.StandartColor;
                int length = int.Parse(lengthtxtbox.Text);
                _currentRectangle.Length = length;

            }
            catch (Exception)
            {
                lengthtxtbox.BackColor = AppColors.InvalidColor;
            }
        }

        private void widthtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            int index = rectangle_listbox.Items.IndexOf(_currentRectangle);
            try
            {
                widthtxtbox.BackColor = AppColors.StandartColor;
                int width = int.Parse(widthtxtbox.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                widthtxtbox.BackColor = AppColors.InvalidColor;
            }
        }
    }
}
