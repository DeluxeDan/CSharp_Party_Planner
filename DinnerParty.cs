using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;  //a private variable can only be read and written by that instance - or 
                                     //another instance of DinnerParty. Other objects won't know it's there.
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.0M; // M is used for literal monetary values. Think M for money.
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyDecor)
        {
            if (fancyDecor)
            {
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople);

            if (healthyOption)
            {
                return totalCost * .95M; //apply the 5% discount to the overall event cost if the non-alcoholic option was chosen
            }
            else
            {
                return totalCost;
            }

        }
    }
}
