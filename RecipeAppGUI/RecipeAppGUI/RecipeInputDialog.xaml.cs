using System.Collections.Generic;
using System.Windows;
using RecipeApp;


namespace RecipeAppGUI
{
    public partial class RecipeInputDialog : Window
    {
        public string RecipeName { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public string Instructions { get; private set; }

        public RecipeInputDialog()
        {
            InitializeComponent();
            Ingredients = new List<Ingredient>();
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            // Open a dialog or window to add ingredients (IngredientInputDialog)
            IngredientInputDialog ingredientDialog = new IngredientInputDialog();
            if (ingredientDialog.ShowDialog() == true)
            {
                // Retrieve the ingredient information from the dialog
                Ingredient ingredient = ingredientDialog.SelectedIngredient;
                Ingredients.Add(ingredient);

                // Update the ingredients ListBox
                ingredientsListBox.ItemsSource = null; // Clear the current items source
                ingredientsListBox.ItemsSource = Ingredients; // Set new items source
            }
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            RecipeName = recipeNameTextBox.Text.Trim();
            Instructions = instructionsTextBox.Text.Trim();

            DialogResult = true; // Close the dialog with DialogResult true
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Close the dialog with DialogResult false
        }
    }
}
