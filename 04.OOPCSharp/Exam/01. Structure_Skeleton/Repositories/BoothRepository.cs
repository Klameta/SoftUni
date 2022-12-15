using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ChristmasPastryShop.Repositories
{
    public class BoothRepository : IRepository<IBooth>
    {
        private List<IBooth> models;
        public IReadOnlyCollection<IBooth> Models => models.AsReadOnly();

        private object select;
        public object Select
        {
            get { return select; }
            private set { select = value; }
        }

        public void AddModel(IBooth model)
        {
            models.Add(model);
        }
    }
}
