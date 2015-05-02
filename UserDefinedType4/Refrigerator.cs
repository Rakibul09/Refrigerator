using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedType4
{
    class Refrigerator
    {
        public double maximumWeight;
        public int numberOfItems;
        public double weightPerItem;
        public double currentWeight = 0.0;
        public double remainingWeight = 0.0;

        public double GetCurrentWeight()
        {
            double test;

            test = currentWeight + numberOfItems * weightPerItem;

            if (test <= maximumWeight)
            {
                currentWeight = test;
            }
            else
            {
                MessageBox.Show("Too much weight!!");
            }
            return currentWeight;
        }

        public double GetRemainingWeight()
        {
            
            if (currentWeight <= maximumWeight)
            {
                remainingWeight = maximumWeight - currentWeight;

            }
            return remainingWeight;
        }
    }
}
