using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ChristmasPastryShop.Models
{
    public class Booth : IBooth
    {
        private int boothId;
        private int capacity;

        public int BoothId
        {
            get { return boothId; }
            private set { boothId = value; }
        }



        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0) throw new ArgumentException(string.Format(ExceptionMessages.CapacityLessThanOne, value));
                capacity = value;
            }
        }


        private IRepository<IDelicacy> delicacyMenu;

        public IRepository<IDelicacy> DelicacyMenu
        {
            get { return delicacyMenu; }
        }


        private IRepository<ICocktail> cocktailMenu;

        public IRepository<ICocktail> CocktailMenu
        {
            get { return cocktailMenu; }
        }

        private double currentBill;

        public double CurrentBill
        {
            get { return currentBill; }
            private set { currentBill = value; }
        }


        private double turnover;

        public double Turnover
        {
            get { return turnover; }
            private set { turnover = value; }
        }


        private bool isReserved;

        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
            delicacyMenu = new DelicacyRepository();
            cocktailMenu = new CocktailRepository();
        }

        public bool IsReserved
        {
            get { return isReserved; }
            private set { isReserved = value; }
        }


        public void ChangeStatus()
        {
            if (IsReserved)
            {
                isReserved = false;
            }
            else
            {
                isReserved = true;
            }
        }

        public void Charge()
        {
            Turnover += CurrentBill;
            CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            CurrentBill += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {boothId}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Turnover: {Turnover:F2} lv");
            sb.AppendLine($"-Cocktail menu:");
            sb.AppendLine($"-Cocktail menu:");
            foreach (var cocktail in cocktailMenu.Models)
            {
                sb.AppendLine(cocktail.ToString());
            }

            sb.AppendLine($"-Delicacy menu:");
            foreach (var delic in delicacyMenu.Models)
            {
                sb.AppendLine(delic.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
