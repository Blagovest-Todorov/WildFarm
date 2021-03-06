using System;
using System.Collections.Generic;
namespace Farm.Animals
{
    public abstract class Animal
    {
        protected Animal(
            string name,
            double weight,
            HashSet<string> allowedFoods,
            double weightModifier
            )
        {
            this.Name = name;
            this.Weight = weight;
            this.AllowedFoods = allowedFoods;
            this.WeightModifier = weightModifier;
        }

        private double WeightModifier { get; set; }
        private HashSet<string> AllowedFoods { get; set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract string ProduceSound();  //Produce a sond and ask for a food

        public void Eat(Food food)
        {
            string foodTypeName = food.GetType().Name;
            // 1.Validate the food, can animal eat this food ?
            // 2.increase the eatenFood
            // 3. increase the Weight of the animal


            if (!AllowedFoods.Contains(foodTypeName))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {foodTypeName}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += this.WeightModifier * food.Quantity;
        }
    }
}
