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
    /// Выполняет действия, в зависимости от выбранного времени года.
    /// </summary>
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
                    SetTabBackColor(AppColors.WinterColor);
                    MessageBox.Show("Бррр... Холодно! Даже программа замерзла :/");
                    break;
                case "Spring":
                    SetTabBackColor(AppColors.SpringColor);
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Каникулы :D !!!");
                    break;
                case "Autumn":
                    SetTabBackColor(AppColors.AutumnColor);
                    MessageBox.Show("Я календарь, я календарь, я календарь....");
                    break;
            }
        }
    }
}
