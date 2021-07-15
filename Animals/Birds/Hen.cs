using Farm.Foods;
using System.Collections.Generic;
namespace Farm.Animals.Birds
{
    public class Hen : Bird
    {
        private const double BaseWeightmodifier = 0.35;
        private static HashSet<string> allowedFoods = new HashSet<string>()
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };

        public Hen(
            string name,
            double weight,
            double wingSize)
            : base(name, weight, allowedFoods, BaseWeightmodifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }


    }
}
