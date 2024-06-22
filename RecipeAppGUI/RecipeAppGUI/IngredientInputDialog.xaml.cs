using System.Windows;
using System.Windows.Controls;
using RecipeApp;


namespace RecipeAppGUI
{
    public partial class IngredientInputDialog : Window
    {
        public Ingredient SelectedIngredient { get; private set; }

        public IngredientInputDialog()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ingredientNameTextBox.Text.Trim();
            double quantity = double.Parse(quantityTextBox.Text.Trim());
            string unit = unitTextBox.Text.Trim();
            double calories = double.Parse(caloriesTextBox.Text.Trim());
            string foodGroup = (foodGroupComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            SelectedIngredient = new Ingredient(name, quantity, unit, calories, foodGroup);

            DialogResult = true; // Close the dialog with DialogResult true
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Close the dialog with DialogResult false
        }
    }
}
