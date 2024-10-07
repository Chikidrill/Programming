using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using static ObjectOrientedPractics.View.Tabs.CartsTab;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        private CartsTab _cartsTab;
        private OrdersTab _ordersTab;
        public MainForm()
        {
            InitializeComponent();

            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

            
            _store = new Store();
            _store.LoadData();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            _ordersTab = new OrdersTab();
            OrdersPage.Controls.Add(_ordersTab);
            _ordersTab.Dock = DockStyle.Fill;
            _ordersTab.Customers = _store.Customers; 
            _ordersTab.UpdateOrders();

            _cartsTab = new CartsTab();
            cartsPage.Controls.Add(_cartsTab);
            _cartsTab.Dock = DockStyle.Fill;  
            _cartsTab.Items = _store.Items;
            _cartsTab.Customers = _store.Customers;
        }
        /// <summary>
        /// Осуществляет сохранение данных при закрытии формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _store.SaveData();
        }

        /// <summary>
        /// Осуществляет обновление данных на вкладках при переключении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == cartsPage)
            {
                _cartsTab.RefreshData();
            }
            if (tabControl1.SelectedTab == OrdersPage)
            {
                _ordersTab.RefreshData();
            }
        }
    }
}
