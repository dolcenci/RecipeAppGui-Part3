using System.Windows;
using System.Windows.Controls;


namespace RecipeAppGUI
{
    public partial class FilterRecipesDialog : Window
    {
        public string SelectedIngredientName { get; set; }
        public string SelectedFoodGroup { get; set; }
        public double MaxCalories { get; set; }

        public FilterRecipesDialog()
        {
            InitializeComponent();
        }
        /*the type or namespace name 'ComboBoxItem' could not be found(are you missing a using directive or assembly reference?) line 25. file FilterRecipesDialog.xaml.cs
        the type or namespace name 'Ingredient' could not be found(are you missing a using directive or assembly reference?) line 8. file IngredientInputDialog.xaml.cs
       the type or namespace name 'Ingredient' could not be found(are you missing a using directive or assembly reference?) line 23. file IngredientInputDialog.xaml.cs
        the type or namespace name 'Recipe' could not be found(are you missing a using directive or assembly reference?) line 9. file MainWindow.xaml.cs
         the type or namespace name 'Recipe' could not be found(are you missing a using directive or assembly reference?) line 9. file MainWindow.xaml.cs
        the type or namespace name 'Recipe' could not be found(are you missing a using directive or assembly reference?) line 23. file MainWindow.xaml.cs
         */
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedIngredientName = ingredientNameTextBox.Text.Trim();
            SelectedFoodGroup = (foodGroupComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            double.TryParse(maxCaloriesTextBox.Text.Trim(), out double maxCalories);
            MaxCalories = maxCalories;

            DialogResult = true; // Close dialog and return DialogResult true
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Close dialog and return DialogResult false
        }
    }
}
