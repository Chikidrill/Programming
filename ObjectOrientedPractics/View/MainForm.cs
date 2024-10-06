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

            // Инициализация объекта Store
            _cartsTab = new CartsTab();
            _store = new Store();
            _store.LoadData();
            // Присваиваем списки из Store во вкладки
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            // Создаем элемент CartsTab


            // Добавляем элемент управления CartsTab на вкладку Carts
            cartsPage.Controls.Add(_cartsTab);
            _cartsTab.Dock = DockStyle.Fill;  // Растянуть элемент на всю вкладку

            // Инициализируем данные CartsTab
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
