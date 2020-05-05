using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5_ClassExercise
{
    class Cookie
    {
        private bool isGlutenFree;

        public bool IsGlutenFree
        {
            get { return isGlutenFree; }
            set { isGlutenFree = value; }
        }

        private int numberOfEggs;

        public int NumberOfEggs
        {
            get { return numberOfEggs; }
            set { numberOfEggs = value; }
        }

        private int flowerQuantity;

        public int FlowerQuantity
        {
            get { return flowerQuantity; }
            set { flowerQuantity = value; }
        }

        private int sugarQuantity;

        public int SugarQuantity
        {
            get { return sugarQuantity; }
            set { sugarQuantity = value; }
        }

        public string GetDescription()
        {
            return $" is glutenFree: {IsGlutenFree} \n " +
                $"flower: {FlowerQuantity} \n" +
                $"sugar: {SugarQuantity} \n" +
                $"eggs: {NumberOfEggs}";
        }


    }
}
