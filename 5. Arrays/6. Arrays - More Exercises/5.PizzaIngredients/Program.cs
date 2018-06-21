namespace _5.PizzaIngredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();

            int searchedLength = int.Parse(Console.ReadLine());
            int ingredientsCount = 0;
            var addedIngredients = new List<string>();

            for (int i = 0; i < ingredients.Length && ingredientsCount < 10; i++)
            {
                if (ingredients[i].Length == searchedLength)
                {
                    addedIngredients.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    ingredientsCount++;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients)}.");
        }
    }
}
