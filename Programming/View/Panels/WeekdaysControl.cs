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
    public partial class WeekdaysControl : UserControl
    {
        public WeekdaysControl()
        {
            InitializeComponent();
            OutputParseLabel.Text = "";
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
    }
}
