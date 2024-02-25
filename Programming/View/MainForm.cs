using System.Reflection;

namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            OutputParseLabel.Text = "";
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                SeasonCombobox.Items.Add(season);
            }

        }
        private readonly Type[] _typeModel = new Type[] { typeof(Colour), typeof(EducationForm), typeof(Genre), typeof(Manufacturers), typeof(Season), typeof(Weekday) };

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
                OutputParseLabel.Text = $"��� ���� ������ ({parsedDay} = {numericValue})";
            }
            else
            {
                OutputParseLabel.Text = "��� ������ ��� ������";
            }
        }
        private void SetTabBackColor(Color color)
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
                    SetTabBackColor(Color.AliceBlue);
                    MessageBox.Show("����... �������! ���� ��������� �������� :/");
                    break;
                case "Spring":
                    SetTabBackColor(Color.Green);
                    break;
                case "Summer":
                    MessageBox.Show("���! �������� :D !!!");
                    break;
                case "Autumn":
                    SetTabBackColor(Color.SandyBrown);
                    MessageBox.Show("� ���������, � ���������, � ���������....");
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // ����������� ��������� �������� ���������� �������� ������������
            intvaluetxtbox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }
    }
}