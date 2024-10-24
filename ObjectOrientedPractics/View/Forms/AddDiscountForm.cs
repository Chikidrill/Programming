using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
namespace ObjectOrientedPractics.View
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        public bool IsChanged = false;

        /// <summary>
        /// Возвращает категорию скидки.
        /// </summary>
        public Category Category { get; private set; }

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedItem = null;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Закрывает форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            IsChanged = false;
            Close();
        }

        /// <summary>
        /// Закрывает форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                IsChanged = true;
                string ourCateg = CategoryComboBox.Text;
                Category = (Category)Enum.Parse(typeof(Category), ourCateg);
                Close();
            }

        }
    }
}
