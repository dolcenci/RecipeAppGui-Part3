   M S B A M L   `   `   `  ����  RecipeAppGUI&     RecipeAppGUI.FilterRecipesDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Filter Recipes��5   	   $	��300��6    $	��400��6-   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��
Filter by:��6!   $
��Bold"�63   $��10q�6E   �� 5   
   $��1��6   $��Ingredient Name:��6!   $��10q�69   �� 5   
   -   5        $��ingredientNameTextBox��5      $��1��6   $��120,10,10,10q�6<   �� 5   
   $��2��6   $��Food Group:��6!   $��10q�64   �� 5   
   -   5        $��foodGroupComboBox��5       $��2��6   $��120,10,10,10q�69   .@�5      �� $	��All��6   �� 5      $
��Meat��6   �� 5      $��	Vegetable��6   �� 5      $��Dairy��6   �� 5      $��Grain��6   �� 5      $��Pasta��6   �� 5      $��	Condiment��6   5      �� 5   
   $��3��6   $��Max Calories:��6!   $��10q�66   �� 5   
   -   5        $��maxCaloriesTextBox��5      $��3��6   $��120,10,10,10q�69   �� 5!   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��10q�6W   .+�5"      �� -   5        $��Apply��5"      $	��100��6%   $��10q�61   6=   �� 5#      -   5        $��Cancel��5#      $	��100��6&   $��10q�62   6>   5$      5%      5&      