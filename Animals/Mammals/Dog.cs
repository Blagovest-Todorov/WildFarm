﻿using Farm.Foods;
using System.Collections.Generic;

namespace Farm.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double BaseWeightModifier = 0.40;
        private static HashSet<string> allowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };

        public Dog(
            string name,
            double weight,
            string livingRegion)
            : base(name, weight, allowedFoods, BaseWeightModifier, livingRegion)
        {
        }
        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}