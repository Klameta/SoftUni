using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private BoothRepository booths;
        public Controller()
        {
            booths = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            int id = booths.Models.Count + 1;
            Booth booth = new Booth(id, capacity);
            booths.AddModel(booth);
            return string.Format(OutputMessages.NewBoothAdded, id, capacity);

        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            return "";
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            IDelicacy delicacy;
            if (delicacyTypeName == "Gingerbread")
            {
                delicacy = new Gingerbread(delicacyName);
            }
            else if (delicacyTypeName == "Stolen")
            {
                delicacy = new Stolen(delicacyName);
            }
            else
            {
                return String.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }
            return "";
        }

        public string BoothReport(int boothId)
        {
            return "";
        }

        public string LeaveBooth(int boothId)
        {
            return "";
        }

        public string ReserveBooth(int countOfPeople)
        {
            return "";
        }

        public string TryOrder(int boothId, string order)
        {
            return "";
        }
    }
}
