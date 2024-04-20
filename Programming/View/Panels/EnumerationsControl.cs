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
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
        }
        private readonly Type[] _typeModel = new Type[]
        {
            typeof(Colour), typeof(EducationForm), typeof(Genres), typeof(Manufacturers), typeof(Season),
            typeof(Weekday)
        };

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
        // Отображение числового значения выбранного элемента перечисления
        private void ValueListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //    // Отображение числового значения выбранного элемента перечисления
            intvaluetxtbox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }

        private void EnumsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
