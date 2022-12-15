using System;
using System.Collections.Generic;
using System.Text;
using NavalVessels.Repositories.Contracts;
using NavalVessels.Utilities.Messages;
using NavalVessels.Models.Contracts;
using System.Linq;

namespace NavalVessels.Repositories
{
    public class VesselRepository : IRepository<IVessel>
    {
        private List<IVessel> models;
        public IReadOnlyCollection<IVessel> Models => models;

        public VesselRepository()
        {
            models = new List<IVessel>();
        }
        public void Add(IVessel model)
        {
            models.Add(model);
        }

        public IVessel FindByName(string name)
        {
            return models.FirstOrDefault(x => x.Name==name);
        }

        public bool Remove(IVessel model)
        {
            return models.Remove(model);
        }
    }
}
