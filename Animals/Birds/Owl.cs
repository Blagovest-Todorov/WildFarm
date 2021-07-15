using Farm.Foods;
using System.Collections.Generic;
namespace Farm.Animals.Birds
{
    public class Owl : Bird
    {
        private const double BaseWeightmodifier = 0.25;
        private static HashSet<string> AllowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };

        public Owl(
            string name,
            double weight,
            double wingSize)
            : base(name, weight, AllowedFoods, BaseWeightmodifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
