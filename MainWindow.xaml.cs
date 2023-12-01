using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_2_Final_Requirements
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // Section 1 : Name Example
    // William Cram
    // 11.30.23
    // Programming 2 Final

    public partial class MainWindow : Window
    {
        List<Department> _departments;
        InventoryItem selectedItem;
        Department selectedDepartment;


        public MainWindow()
        {
            InitializeComponent();
            Preload();

            cmbDepartments.ItemsSource = _departments;


            //lvInventory.ItemsSource = _inventory;


        }

        private void lvInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            int selectedIndex = lvInventory.SelectedIndex;
            selectedItem = selectedDepartment.Inventory[selectedIndex];
            


            //selectedItem = _inventory[selectedIndex];

            if(selectedItem != null)
            {
                rtbDisplay.Text = selectedItem.DisplayInformation();
            }
 
        }

        private void cmbDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Getting the selected index of the department
            int dptIndex = cmbDepartments.SelectedIndex;
            // Getting the selected Department
            selectedDepartment = _departments[dptIndex];
            // Assigning the inventory to the list view
            lvInventory.ItemsSource = selectedDepartment.Inventory;


        } // cmbDepartments_SelectionChanged


        public void Preload()
        {
            _departments = new List<Department>();

            // Index 0
            _departments.Add(new Department("Food"));
            _departments[0].AddItem(new InventoryItem("001", "Organic Bananas", 1.99, true));

            // Index 1
            _departments.Add(new Department("Home"));
            _departments[1].AddItem(new InventoryItem("002", "Almond Milk", 2.99, true));
            // Index 2
            _departments.Add(new Department("Pharmacy"));
            _departments[2].AddItem(new InventoryItem("003", "Rotisserie Chicken", 4.99, true));

            //_inventory = new List<InventoryItem>()
            //{
            //    new InventoryItem("001", "Organic Bananas", 1.99, true),
            //    new InventoryItem("002", "Almond Milk", 2.99, true),
            //    new InventoryItem("003", "Rotisserie Chicken", 4.99, true),
            //    new InventoryItem("004", "Fresh Salmon", 10.99, true),
            //    new InventoryItem("005", "Ground Beef", 5.99, true),
            //    new InventoryItem("006", "Mixed Nuts", 7.99, true),
            //    new InventoryItem("007", "Baguette", 1.50, true),
            //    new InventoryItem("008", "Avocados", 3.99, true),
            //    new InventoryItem("009", "Olive Oil", 6.99, true),
            //    new InventoryItem("010", "Pasta", 1.29, true),
            //    new InventoryItem("011", "Tomato Sauce", 2.49, true),
            //    new InventoryItem("012", "Cheddar Cheese", 4.50, true),
            //    new InventoryItem("013", "Greek Yogurt", 3.99, true),
            //    new InventoryItem("014", "Frozen Berries", 9.99, true),
            //    new InventoryItem("015", "Organic Eggs", 2.99, true),
            //    new InventoryItem("016", "Whole Wheat Bread", 2.50, true),
            //    new InventoryItem("017", "Coffee Beans", 8.99, true),
            //    new InventoryItem("018", "Sparkling Water", 10.99, true),
            //    new InventoryItem("019", "Toilet Paper", 15.99, true),
            //    new InventoryItem("020", "Laundry Detergent", 13.99, true)
            //};
        }


    }
}