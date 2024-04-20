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
    public partial class SeasonControl : UserControl
    {
        public SeasonControl()
        {
            InitializeComponent();
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                SeasonCombobox.Items.Add(season);
            }
        }
        private void SetTabBackColor(System.Drawing.Color color)
        {
            SeasonGroupBox.BackColor = color;
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
    }
}
