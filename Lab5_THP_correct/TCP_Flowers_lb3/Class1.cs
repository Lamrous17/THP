using System.Collections.Generic;

namespace TCP_Vagetable_lb3
{
    public abstract class AbstractVegetable
    {
        public string Name { get; set; }
        public double CaloriesPer100g { get; set; }
    }

    public class Tomato : AbstractVegetable
    {
        public bool IsGreen { get; set; }
        public bool IsEggplant { get; set; }
        public bool IsPepper { get; set; }
    }

    public class Pumpkin : AbstractVegetable
    {
        public bool IsPumpkin { get; set; }
        public bool IsCocumber { get; set; }
        public bool IsVegMarrow { get; set; }
    }

    public class Legumes : AbstractVegetable
    {
        public bool IsPeas { get; set; }
        public bool IsBeans { get; set; }
    }

    public class Cereals : AbstractVegetable
    {
        public bool IsCorn { get; set; }
    }

    public class Salad
    {
        public List<AbstractVegetable> Vegetables { get; set; }

        public double CalculateCalories()
        {
            double totalCalories = 0;

            foreach (AbstractVegetable vegetable in Vegetables)
            {
                totalCalories += vegetable.CaloriesPer100g;
            }

            return totalCalories;
        }
    }
}