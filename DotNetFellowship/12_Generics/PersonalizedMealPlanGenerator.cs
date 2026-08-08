using System;

namespace _12_Generics
{
    // Interface
    internal interface IMealPlan
    {
        void DisplayMealPlan();
    }

    // Meal Types
    internal class VegetarianMeal : IMealPlan
    {
        public string MealName { get; set; }

        public VegetarianMeal(string MealName)
        {
            this.MealName = MealName;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine("Meal Type : Vegetarian");
            Console.WriteLine("Meal : " + MealName);
        }
    }

    internal class VeganMeal : IMealPlan
    {
        public string MealName { get; set; }

        public VeganMeal(string MealName)
        {
            this.MealName = MealName;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine("Meal Type : Vegan");
            Console.WriteLine("Meal : " + MealName);
        }
    }

    internal class KetoMeal : IMealPlan
    {
        public string MealName { get; set; }

        public KetoMeal(string MealName)
        {
            this.MealName = MealName;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine("Meal Type : Keto");
            Console.WriteLine("Meal : " + MealName);
        }
    }

    // Generic Class
    internal class Meal<T> where T : IMealPlan
    {
        public T MealPlan { get; set; }

        public Meal(T MealPlan)
        {
            this.MealPlan = MealPlan;
        }

        public void DisplayMeal()
        {
            MealPlan.DisplayMealPlan();
        }
    }

    internal class PersonalizedMealPlanGenerator
    {
        // Generic Method
        public static void GenerateMealPlan<T>(T meal)
            where T : IMealPlan
        {
            Console.WriteLine("===== Personalized Meal Plan =====");

            meal.DisplayMealPlan();

            Console.WriteLine("Meal Plan Generated Successfully!");
        }
    }
}