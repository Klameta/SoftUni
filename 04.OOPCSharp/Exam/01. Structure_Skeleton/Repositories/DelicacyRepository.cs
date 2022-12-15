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
    public class DelicacyRepository : IRepository<IDelicacy>
    {
        private List<IDelicacy> models;
        public IReadOnlyCollection<IDelicacy> Models => models.AsReadOnly();

        public DelicacyRepository()
        {
            models = new List<IDelicacy>();
        }
        private object select;
        public object Select
        {
            get { return select; }
            private set { select = value; }
        }


        public void AddModel(IDelicacy model)
        {
            models.Add(model);
        }
    }
}
