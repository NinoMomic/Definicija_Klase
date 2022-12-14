using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definicija_Klase
{
    internal class Program
    {
        class FoodType
        {
            private string name;
            private int protein, carbs, fat;
            static int counter = 0;
            public FoodType()
            {
                counter++;
            }

            public string Name { get => name; set => name = value; }
            public int Protein { get => protein; set => protein = value; }
            public int Carbs { get => carbs; set => carbs = value; }
            public int Fat { get => fat; set => fat = value; }
            public int Counter { get => counter; set => counter = value; }

            public FoodType(string name, int protein, int carbs, int fat)
            {
                this.name = name;
                this.protein = protein;
                this.carbs = carbs;
                this.fat = fat;
            }

            public override string ToString()
            {
                 return name + ":  p - " + protein + "%, c - " + carbs + "%, f - " + fat + "%.";
              

            }

            static int getNumberOfCreatedInstances()
            {
                return counter++;
            }

        }
        class Food
        {
            FoodType type;
            int weigth;
            double protein, carbs, fat;

            public FoodType Type { get => type; set => type = value; }
            public int Weigth { get => weigth; set => weigth = value; }
            public double Protein { get => protein; set => protein = value; }
            public double Carbs { get => carbs; set => carbs = value; }
            public double Fat { get => fat; set => fat = value; }

            public Food(FoodType type, int weigth, double protein, double carbs, double fat)
            {
                this.type = type;
                this.weigth = weigth;
                this.protein = protein;
                this.carbs = carbs;
                this.fat = fat;
            }

            public override string ToString()
            {
                return type + " p - " + protein + "g, c - " + carbs + "g, f - " + fat + "g.";
              

            }

            static void Main(string[] args)
            {
                FoodType foodtype = new FoodType("banana",4, 93, 3);
                Food food = new Food(foodtype, 110, 12, 5, 15);
                Console.WriteLine(food.ToString());

                Console.ReadKey();
            }
        }
    }
}
