using Farm.Foods;
using System.Collections.Generic;

namespace Farm.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        private const double BaseWeightModifier = 1;
        private static HashSet<string> allowedFoods = new HashSet<string>()
        {
           nameof(Meat)
        };
        public Tiger(
            string name,
            double weight,
            string livingRegion,
            string breed
            )
            : base(name, weight, allowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
