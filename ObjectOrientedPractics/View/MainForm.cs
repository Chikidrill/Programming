using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;



namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
           
            // ������������� ������� Store
            _store = new Store();
            _store.LoadData();
            // ����������� ������ �� Store �� �������
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _store.SaveData();
        }
    }
}
