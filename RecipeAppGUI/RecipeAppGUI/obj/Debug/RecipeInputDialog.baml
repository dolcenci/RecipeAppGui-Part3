   M S B A M L   `   `   `  ����  RecipeAppGUI$    RecipeAppGUI.RecipeInputDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Add New Recipe��5   	   $	��400��6    $	��600��6-   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   �� $��0��6   $��Recipe Name:��6!   $��Center=�65   �� 5   
   -   5        $��recipeNameTextBox��5      $��0��6   $��10q�68   $��Center=�6D   �� 5   
   -   5        $��ingredientsListBox��5      $��1��6   $��10q�69   $	��Top=�6E   $��Stretch=�6]   $	��200��6�   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��5q�6>   ��6$   �� *
Quantity+6>   �� 5      $��5q�6:   ��6$   �� *Unit+6:   �� 5      $��5q�6:   ��6$   �� *Name+6:   5      5      5      �� 5   
   -   5        $��addIngredientButton��5   7   $��1��6   $��Add Ingredient��6   $��Bottom=�6t   $��10q�6�   �� 5   
   -   5        $��instructionsTextBox��5      $��2��6   $��10q�6:   $��Center=�6F    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6v   �� 5   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   $��10q�6W   .+�5       �� -   5        $
��Save��5       $	��100��6$   $��5q�60   6;   �� 5!      -   5        $��Cancel��5!      $	��100��6&   $��5q�62   6=   5"      5#      5$      