using System.Collections.Generic;
using System.Linq;
using System.Windows;
using RecipeApp;
using System.Collections.ObjectModel;


namespace RecipeAppGUI
{
    public partial class MainWindow : Window
    {
        //private List<Recipe> recipes = new List<Recipe>();
        // fix bug below code if dont run replace  with above
        ObservableCollection<Recipe> recipes = new ObservableCollection<Recipe>();

        public MainWindow()
        {
            InitializeComponent();

            // Example: Pre-populate with dummy data (replace with your actual data loading logic)
            LoadDummyData();
            recipeListBox.ItemsSource = recipes;// trying to fix bug

            DisplayAllRecipes();
        }

        private void LoadDummyData()
        {
            // Example: Load dummy recipes
            recipes.Add(new Recipe("Spaghetti Carbonara",
                new List<Ingredient>
                {
                    new Ingredient("Spaghetti", 200, "g", 300, "Pasta"),
                    new Ingredient("Bacon", 150, "g", 500, "Meat"),
                    new Ingredient("Eggs", 2, "units", 150, "Dairy"),
                    new Ingredient("Parmesan Cheese", 50, "g", 200, "Dairy")
                },
                "Cook spaghetti. Fry bacon until crispy. Mix eggs and cheese, then combine with hot spaghetti and bacon. Serve immediately."
            ));

            recipes.Add(new Recipe("Chicken Stir Fry",
                new List<Ingredient>
                {
                    new Ingredient("Chicken Breast", 300, "g", 250, "Meat"),
                    new Ingredient("Broccoli", 200, "g", 100, "Vegetable"),
                    new Ingredient("Bell Pepper", 150, "g", 50, "Vegetable"),
                    new Ingredient("Soy Sauce", 50, "ml", 50, "Condiment"),
                    new Ingredient("Rice", 300, "g", 350, "Grain")
                },
                "Stir fry chicken until cooked. Add vegetables and soy sauce. Serve with rice."
            ));
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /*private void CreateRecipeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Example: Implement logic to create a new recipe (open a new window or dialog)
            Recipe newRecipe = new Recipe();
            // Populate newRecipe with user input
            recipes.Add(newRecipe);

            DisplayAllRecipes(); // Refresh recipe list
        }*/

        private void CreateRecipeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Open a new window or dialog to collect recipe information from the user
            RecipeInputDialog inputDialog = new RecipeInputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                // Retrieve the recipe information from the dialog
                string recipeName = inputDialog.RecipeName;
                List<Ingredient> ingredients = inputDialog.Ingredients;
                string instructions = inputDialog.Instructions;

                // Create a new Recipe object
                Recipe newRecipe = new Recipe(recipeName, ingredients, instructions);

                // Add the new recipe to the recipes list
                recipes.Add(newRecipe);



                // Optionally, refresh the ListBox to reflect changes immediately attempt to fixg
                recipeListBox.Items.Refresh(); // Or set ItemsSource again

                // Refresh the recipe list display
                DisplayAllRecipes();
            }
        }


        private void ViewRecipesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DisplayAllRecipes(); // Refresh recipe list
        }

        private void FilterRecipesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of FilterRecipesDialog
            FilterRecipesDialog filterDialog = new FilterRecipesDialog();

            // Show dialog modally (blocks main window until dialog is closed)
            if (filterDialog.ShowDialog() == true)
            {
                // Retrieve filter criteria from dialog
                string ingredientNameFilter = filterDialog.SelectedIngredientName;
                string foodGroupFilter = filterDialog.SelectedFoodGroup;
                double maxCaloriesFilter = filterDialog.MaxCalories;

                // Example: Filter recipes based on criteria
                var filteredRecipes = recipes.Where(r =>
                    (string.IsNullOrEmpty(ingredientNameFilter) || r.Ingredients.Any(i => i.Name.ToLower().Contains(ingredientNameFilter.ToLower()))) &&
                    (foodGroupFilter == "All" || r.Ingredients.Any(i => i.FoodGroup.ToLower() == foodGroupFilter.ToLower())) &&
                    r.GetTotalCalories() <= maxCaloriesFilter
                ).ToList();

                // Display filtered recipes in ListBox or update UI accordingly
                recipeListBox.ItemsSource = filteredRecipes;
            }
        }


        private void DisplayAllRecipes()
        {
            // Example: Display all recipes in the ListBox
            recipeListBox.ItemsSource = recipes;
        }
    }
}
