using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using static ObjectOrientedPractics.View.Tabs.CartsTab;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        private CartsTab _cartsTab;
        public MainForm()
        {
            InitializeComponent();

            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

            // ������������� ������� Store
            _cartsTab = new CartsTab();
            _store = new Store();
            _store.LoadData();
            // ����������� ������ �� Store �� �������
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            // ������� ������� CartsTab


            // ��������� ������� ���������� CartsTab �� ������� Carts
            cartsPage.Controls.Add(_cartsTab);
            _cartsTab.Dock = DockStyle.Fill;  // ��������� ������� �� ��� �������

            // �������������� ������ CartsTab
            _cartsTab.Items = _store.Items;
            _cartsTab.Customers = _store.Customers;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _store.SaveData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == cartsPage)
            {
                _cartsTab.RefreshData();
            }
        }
    }
}
