namespace ResturantBill
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
        {
            {"Soda", 1.95m}, {"Tea", 1.50m}, {"Coffee", 1.25m}, {"Mineral Water", 2.95m}, {"Juice", 2.50m}, {"Milk", 1.50m},
            {"Buffalo Wings", 5.95m}, {"Buffalo Fingers", 6.95m}, {"Potato Skins", 8.95m}, {"Nachos", 8.95m}, {"Mushroom Caps", 10.95m}, {"Shrimp Cocktail", 12.95m}, {"Chips and Salsa", 6.95m},
            {"Chicken Alfredo", 13.95m}, {"Chicken Picatta", 13.95m}, {"Turkey Club", 11.95m}, {"Lobster Pie", 19.95m}, {"Prime Rib", 20.95m}, {"Shrimp Scampi", 18.95m}, {"Turkey Dinner", 13.95m}, {"Stuffed Chicken", 14.95m},
            {"Apple Pie", 5.95m}, {"Sundae", 3.95m}, {"Carrot Cake", 5.95m}, {"Mud Pie", 4.95m}, {"Apple Crisp", 5.95m}
        };

        private static Dictionary<string, string> itemCategories = new Dictionary<string, string>()
        {
            {"Soda", "Beverage"}, {"Tea", "Beverage"}, {"Coffee", "Beverage"}, {"Mineral Water", "Beverage"}, {"Juice", "Beverage"}, {"Milk", "Beverage"},
            {"Buffalo Wings", "Appetizer"}, {"Buffalo Fingers", "Appetizer"}, {"Potato Skins", "Appetizer"}, {"Nachos", "Appetizer"}, {"Mushroom Caps", "Appetizer"}, {"Shrimp Cocktail", "Appetizer"}, {"Chips and Salsa", "Appetizer"},
            {"Chicken Alfredo", "Main Course"}, {"Chicken Picatta", "Main Course"}, {"Turkey Club", "Main Course"}, {"Lobster Pie", "Main Course"}, {"Prime Rib", "Main Course"}, {"Shrimp Scampi", "Main Course"}, {"Turkey Dinner", "Main Course"}, {"Stuffed Chicken", "Main Course"},
            {"Apple Pie", "Dessert"}, {"Sundae", "Dessert"}, {"Carrot Cake", "Dessert"}, {"Mud Pie", "Dessert"}, {"Apple Crisp", "Dessert"}
        };
        private List<string> selectedItems = new List<string>();
        public Form1()
        {
            InitializeComponent();
            comboBoxBeverage.Items.AddRange(itemCategories.Where(item => item.Value == "Beverage").Select(item => item.Key).ToArray());
            comboBoxAppetizer.Items.AddRange(itemCategories.Where(item => item.Value == "Appetizer").Select(item => item.Key).ToArray());
            comboBoxMainCourse.Items.AddRange(itemCategories.Where(item => item.Value == "Main Course").Select(item => item.Key).ToArray());
            comboBoxDessert.Items.AddRange(itemCategories.Where(item => item.Value == "Dessert").Select(item => item.Key).ToArray());
            
            comboBoxBeverage.SelectedIndexChanged += AddItemToBill;
            comboBoxAppetizer.SelectedIndexChanged += AddItemToBill;
            comboBoxMainCourse.SelectedIndexChanged += AddItemToBill;
            comboBoxDessert.SelectedIndexChanged += AddItemToBill;

            comboBoxBeverage.SelectedIndex = -1;
            comboBoxAppetizer.SelectedIndex = -1;
            comboBoxMainCourse.SelectedIndex = -1;
            comboBoxDessert.SelectedIndex = -1;
        }
        private void AddItemToBill(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem != null)
            {
                string selectedItem = comboBox.SelectedItem.ToString();

                if (!selectedItems.Contains(selectedItem))
                {
                    selectedItems.Add(selectedItem);
                    UpdateBill();
                }

                comboBox.SelectedIndex = -1;
            }
        }
        private void RemoveItemFromBill(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem != null)
            {
                string selectedItem = comboBox.SelectedItem.ToString();

                if (selectedItems.Contains(selectedItem))
                {
                    selectedItems.Remove(selectedItem);
                    UpdateBill();
                }

                comboBox.SelectedIndex = -1;
            }
        }
        private decimal taxRate = 0.0825m;
        private void UpdateBill()
        {
            decimal subtotal = 0;

            foreach (var item in selectedItems)
            {
                subtotal += menu[item];
            }

            decimal tax = subtotal * taxRate;
            decimal total = subtotal + tax;

            labelSubtotal.Text = $" ${subtotal:0.00}";
            labelTax.Text = $"${tax:0.00}";
            labelTotal.Text = $"${total:0.00}";
        }
        private void ClearBill_Click(object sender, EventArgs e)
        {
            selectedItems.Clear();
            UpdateBill();
        }
        //Made by Sanad And Lana

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
